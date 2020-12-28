﻿using System;
using System.Collections.Generic;
//using System.Data.Common.CommandTrees;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using ERP_Core;
using System.Reflection;
using System.ComponentModel;
using System.Data.Linq;
using System.Data;

using ERP_Business;
using HRMWeb_Business.Model;
using HRMWeb_Business.Model.Context;
using HRMWeb_Business.Predefined;

namespace HRMWeb_Business.BusinessServiceFactory
{
    public class CC_ChamCongTheoNgay_Factory : BaseFactory<Entities, CC_ChamCongTheoNgay>
    {
        //static readonly Log4netCustom.ILog TracingLog_ = Log4netCustom.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static ERP_Core.BaseEntityObject CreateStandAloneObject()
        {
            return CC_ChamCongTheoNgay_Factory.New().CreateAloneObject();
        }
        public static CC_ChamCongTheoNgay_Factory New()
        {
            return new CC_ChamCongTheoNgay_Factory();
        }
        public CC_ChamCongTheoNgay_Factory()
            : base(Database.NewEntities())
        {

        }

        #region Custom

        public bool ExistsByThangNam(int thang, int nam)
        {
            return this.ObjectSet.Any(x => x.Ngay.Month == thang && x.Ngay.Year == nam);
        }

        public CC_ChamCongTheoNgay GetByID(Guid oid)
        {
            var result = (from o in this.ObjectSet
                          where o.Oid == oid
                          select o).SingleOrDefault();
            return result;
        }
        public IQueryable<CC_ChamCongTheoNgay> GetListByIdList(List<Guid> idList)
        {
            var result = (from o in this.ObjectSet
                          where idList.Any(x => x == o.Oid)
                          select o);
            return result;
        }
        public IQueryable<CC_ChamCongTheoNgay> GetBy_HoSoId(Guid hoSoId)
        {
            var result = (from o in this.ObjectSet
                          where o.IDNhanVien == hoSoId
                          select o);
            return result;
        }
        public IQueryable<CC_ChamCongTheoNgay> GetBy_BoPhanId(Guid boPhanId)
        {
            var result = (from o in this.ObjectSet
                          where o.IDBoPhan == boPhanId
                          select o);
            return result;
        }
        public IQueryable<CC_ChamCongTheoNgay> GetBy_Date(DateTime date)
        {
            var result = (from o in this.ObjectSet
                          where EntityFunctions.TruncateTime(o.Ngay) == date.Date
                          select o);
            return result;
        }
        public IQueryable<CC_ChamCongTheoNgay> GetBy_Date_HoSoId(DateTime date, Guid hoSoId)
        {
            var result = (from o in this.ObjectSet
                          where EntityFunctions.TruncateTime(o.Ngay) == date.Date
                          && o.IDNhanVien == hoSoId
                          select o);
            return result;
        }
        public IQueryable<CC_ChamCongTheoNgay> GetBy_ThangNam_HoSoId(int thang, int nam, Guid hoSoId)
        {
            var result = (from o in this.ObjectSet

                          where o.Ngay.Month == thang && o.Ngay.Year == nam
                          && o.IDNhanVien == hoSoId
                          select o);
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="boPhanId">Guid.Empty la tim tat ca bo phan</param>
        /// <param name="trangThaiChamCong">-1 Tat cả trạng thai, 0 chua cham cong, 1 da cham cong</param>
        /// <param name="diHoc"></param>
        /// <returns></returns>
        public int FindCount_QuanlyChamCong(DateTime date, Guid? boPhanId, int trangThaiChamCong, bool? diHoc, string maNhanSu, Guid webUserId, Guid? idLoaiNhanSu)
        {
            bool tatCaTrangThai = (trangThaiChamCong == -1);
            bool daChamCong = (trangThaiChamCong == 1);
            var result = FindForQuanlyChamCong(date, boPhanId, trangThaiChamCong, diHoc, maNhanSu, webUserId, idLoaiNhanSu).Count();
            return result;
        }
        public int FindCount_QuanlyChamCong_ThangVaNam(int thang, int nam, Guid? boPhanId, int trangThaiChamCong, bool? diHoc, string maNhanSu, Guid webUserId, Guid? idLoaiNhanSu)
        {
            bool tatCaTrangThai = (trangThaiChamCong == -1);
            bool daChamCong = (trangThaiChamCong == 1);
            var result = FindForQuanlyChamChong_ThangVaNam(thang, nam, boPhanId, trangThaiChamCong, diHoc, maNhanSu, webUserId, idLoaiNhanSu).Count();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="boPhanId">Guid.Empty la tim tat ca bo phan</param>
        /// <param name="trangThaiChamCong">-1 Tat cả trạng thai, 0 chua cham cong, 1 da cham cong</param>
        /// <param name="diHoc"></param>
        /// <returns></returns>
        public IQueryable<DTO_QuanLyChamCong_Find> FindForQuanlyChamCong(DateTime date, Guid? boPhanId, int trangThaiChamCong, bool? diHoc, string maNhanSu, Guid webUserId, Guid? idLoaiNhanSu)
        {
            BoPhan_Factory tmpFactory = BoPhan_Factory.New();
            tmpFactory.Context = this.Context;

            var danhSachPhongBanPhanQuyen = tmpFactory.GetDanhSachBoPhan_DuocPhanQuyenChoWebUserId_GCRecordIsNull(webUserId).Where(x => boPhanId == null || x.Oid == boPhanId);

            bool tatCaMaNhanSu = (String.IsNullOrWhiteSpace(maNhanSu) == true);
            bool tatCaTrangThai = (trangThaiChamCong == -1);
            bool daChamCong = (trangThaiChamCong == 1);
            var result = (from o in this.ObjectSet
                          where EntityFunctions.TruncateTime(o.Ngay) == date.Date
                                && danhSachPhongBanPhanQuyen.Any(x => x.Oid == o.IDBoPhan)
                                && (tatCaTrangThai || o.DaChamCong == daChamCong)
                                && (diHoc == null || o.DiHoc == diHoc)
                                && (tatCaMaNhanSu == true || o.HoSo.MaQuanLy.Contains(maNhanSu))
                                && (idLoaiNhanSu == null || o.HoSo.NhanVien.ThongTinNhanVien.LoaiNhanSu == idLoaiNhanSu)
                                && o.HoSo.GCRecord==null && o.HoSo.NhanVien.TinhTrang1.DaNghiViec==false
                          orderby o.Department.TenBoPhan, o.HoSo.Ten
                          select new DTO_QuanLyChamCong_Find() { DaChamCong = o.DaChamCong, HoTen = o.HoSo.HoTen, SoHieuCongChuc=o.HoSo.MaQuanLy,MaNhanSu=o.HoSo.MaQuanLy, IDHinhThucNghi = o.IDHinhThucNghi, Ngay = o.Ngay, Oid = o.Oid, TenPhongBan = o.Department.TenBoPhan,TenCa=o.CC_CaChamCong1.TenCa });
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="boPhanId">Guid.Empty la tim tat ca bo phan</param>
        /// <param name="trangThaiChamCong">-1 Tat cả trạng thai, 0 chua cham cong, 1 da cham cong</param>
        /// <param name="diHoc"></param>
        /// <param name="trang"></param>
        /// <param name="soMauTinMoiTrang"></param>
        /// <returns></returns>
        public IQueryable<DTO_QuanLyChamCong_Find> FindForQuanlyChamCong_CoPhanTrang(DateTime date, Guid? boPhanId, int trangThaiChamCong, bool? diHoc, string maNhanSu, int trang, int soMauTinMoiTrang, Guid webUserId, Guid? idLoaiNhanSu)
        {
            int soMauTinBoQua = (trang - 1) * soMauTinMoiTrang;

            bool tatCaTrangThai = (trangThaiChamCong == -1);
            bool daChamCong = (trangThaiChamCong == 1);
            var result = FindForQuanlyChamCong(date, boPhanId, trangThaiChamCong, diHoc, maNhanSu, webUserId, idLoaiNhanSu).Skip(soMauTinBoQua).Take(soMauTinMoiTrang);
            return result;
        }

        public IQueryable<DTO_QuanLyChamCong_Find> FindForQuanlyChamChong_ThangVaNam(int thang, int nam, Guid? boPhanId, int trangThaiChamCong, bool? diHoc, string maNhanSu, Guid webUserId, Guid? idLoaiNhanSu)
        {
            BoPhan_Factory tmpFactory = BoPhan_Factory.New();
            tmpFactory.Context = this.Context;

            var danhSachPhongBanPhanQuyen = tmpFactory.GetDanhSachBoPhan_DuocPhanQuyenChoWebUserId_GCRecordIsNull(webUserId).Where(x => boPhanId == null || x.Oid == boPhanId);


            bool tatCaMaNhanSu = (String.IsNullOrWhiteSpace(maNhanSu) == true);
            bool tatCaTrangThai = (trangThaiChamCong == -1);
            bool daChamCong = (trangThaiChamCong == 1);
            var result = (from o in this.ObjectSet
                          where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                && danhSachPhongBanPhanQuyen.Any(x => x.Oid == o.IDBoPhan)
                                && (tatCaTrangThai || o.DaChamCong == daChamCong)
                                && (diHoc == null || o.DiHoc == diHoc)
                                && (tatCaMaNhanSu == true || o.HoSo.MaQuanLy.Contains(maNhanSu))
                                && (idLoaiNhanSu == null || o.HoSo.NhanVien.ThongTinNhanVien.LoaiNhanSu == idLoaiNhanSu)
                                 && o.HoSo.GCRecord == null && o.HoSo.NhanVien.TinhTrang1.DaNghiViec == false
                          orderby o.Ngay, o.Department.STT, o.HoSo.Ten
                          select new DTO_QuanLyChamCong_Find() { DaChamCong = o.DaChamCong, HoTen = o.HoSo.HoTen, SoHieuCongChuc = o.HoSo.MaQuanLy, MaNhanSu = o.HoSo.MaQuanLy, IDHinhThucNghi = o.IDHinhThucNghi, Ngay = o.Ngay, Oid = o.Oid, TenPhongBan = o.Department.TenBoPhan, TenCa = o.CC_CaChamCong1.TenCa });
            return result;
        }
        public IQueryable<DTO_QuanLyChamCong_Find> FindForQuanlyChamCong_ThangVaNam_CoPhanTrang(int thang, int nam, Guid? boPhanId, int trangThaiChamCong, bool? diHoc, string maNhanSu, int trang, int soMauTinMoiTrang, Guid webUserId, Guid? idLoaiNhanSu)
        {
            int soMauTinBoQua = (trang - 1) * soMauTinMoiTrang;

            bool tatCaTrangThai = (trangThaiChamCong == -1);
            bool daChamCong = (trangThaiChamCong == 1);
            var result = FindForQuanlyChamChong_ThangVaNam(thang, nam, boPhanId, trangThaiChamCong, diHoc, maNhanSu, webUserId, idLoaiNhanSu).Skip(soMauTinBoQua).Take(soMauTinMoiTrang);
            return result;
        }
        public IQueryable<CC_ChamCongTheoNgay> GetBy_Date_HoSoId_BoPhanId(DateTime date, Guid hoSoId, Guid boPhanId)
        {
            var result = (from o in this.ObjectSet
                          where EntityFunctions.TruncateTime(o.Ngay) == date.Date
                          && o.IDNhanVien == hoSoId
                          && o.IDBoPhan == boPhanId
                          select o);
            return result;
        }
        public static void FullDelete(Entities context, params Object[] deleteList)
        {
            foreach (CC_ChamCongTheoNgay item in deleteList)
            {
                context.DeleteObject(item);
            }
        }


        #endregion



        #region Bo sung
        public IQueryable<DTO_QuanLyChamCong_BieuDoVaoRa> QuanLyChamCong_BieuDoVaoRa(int ngay, int thang, int nam, Guid boPhanId)
        {
            Guid? idLoaiNhanSuGiangVien = new Guid("D8A7B32D-CCE6-4DA9-9F6D-6D28F5046D03");
            //luu y chi lay nhan vien hanh chinh (khong phai giang vien)
            var result = (from o in this.Context.CC_ChamCongTheoNgay
                          where (o.Ngay.Year == nam && o.Ngay.Month == thang && o.Ngay.Day == ngay)
                                && (//boPhanId == Guid.Empty || 
                                o.IDBoPhan == boPhanId)
                                && (o.HoSo.NhanVien.ThongTinNhanVien.LoaiNhanSu == null || o.HoSo.NhanVien.ThongTinNhanVien.LoaiNhanSu != idLoaiNhanSuGiangVien)
                                && o.HoSo.GCRecord == null && o.HoSo.NhanVien.TinhTrang1.DaNghiViec == false
                          orderby o.HoSo.Ten, o.Department.TenBoPhan
                          //Quét 4 lần
                          select new DTO_QuanLyChamCong_BieuDoVaoRa() { SoHieuCongChuc = o.HoSo.MaQuanLy, HoTen = o.HoSo.HoTen, IDNhanVien = o.IDNhanVien, Ngay = o.Ngay, GioVaoSang = o.GioVaoSang, GioRaSang = o.GioRaSang, GioVaoChieu=o.GioVaoChieu,GioRaChieu=o.GioRaChieu });
            // Quét 2 lần
            //select new DTO_QuanLyChamCong_BieuDoVaoRa() { SoHieuCongChuc = o.HoSo.NhanVien.ThongTinNhanVien.SoHieuCongChuc, HoTen = o.HoSo.HoTen, IDNhanVien = o.IDNhanVien, Ngay = o.Ngay,GioVao=o.GioVao,GioRa=o.GioRa });
            return result;
        }

        public IQueryable<DTO_QuanLyChamCong_BieuDoVaoRa> QuanLyChamCong_BieuDoVaoRa_Cua1NhanVien(int ngay, int thang, int nam, Guid nhanVienID)
        {
            Guid? idLoaiNhanSuGiangVien = new Guid("D8A7B32D-CCE6-4DA9-9F6D-6D28F5046D03");
            //luu y chi lay nhan vien hanh chinh (khong phai giang vien)
            var result = (from o in this.Context.CC_ChamCongTheoNgay
                          where (o.Ngay.Year == nam && o.Ngay.Month == thang && o.Ngay.Day == ngay)
                                &&
                                o.IDNhanVien == nhanVienID
                                && o.HoSo.NhanVien.ThongTinNhanVien.LoaiNhanSu != idLoaiNhanSuGiangVien
                                && o.HoSo.GCRecord == null && o.HoSo.NhanVien.TinhTrang1.DaNghiViec == false
                          orderby o.HoSo.Ten, o.Department.TenBoPhan
                          //Quét 4 lần
                          select new DTO_QuanLyChamCong_BieuDoVaoRa() { SoHieuCongChuc = o.HoSo.MaQuanLy, HoTen = o.HoSo.HoTen, IDNhanVien = o.IDNhanVien, Ngay = o.Ngay, GioVaoSang = o.GioVaoSang, GioRaSang = o.GioRaSang, GioVaoChieu = o.GioVaoChieu, GioRaChieu = o.GioRaChieu });
            // Quét 2 lần
            //select new DTO_QuanLyChamCong_BieuDoVaoRa() { SoHieuCongChuc = o.HoSo.NhanVien.ThongTinNhanVien.SoHieuCongChuc, HoTen = o.HoSo.HoTen, IDNhanVien = o.IDNhanVien, Ngay = o.Ngay,GioVao=o.GioVao,GioRa=o.GioRa });
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thang">bat buoc</param>
        /// <param name="nam">bat buoc</param>
        /// <param name="idNhanVien">bat buoc</param>
        /// <returns></returns>
        public IQueryable<DTO_QuanLyXetABC_BieuDoVaoRa> XetABC_BieuDoVaoRa(int thang, int nam, Guid idNhanVien)
        {

            var result = (from o in this.Context.CC_ChamCongTheoNgay
                          where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                && o.IDNhanVien == idNhanVien
                          orderby o.HoSo.Ten, o.Department.TenBoPhan
                          //select new DTO_QuanLyXetABC_BieuDoVaoRa() { MaNhanSu = o.HoSo.MaQuanLy, HoTen = o.HoSo.HoTen, IDNhanVien = o.IDNhanVien, Ngay = o.Ngay, GioVao = o.GioVao, GioRa = o.GioRa });
            select new DTO_QuanLyXetABC_BieuDoVaoRa() { MaNhanSu = o.HoSo.MaQuanLy, HoTen = o.HoSo.HoTen, IDNhanVien = o.IDNhanVien, Ngay = o.Ngay });
            return result;
        }
        public DTO_QuanLyXetABC_ChiTietTheoNhanVien XetABC_ChiTietTheoNhanVien(int thang, int nam, Guid idNhanVien)
        {

            var result = (from o in this.Context.CC_ChiTietChamCong
                          where o.ThongTinNhanVien == idNhanVien

                          select new DTO_QuanLyXetABC_ChiTietTheoNhanVien()
                          {
                              MaNhanSu = o.ThongTinNhanVien1.NhanVien.HoSo.MaQuanLy,
                              HoTen = o.ThongTinNhanVien1.NhanVien.HoSo.HoTen,
                              IDNhanVien = o.ThongTinNhanVien.Value,
                              //lấy thêm danh sách bên trong
                              ChiTietChamCong = (from x in this.Context.CC_ChamCongTheoNgay
                                                 where (x.Ngay.Year == nam && x.Ngay.Month == thang)
                                                  && x.IDNhanVien == idNhanVien
                                                 select new DTO_QuanLyXetABC_ChiTietTheoNhanVien_ChamCongNgay()
                                                     {
                                                         CC_ChamCongTheoNgayOid = o.Oid
                                                         ,
                                                         IDNhanVien = x.IDNhanVien
                                                         ,
                                                         Ngay = x.Ngay
                                                         ,
                                                         IDHinhThucNghi = x.IDHinhThucNghi
                                                         ,
                                                         MaHinhThucNghi = (x.IDHinhThucNghi == null ? "+" : x.CC_HinhThucNghi.KyHieu)

                                                     }
                                                                  ).ToList()
                              //
                          }).SingleOrDefault();
            return result;
        }
        public IQueryable<DTO_QuanLyChamCong_ThongTinChamCongThang> QuanLyChamCong_ThongTinChamCongThang(int thang, int nam, Guid boPhanId, string maNhanSu, Guid? idLoaiNhanSu)
        {
            bool tatCaMaNhanSu = (String.IsNullOrWhiteSpace(maNhanSu) == true);
            //lay danh sach nhan vien
            var dsIdNhanVien = (from o in this.ObjectSet
                                where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                      && (o.IDBoPhan == boPhanId)
                                      && (tatCaMaNhanSu || o.HoSo.MaQuanLy == maNhanSu)
                                      && (idLoaiNhanSu == null || o.HoSo.NhanVien.ThongTinNhanVien.LoaiNhanSu == idLoaiNhanSu)
                                       && o.HoSo.GCRecord == null && o.HoSo.NhanVien.TinhTrang1.DaNghiViec == false
                                orderby
                                    //o.HoSo.NhanVien.ThongTinNhanVien.LoaiNhanSu1.MaQuanLy
                                    //, 
                                o.HoSo.Ten
                                select o.IDNhanVien).Distinct();
            var result = (from idNv in dsIdNhanVien
                          join hs in this.Context.HoSoes on idNv equals hs.Oid
                          select new DTO_QuanLyChamCong_ThongTinChamCongThang
                          {

                              IDNhanVien = idNv
                              ,
                              HoTen = hs.HoTen
                              ,
                              MaNhanSu = hs.MaQuanLy
                              ,
                              LaNhanVienToChucHanhChinh = (hs.NhanVien.ThongTinNhanVien.LoaiNhanSu1 != null ? !(hs.NhanVien.ThongTinNhanVien.LoaiNhanSu1.TenLoaiNhanSu.ToLower().Contains("giảng viên")) : false)
                              ,
                              ChiTietChamCong = (from o in this.Context.CC_ChamCongTheoNgay
                                                 where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                 && o.IDBoPhan == boPhanId && o.IDNhanVien == idNv
                                                 orderby o.Ngay ascending
                                                 select new DTO_QuanLyChamCong_ChamCongNgay()
                                                 {
                                                     CC_ChamCongTheoNgayOid = o.Oid
                                                     ,
                                                     IDNhanVien = o.IDNhanVien
                                                     ,
                                                     Ngay = o.Ngay
                                                     ,
                                                     MaHinhThucNghi = (o.IDHinhThucNghi == null ? "+" : o.CC_HinhThucNghi.KyHieu)
                                                     //,
                                                     //DaChamCong = o.DaChamCong
                                                 }
                                                              ).ToList()//.OrderBy(x => x.Ngay)
                            ,
                              HuongLuong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                      where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                        && o.IDBoPhan == boPhanId && o.IDNhanVien == idNv
                                                                        && (o.IDHinhThucNghi == null || o.IDHinhThucNghi == HinhThucNghiConst.LamNuaNgayId || o.IDHinhThucNghi == HinhThucNghiConst.DiCongTacId)
                                                      select (o.IDHinhThucNghi == null ? 1 : o.CC_HinhThucNghi.GiaTri)).Sum(),
                              Phep = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                  && o.IDBoPhan == boPhanId && o.IDNhanVien == idNv
                                                                  && (o.CC_HinhThucNghi.PhanLoai == 2)
                                                select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                              KhongLuong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                      where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                        && o.IDBoPhan == boPhanId && o.IDNhanVien == idNv
                                                                        && (o.CC_HinhThucNghi.PhanLoai == 0)
                                                      select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                              BHXH = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                  && o.IDBoPhan == boPhanId && o.IDNhanVien == idNv
                                                                  && (o.CC_HinhThucNghi.PhanLoai == 1)
                                                select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                              TongCong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                    where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                      && o.IDBoPhan == boPhanId && o.IDNhanVien == idNv
                                                                      && (o.IDHinhThucNghi == null || o.IDHinhThucNghi == HinhThucNghiConst.LamNuaNgayId || o.CC_HinhThucNghi.PhanLoai == 2)
                                                    select (o.IDHinhThucNghi == null ? 1 : o.CC_HinhThucNghi.GiaTri)).Sum()
                          });

            return result;
        }
        public IEnumerable<DTO_QuanLyChamCong_ThongTinChamCongThang_All> QuanLyChamCong_ThongTinChamCongThang_All(int thang, int nam, string webUserId)
        {
            Guid UserId = webUserId != "" ? new Guid(webUserId) : Guid.Empty;
            var dsBoPhans = (from o in this.Context.Departments
                             where o.WebUser_Department.Any(x => x.IDWebUser == UserId)
                             && o.ParentDepartment != null
                             && o.GCRecord == null
                             orderby o.STT ascending
                             select o).ToList();
            var result = (from boPhan in dsBoPhans
                          select new DTO_QuanLyChamCong_ThongTinChamCongThang_All()
                          {
                              TenBoPhan = boPhan.TenBoPhan,
                              STT = boPhan.STT.ToString(),
                              ThongTinChamCongThang = (from idNv in (from o in this.ObjectSet
                                                                     where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                     && (o.IDBoPhan == boPhan.Oid)
                                                                     && (o.HoSo.NhanVien.TinhTrang1.DaNghiViec ?? false) == false
                                                                     orderby
                                                                     o.HoSo.Ten
                                                                     select o.IDNhanVien).Distinct()
                                                       join hs in this.Context.HoSoes on idNv equals hs.Oid
                                                       orderby hs.Ten
                                                       select new DTO_QuanLyChamCong_ThongTinChamCongThang()
                                                       {

                                                           IDNhanVien = idNv
                                                           ,
                                                           HoTen = hs.HoTen
                                                           ,
                                                           Ten = hs.Ten
                                                           ,
                                                           MaNhanSu = hs.MaQuanLy
                                                           ,
                                                           LaNhanVienToChucHanhChinh = (hs.NhanVien.ThongTinNhanVien.LoaiNhanSu1 != null ? !(hs.NhanVien.ThongTinNhanVien.LoaiNhanSu1.TenLoaiNhanSu.ToLower().Contains("giảng viên")) : false)
                                                           ,
                                                           ChiTietChamCong = (from o in this.Context.CC_ChamCongTheoNgay
                                                                              where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                              && o.IDBoPhan == boPhan.Oid && o.IDNhanVien == idNv
                                                                              orderby o.Ngay ascending
                                                                              select new DTO_QuanLyChamCong_ChamCongNgay()
                                                                              {
                                                                                  CC_ChamCongTheoNgayOid = o.Oid
                                                                                  ,
                                                                                  IDNhanVien = o.IDNhanVien
                                                                                  ,
                                                                                  Ngay = o.Ngay
                                                                                  ,
                                                                                  MaHinhThucNghi = (o.IDHinhThucNghi == null ? "+" : o.CC_HinhThucNghi.MaQuanLy),
                                                                                  KyHieu = (o.IDHinhThucNghi == null ? "+" : o.CC_HinhThucNghi.KyHieu),
                                                                              }
                                                                                           ).ToList()
                                                         ,
                                                           HuongLuong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                                                   where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                                                     && o.IDBoPhan == boPhan.Oid && o.IDNhanVien == idNv
                                                                                                      && (o.IDHinhThucNghi == null || o.IDHinhThucNghi == HinhThucNghiConst.LamNuaNgayId || o.IDHinhThucNghi == HinhThucNghiConst.DiCongTacId)
                                                                                   select (o.IDHinhThucNghi == null ? 1 : o.CC_HinhThucNghi.GiaTri)).Sum(),
                                                           Phep = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                                             where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                                               && o.IDBoPhan == boPhan.Oid && o.IDNhanVien == idNv
                                                                                               && (o.CC_HinhThucNghi.PhanLoai == 2)
                                                                             select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                                                           KhongLuong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                                                   where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                                                     && o.IDBoPhan == boPhan.Oid && o.IDNhanVien == idNv
                                                                                                     && (o.CC_HinhThucNghi.PhanLoai == 0)
                                                                                   select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                                                           BHXH = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                                             where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                                               && o.IDBoPhan == boPhan.Oid && o.IDNhanVien == idNv
                                                                                               && (o.CC_HinhThucNghi.PhanLoai == 1)
                                                                             select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                                                           TongCong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                                                 where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                                                   && o.IDBoPhan == boPhan.Oid && o.IDNhanVien == idNv
                                                                                                   && (o.IDHinhThucNghi == null || o.IDHinhThucNghi == HinhThucNghiConst.LamNuaNgayId || o.CC_HinhThucNghi.PhanLoai == 2)
                                                                                 select (o.IDHinhThucNghi == null ? 1 : o.CC_HinhThucNghi.GiaTri)).Sum()
                                                       }).ToList()
                          });
            return result;
        }
        public IQueryable<DTO_QuanLyChamCong_ThongTinChamCongThang> QuanLyChamCong_ThongTinChamCongThang_Cua1NhanVien(int thang, int nam, Guid nhanVienID)
        {

            //lay danh sach nhan vien
            var dsIdNhanVien = (from o in this.ObjectSet
                                where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                      && o.IDNhanVien == nhanVienID
                                       && o.HoSo.GCRecord == null && o.HoSo.NhanVien.TinhTrang1.DaNghiViec == false
                                select o.IDNhanVien).Distinct();
            var result = (from idNv in dsIdNhanVien
                          join hs in this.Context.HoSoes on idNv equals hs.Oid
                          select new DTO_QuanLyChamCong_ThongTinChamCongThang
                          {

                              IDNhanVien = idNv
                              ,
                              HoTen = hs.HoTen
                              ,
                              MaNhanSu = hs.MaQuanLy
                              ,
                              LaNhanVienToChucHanhChinh = (hs.NhanVien.ThongTinNhanVien.LoaiNhanSu1 != null ? !(hs.NhanVien.ThongTinNhanVien.LoaiNhanSu1.TenLoaiNhanSu.ToLower().Contains("giảng viên")) : false)
                              ,
                              ChiTietChamCong = (from o in this.Context.CC_ChamCongTheoNgay
                                                 where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                 && o.IDNhanVien == idNv
                                                 orderby o.Ngay ascending
                                                 select new DTO_QuanLyChamCong_ChamCongNgay()
                                                 {
                                                     CC_ChamCongTheoNgayOid = o.Oid
                                                     ,
                                                     IDNhanVien = o.IDNhanVien
                                                     ,
                                                     Ngay = o.Ngay
                                                     ,
                                                     MaHinhThucNghi = (o.IDHinhThucNghi == null ? "+" : o.CC_HinhThucNghi.KyHieu)
                                                     //,
                                                     //DaChamCong = o.DaChamCong
                                                 }
                                                              ).ToList()//.OrderBy(x => x.Ngay)
                            ,
                              HuongLuong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                      where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                        && o.IDNhanVien == idNv
                                                                        && (o.IDHinhThucNghi == null || o.IDHinhThucNghi == HinhThucNghiConst.LamNuaNgayId || o.IDHinhThucNghi == HinhThucNghiConst.DiCongTacId)
                                                      select (o.IDHinhThucNghi == null ? 1 : o.CC_HinhThucNghi.GiaTri)).Sum(),
                              Phep = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                  && o.IDNhanVien == idNv
                                                                  && (o.CC_HinhThucNghi.PhanLoai == 2)
                                                select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                              KhongLuong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                      where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                        && o.IDNhanVien == idNv
                                                                        && (o.CC_HinhThucNghi.PhanLoai == 0)
                                                      select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                              BHXH = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                  && o.IDNhanVien == idNv
                                                                  && (o.CC_HinhThucNghi.PhanLoai == 1)
                                                select (o.CC_HinhThucNghi.GiaTri ?? (decimal?)0)).Sum(),
                              TongCong = (decimal?)(from o in this.Context.CC_ChamCongTheoNgay
                                                    where (o.Ngay.Year == nam && o.Ngay.Month == thang)
                                                                      && o.IDNhanVien == idNv
                                                                      && (o.IDHinhThucNghi == null || o.IDHinhThucNghi == HinhThucNghiConst.LamNuaNgayId || o.CC_HinhThucNghi.PhanLoai == 2)
                                                    select (o.IDHinhThucNghi == null ? 1 : o.CC_HinhThucNghi.GiaTri)).Sum()
                          });

            return result;
        }
        public bool CheckDangSuDung(Guid Oid)
        {
            bool result = false;
            result = this.ObjectSet.Any(c => c.CC_CaChamCong == Oid);
            return result;
        }
        #endregion
    }//end class
}
