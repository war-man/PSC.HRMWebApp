﻿using System;
using System.Collections.Generic;
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

namespace HRMWeb_Business.BusinessServiceFactory
{
    public class ChiTietChamCongNhanVien_Factory : BaseFactory<Entities, ChiTietChamCongNhanVien>
    {
        //static readonly Log4netCustom.ILog TracingLog_ = Log4netCustom.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static ERP_Core.BaseEntityObject CreateStandAloneObject()
        {
            return ChiTietChamCongNhanVien_Factory.New().CreateAloneObject();
        }
        public static ChiTietChamCongNhanVien_Factory New()
        {
            return new ChiTietChamCongNhanVien_Factory();
        }
        public ChiTietChamCongNhanVien_Factory()
            : base(Database.NewEntities())
        {

        }

        #region Custom

        public IQueryable<ChiTietChamCongNhanVien> GetAll_GCRecordIsNull()
        {
            var result = from o in this.ObjectSet
                         where o.GCRecord == null
                         select o;
            return result;
        }
        public bool CheckChot(int thang, int nam, Guid bophanId)
        {
            return this.ObjectSet.Any(x => x.BoPhan==bophanId && x.QuanLyChamCongNhanVien1.KyTinhLuong1.Thang==thang && x.QuanLyChamCongNhanVien1.KyTinhLuong1.Nam==nam);
        }
        public bool ExistByQuanLyChamCong(Guid idQLCC)
        {
            return this.ObjectSet.Any(x => x.QuanLyChamCongNhanVien1.Oid==idQLCC);
        }
        public IQueryable<ChiTietChamCongNhanVien> GetListByIdList(List<Guid> idList)
        {
            var result = from o in this.ObjectSet
                         where idList.Any(x => x == o.Oid)
                         select o;
            return result;
        }
        public IQueryable<ChiTietChamCongNhanVien> GetByHoSoNhanVienID(Guid hoSoNhanVienId)
        {
            var result = (from o in this.ObjectSet
                          where o.ThongTinNhanVien == hoSoNhanVienId
                          select o);
            return result;
        }
        public IQueryable<XepLoaiCanBo> GetList_XepLoai()
        {
            var result = (from o in this.Context.XepLoaiCanBoes
                          where o.GCRecord==null
                          select o);
            return result;
        }
        public IQueryable<ChiTietChamCongNhanVien> GetByBoPhanId(Guid boPhanId)
        {
            var result = (from o in this.ObjectSet
                          where o.BoPhan == boPhanId
                          select o);
            return result;
        }
        public ChiTietChamCongNhanVien GetById(Guid id)
        {
            var result = (from o in this.ObjectSet
                          where o.Oid == id
                          select o).SingleOrDefault();
            return result;
        }

        public int ThongKeXetABCTheoThang_FindCount(int thang, int nam, Guid? boPhanId, string maNhanSu, Guid webUserId)
        {

            var result = ThongKeXetABCTheoThang_Find(thang, nam, boPhanId, maNhanSu, webUserId).Count();
            return result;
        }

        public int ThongKeXetABCTheoNam_FindCount(int nam, Guid? boPhanId, string maNhanSu, Guid webUserId)
        {

            var result = ThongKeXetABCTheoNam_Find(nam, boPhanId, maNhanSu, webUserId).Count();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thang">bat buoc</param>
        /// <param name="nam">bat buoc</param>
        /// <param name="boPhanId">null la tat ca</param>
        /// <param name="maNhanSu">null la tat ca</param>
        /// <returns></returns>
        public IQueryable<DTO_ThongKeXetABCTheoThang> ThongKeXetABCTheoThang_Find(int thang, int nam, Guid? boPhanId, string maNhanSu, Guid webUserId)
        {
            BoPhan_Factory tmpFactory = BoPhan_Factory.New();
            tmpFactory.Context = this.Context;
            var danhSachPhongBanPhanQuyen = tmpFactory.GetDanhSachBoPhan_DuocPhanQuyenChoWebUserId_GCRecordIsNull(webUserId).Where(x => boPhanId == null || x.Oid == boPhanId);

            Boolean tatCaMaNhanSu = (String.IsNullOrWhiteSpace(maNhanSu) ? true : false);
            var result = (from o in this.ObjectSet
                          where //(boPhanId == null || o.BoPhan == boPhanId)
                              //&& 
                                    danhSachPhongBanPhanQuyen.Any(x => x.Oid == o.BoPhan)
                                    && (o.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Month == thang
                                    && o.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                    )
                          && (tatCaMaNhanSu || o.ThongTinNhanVien1.NhanVien.HoSo.MaQuanLy == maNhanSu)
                          select new DTO_ThongKeXetABCTheoThang()
                          {
                              MaNhanSu = o.ThongTinNhanVien1.NhanVien.HoSo.MaQuanLy
                              ,
                              HoVaTen = o.ThongTinNhanVien1.NhanVien.HoSo.HoTen
                              ,
                              TenPhongBan = o.BoPhan1.TenBoPhan
                              ,
                              NgayCong = (o.SoNgayCong ?? 0)
                              ,
                              NghiNuaNgay = (o.NghiNuaNgay ?? 0)
                              ,
                              NghiPhep = (o.NghiCoPhep ?? 0)
                              ,
                              NghiRo = (o.NghiRo ?? 0)
                              ,
                              NghiThaiSan = (o.NghiThaiSan ?? 0)
                              ,
                              NghiHe = (o.NghiHe ?? 0)
                              ,
                              Loai = o.DanhGia
                              ,
                              GhiChu = o.DienGiai
                          });
            return result;
        }


        public IQueryable<DTO_ThongKeXetABCTheoThang> ThongKeXetABCTheoThang_Cua1NhanVien_Find(int thang, int nam, Guid nhanVienID)
        {
            BoPhan_Factory tmpFactory = BoPhan_Factory.New();
            tmpFactory.Context = this.Context;
            var result = (from o in this.ObjectSet
                          where
                                     (o.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Month == thang
                                    && o.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                    )
                          && o.ThongTinNhanVien == nhanVienID
                          select new DTO_ThongKeXetABCTheoThang()
                          {
                              MaNhanSu = o.ThongTinNhanVien1.NhanVien.HoSo.MaQuanLy
                              ,
                              HoVaTen = o.ThongTinNhanVien1.NhanVien.HoSo.HoTen
                              ,
                              TenPhongBan = o.BoPhan1.TenBoPhan
                              ,
                              NgayCong = (o.SoNgayCong ?? 0)
                              ,
                              NghiNuaNgay = (o.NghiNuaNgay ?? 0)
                              ,
                              NghiPhep = (o.NghiCoPhep ?? 0)
                              ,
                              NghiRo = (o.NghiRo ?? 0)
                              ,
                              NghiThaiSan = (o.NghiThaiSan ?? 0)
                              ,
                              NghiHe = (o.NghiHe ?? 0)
                              ,
                              Loai = o.DanhGia
                              ,
                              GhiChu = o.DienGiai
                          });
            return result;
        }




        public IQueryable<DTO_ThongKeXetABCTheoThang> ThongKeXetABCTheoThang_CoPhanTrang(int thang, int nam, Guid? boPhanId, string maNhanSu, int trang, int soMauTinMoiTrang, Guid webUserId)
        {
            int soMauTinBoQua = (trang - 1) * soMauTinMoiTrang;

            var result = ThongKeXetABCTheoThang_Find(thang, nam, boPhanId, maNhanSu, webUserId).Skip(soMauTinBoQua).Take(soMauTinMoiTrang);
            return result;
        }

        public IQueryable<DTO_ThongKeXetABCTheoNam> ThongKeXetABCTheoNam_CoPhanTrang(int nam, Guid? boPhanId, string maNhanSu, int trang, int soMauTinMoiTrang, Guid webUserId)
        {
            int soMauTinBoQua = (trang - 1) * soMauTinMoiTrang;

            var result = ThongKeXetABCTheoNam_Find(nam, boPhanId, maNhanSu, webUserId).Skip(soMauTinBoQua).Take(soMauTinMoiTrang);
            return result;
        }


        public IQueryable<DTO_ThongKeXetABCTheoNam> ThongKeXetABCTheoNam_Find(int nam, Guid? boPhanId, string maNhanSu, Guid webUserId)
        {
            BoPhan_Factory tmpFactory = BoPhan_Factory.New();
            tmpFactory.Context = this.Context;
            var danhSachPhongBanPhanQuyen = tmpFactory.GetDanhSachBoPhan_DuocPhanQuyenChoWebUserId_GCRecordIsNull(webUserId).Where(x => boPhanId == null || x.Oid == boPhanId);

            Boolean tatCaMaNhanSu = (String.IsNullOrWhiteSpace(maNhanSu) ? true : false);

            var danhSachHoSoNhanVien = (from obj in this.ObjectSet
                                        where danhSachPhongBanPhanQuyen.Any(x => x.Oid == obj.BoPhan)
                                        && obj.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam

                                        && (tatCaMaNhanSu || obj.ThongTinNhanVien1.NhanVien.HoSo.MaQuanLy == maNhanSu)
                                        select new
                                        {
                                            HS = obj.ThongTinNhanVien1.NhanVien.HoSo
                                            ,
                                            TenBoPhan = obj.BoPhan1.TenBoPhan
                                        }
        ).Distinct();

            var result = (from o in danhSachHoSoNhanVien
                          select new DTO_ThongKeXetABCTheoNam()
                          {
                              MaNhanSu = o.HS.MaQuanLy
                              ,
                              HoVaTen = o.HS.HoTen
                              ,
                              TenPhongBan = o.TenBoPhan
                              ,
                              LoaiA = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "A" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                       ).Count()
                              ,
                              LoaiB = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "B" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                      ).Count()
                              ,
                              LoaiC = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "C" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                      ).Count()
                               ,
                              LoaiD = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "D" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                      ).Count()
                                          ,
                              LoaiKhongXet = (from x in this.Context.ChiTietChamCongNhanViens
                                              where x.DanhGia == "Không xét" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                              && x.ThongTinNhanVien == o.HS.Oid
                                              select 1
                                      ).Count()

                          });
            return result;
        }





        public IQueryable<DTO_ThongKeXetABCTheoNam> ThongKeXetABCTheoNam_Cua1NhanVien_Find(int nam, Guid nhanVienID)
        {
            BoPhan_Factory tmpFactory = BoPhan_Factory.New();
            tmpFactory.Context = this.Context;
            //var danhSachPhongBanPhanQuyen = tmpFactory.GetDanhSachBoPhan_DuocPhanQuyenChoWebUserId(webUserId).Where(x => boPhanId == null || x.Oid == boPhanId);


            var danhSachHoSoNhanVien = (from obj in this.ObjectSet
                                        where
                                         obj.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam

                                        && obj.ThongTinNhanVien == nhanVienID
                                        select new
                                        {
                                            HS = obj.ThongTinNhanVien1.NhanVien.HoSo
                                            ,
                                            TenBoPhan = obj.BoPhan1.TenBoPhan
                                        }
        ).Distinct();

            var result = (from o in danhSachHoSoNhanVien
                          select new DTO_ThongKeXetABCTheoNam()
                          {
                              MaNhanSu = o.HS.MaQuanLy
                              ,
                              HoVaTen = o.HS.HoTen
                              ,
                              TenPhongBan = o.TenBoPhan
                              ,
                              LoaiA = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "A" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                       ).Count()
                              ,
                              LoaiB = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "B" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                      ).Count()
                              ,
                              LoaiC = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "C" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                      ).Count()
                               ,
                              LoaiD = (from x in this.Context.ChiTietChamCongNhanViens
                                       where x.DanhGia == "D" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                       && x.ThongTinNhanVien == o.HS.Oid
                                       select 1
                                      ).Count()
                                          ,
                              LoaiKhongXet = (from x in this.Context.ChiTietChamCongNhanViens
                                              where x.DanhGia == "Không xét" && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                              && x.ThongTinNhanVien == o.HS.Oid
                                              select 1
                                      ).Count()

                          });
            return result;
        }




        public int QuanLyXetABC_FindCount(int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc)
        {

            var result = QuanLyXetABC_Find(thang, nam, boPhanId, idLoaiNhanSu, diHoc).Count();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="thang">bat buoc</param>
        /// <param name="nam">bat buoc</param>
        /// <param name="boPhanId">bat buoc</param>
        /// <param name="idLoaiNhanSu">null la tat ca</param>
        /// <param name="diHoc">null la tat ca</param>
        /// <returns></returns>
        public IQueryable<ChiTietChamCongNhanVien> QuanLyXetABC_Find(int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc)
        {
            var result = (from o in this.ObjectSet
                          where o.BoPhan == boPhanId
                                && (o.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Month == thang
                                    && o.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                    )

                                && (idLoaiNhanSu == null || o.ThongTinNhanVien1.LoaiNhanSu == idLoaiNhanSu)
                                && (diHoc == null || (diHoc.Value && o.ThongTinNhanVien1.NhanVien.TinhTrang1.TenTinhTrang.ToLower().Contains("học")))
                          select o);
            return result;
        }
        public IQueryable<ChiTietChamCongNhanVien> QuanLyXetABCFind_CoPhanTrang(int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc, int trang, int soMauTinMoiTrang)
        {
            int soMauTinBoQua = (trang - 1) * soMauTinMoiTrang;

            var result = QuanLyXetABC_Find(thang, nam, boPhanId, idLoaiNhanSu, diHoc).Skip(soMauTinBoQua).Take(soMauTinMoiTrang);
            return result;
        }



        public static void FullDelete(Entities context, params Object[] deleteList)
        {
            foreach (ChiTietChamCongNhanVien item in deleteList)
            {
                context.DeleteObject(item);
            }
        }
        #endregion
    }//end class
}
