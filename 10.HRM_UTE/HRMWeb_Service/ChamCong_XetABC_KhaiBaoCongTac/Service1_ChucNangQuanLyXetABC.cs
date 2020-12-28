﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ERP_Core;
using HRMWeb_Business.BusinessServiceFactory;
using HRMWeb_Business.Model;
using HRMWeb_Business.Predefined;
using Newtonsoft.Json;

namespace HRMWeb_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public partial class Service1 : IService1
    {


        private static void FormatNgayNghi(CC_ChiTietChamCongNhanVien chiTietChamCongNhanVien)
        {
            decimal tongNgayNghi = (chiTietChamCongNhanVien.NghiCoPhep != null ? chiTietChamCongNhanVien.NghiCoPhep.Value : 0)
                                    + (chiTietChamCongNhanVien.NghiDiHocCoLuong != null ? chiTietChamCongNhanVien.NghiDiHocCoLuong.Value : 0)
                                    + (chiTietChamCongNhanVien.NghiThaiSan != null ? chiTietChamCongNhanVien.NghiThaiSan.Value : 0)
                                    + (chiTietChamCongNhanVien.NghiDiHocKhongLuong != null ? chiTietChamCongNhanVien.NghiDiHocKhongLuong.Value : 0)
                                    + (chiTietChamCongNhanVien.NghiOm != null ? chiTietChamCongNhanVien.NghiOm.Value : 0)
                                    + (chiTietChamCongNhanVien.NghiRo != null ? chiTietChamCongNhanVien.NghiRo.Value : 0);

            chiTietChamCongNhanVien.NgayNghiFormat = "<div  class='jqx-grid-cell-wrap'>";
            chiTietChamCongNhanVien.NgayNghiFormat += tongNgayNghi > 0 ? tongNgayNghi + " (" : "";
            chiTietChamCongNhanVien.NgayNghiFormat += (chiTietChamCongNhanVien.NghiRo != null && chiTietChamCongNhanVien.NghiRo > 0) ? "R:" + chiTietChamCongNhanVien.NghiRo.ToString() + "," : "";
            chiTietChamCongNhanVien.NgayNghiFormat += (chiTietChamCongNhanVien.NghiThaiSan != null && chiTietChamCongNhanVien.NghiThaiSan > 0) ? "TS:" + chiTietChamCongNhanVien.NghiThaiSan.ToString() + "," : "";
            chiTietChamCongNhanVien.NgayNghiFormat += (chiTietChamCongNhanVien.NghiCoPhep != null && chiTietChamCongNhanVien.NghiCoPhep > 0) ? "P:" + chiTietChamCongNhanVien.NghiCoPhep.ToString() + "," : "";
            chiTietChamCongNhanVien.NgayNghiFormat += (chiTietChamCongNhanVien.NghiDiHocCoLuong != null && chiTietChamCongNhanVien.NghiDiHocCoLuong > 0) ? "T,N:" + chiTietChamCongNhanVien.NghiDiHocCoLuong.ToString() + "," : "";
            chiTietChamCongNhanVien.NgayNghiFormat += (chiTietChamCongNhanVien.NghiDiHocKhongLuong != null && chiTietChamCongNhanVien.NghiDiHocKhongLuong > 0) ? "T,K:" + chiTietChamCongNhanVien.NghiDiHocKhongLuong.ToString() + "," : "";
            chiTietChamCongNhanVien.NgayNghiFormat += (chiTietChamCongNhanVien.NghiOm != null && chiTietChamCongNhanVien.NghiOm > 0) ? "Cô,Ô:" + chiTietChamCongNhanVien.NghiOm.ToString() + "" : "";
            chiTietChamCongNhanVien.NgayNghiFormat += tongNgayNghi > 0 ? ") </div>" : "</div>";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="publicKey"></param>
        /// <param name="token"></param>
        /// <param name="thang">bat buoc</param>
        /// <param name="nam">bat buoc</param>
        /// <param name="idNhanVien">bat buoc</param>
        /// <returns></returns>
        public IEnumerable<DTO_QuanLyXetABC_BieuDoVaoRa> QuanLyXetABC_BieuDoVaoRa(String publicKey, String token,
           int thang, int nam, Guid idNhanVien)
        {
            if (Helper.TrustTest(publicKey, token))
            {

                CC_ChamCongTheoNgay_Factory factory = CC_ChamCongTheoNgay_Factory.New();
                IEnumerable<DTO_QuanLyXetABC_BieuDoVaoRa> list = null;

                list = factory.XetABC_BieuDoVaoRa(thang, nam, idNhanVien);



                return list;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="publicKey"></param>
        /// <param name="token"></param>
        /// <param name="thang">bat buoc</param>
        /// <param name="nam">bat buoc</param>
        /// <param name="idNhanVien">bat buoc</param>
        /// <returns></returns>
        public String QuanLyXetABC_BieuDoVaoRa_Json(String publicKey, String token,
           int thang, int nam, Guid idNhanVien)
        {//DANG SD
            IEnumerable<DTO_QuanLyXetABC_BieuDoVaoRa> list = QuanLyXetABC_BieuDoVaoRa(publicKey, token, thang, nam, idNhanVien);
            String json = JsonConvert.SerializeObject(list);
            return json;

        }
        // ////////////////////////////////////////////
        public DTO_QuanLyXetABC_ChiTietTheoNhanVien QuanLyXetABC_ChiTietTheoNhanVien(String publicKey, String token,
   int thang, int nam, Guid idNhanVien)
        {
            if (Helper.TrustTest(publicKey, token))
            {

                CC_ChamCongTheoNgay_Factory factory = CC_ChamCongTheoNgay_Factory.New();
                DTO_QuanLyXetABC_ChiTietTheoNhanVien obj = null;

                obj = factory.XetABC_ChiTietTheoNhanVien(thang, nam, idNhanVien);



                return obj;
            }
            else
            {
                return null;
            }
        }

        public String QuanLyXetABC_ChiTietTheoNhanVien_Json(String publicKey, String token,
   int thang, int nam, Guid idNhanVien)
        {//DANG SD
            DTO_QuanLyXetABC_ChiTietTheoNhanVien obj = QuanLyXetABC_ChiTietTheoNhanVien(publicKey, token, thang, nam, idNhanVien);
            String json = JsonConvert.SerializeObject(obj);
            return json;

        }
        #region QuanLyXetABC_Find
        //dem so mau tin
        /*
        public int QuanLyXetABC_FindCount(String publicKey, String token, int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                int count = 0;
                ChiTietChamCongNhanVien_Factory factory = ChiTietChamCongNhanVien_Factory.New();
                count = factory.QuanLyXetABC_FindCount(thang, nam, boPhanId, idLoaiNhanSu, diHoc);


                return count;
            }
            else
            {
                return 0;
            }
        }
        */
        public IEnumerable<DTO_ChiTietChamCongNhanVien> QuanLyXetABC_Find(String publicKey, String token, int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc)
        {

            if (Helper.TrustTest(publicKey, token))
            {
                var factory = CC_ChiTietChamCongNhanVien_Factory.New();
                var tmpList = factory.QuanLyXetABC_Find(thang, nam, boPhanId, idLoaiNhanSu, diHoc).ToList();
                
                if (tmpList != null)
                {
                    List<DTO_ChiTietChamCongNhanVien> list = new List<DTO_ChiTietChamCongNhanVien>();
                    foreach (var cc in tmpList)
                    {
                        FormatNgayNghi(cc);
                        //
                        DTO_ChiTietChamCongNhanVien item = new DTO_ChiTietChamCongNhanVien();
                        item.Oid = cc.Oid;
                        item.SoHieuCongChuc = cc.ThongTinNhanVien1.SoHieuCongChuc;
                        item.HoVaTen = cc.ThongTinNhanVien1.NhanVien.HoSo.HoTen;
                        item.SoNgayCong = cc.SoNgayCong.ToString();
                        item.DanhGia = cc.DanhGia;
                        item.NgayNghiFormat = cc.NgayNghiFormat;
                        item.DienGiai = cc.DienGiai;
                        item.TrangThai = cc.TrangThai;
                        item.Khoa = cc.Khoa;
                        item.Ho = cc.ThongTinNhanVien1.NhanVien.HoSo.Ho;
                        item.Ten = cc.ThongTinNhanVien1.NhanVien.HoSo.Ten;
                        list.Add(item);
                    }
                    return list.OrderBy(x=>x.Ten);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }        
        public String QuanLyXetABC_Find_Json(String publicKey, String token, int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc)
        {//DANG SD
            IEnumerable<DTO_ChiTietChamCongNhanVien> list = QuanLyXetABC_Find(publicKey, token, thang, nam, boPhanId, idLoaiNhanSu, diHoc);
            String json = JsonConvert.SerializeObject(list);
            return json;
        }
        //public String QuanLyXetABC_Find_Json(String publicKey, String token, int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc)
        //{//DANG SD
        //    IEnumerable<DTO_ChiTietChamCongNhanVien> list = QuanLyXetABC_Find(publicKey, token, thang, nam, boPhanId, idLoaiNhanSu, diHoc);
        //    String json = JsonConvert.SerializeObject(list);
        //    return json;
        //}
        /*
        public IEnumerable<DTO_ChiTietChamCongNhanVien> QuanLyXetABC_Find_PhanTrang(String publicKey, String token, int thang,
            int nam, Guid boPhanId, Guid? idLoaiNhanSu, Boolean? diHoc, int trang, int soMauTinMoiTrang)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                ChiTietChamCongNhanVien_Factory factory = ChiTietChamCongNhanVien_Factory.New();
                var tmpList = factory.QuanLyXetABCFind_CoPhanTrang(thang, nam, boPhanId, idLoaiNhanSu, diHoc, trang,
                    soMauTinMoiTrang);
                if (tmpList != null)
                {
                    foreach (var chiTietChamCongNhanVien in tmpList)
                    {
                        GetSetChild(chiTietChamCongNhanVien);
                    }


                    IEnumerable<DTO_ChiTietChamCongNhanVien> list = tmpList.Map<DTO_ChiTietChamCongNhanVien>();
                    return list;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public String QuanLyXetABC_Find_PhanTrang_Json(String publicKey, String token, int thang, int nam, Guid boPhanId, Guid? idLoaiNhanSu, bool? diHoc, int trang, int soMauTinMoiTrang)
        {
            //IEnumerable<DTO_ChiTietChamCongNhanVien> list = QuanLyXetABC_Find_PhanTrang(publicKey, token, thang, nam, boPhanId, idLoaiNhanSu, diHoc, trang, soMauTinMoiTrang);
            //String json = JsonConvert.SerializeObject(list);
            //return json;

            //if (Helper.TrustTest(publicKey, token))
            //{
            //DateTime date = new DateTime(nam, thang, ngay);
            IEnumerable<DTO_ChiTietChamCongNhanVien> list = QuanLyXetABC_Find_PhanTrang(publicKey, token, thang, nam, boPhanId, idLoaiNhanSu, diHoc, trang, soMauTinMoiTrang);
            int count = QuanLyXetABC_FindCount(publicKey, token, thang, nam, boPhanId, idLoaiNhanSu, diHoc);
            var result = new { Data = list, Total = count };
            String json = JsonConvert.SerializeObject(result);
            return json;
            //}
            //else
            //{
            //    return null;
            //}
        }
        */
        #endregion

        #region Save
        // Save////////////////////////////////////////////
        public bool QuanLyXetABC_Save(String publicKey, String token, DTO_ChiTietChamCongNhanVien obj)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                if (obj != null)
                {
                    CC_ChiTietChamCongNhanVien_Factory factory = CC_ChiTietChamCongNhanVien_Factory.New();
                    CC_ChiTietChamCongNhanVien objFromDB = factory.GetById(obj.Oid);
                    if (objFromDB != null && (objFromDB.Khoa ?? false) == false)
                    {
                        //cap nhat
                        objFromDB.CopyIncludedPropertiesFrom(obj, "DanhGia", "DienGiai", "TrangThai");
                    }
                    //////////////
                    try
                    {
                        factory.SaveChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                return false;
            }
            return false;
        }
        public bool QuanLyXetABC_Save_Json(String publicKey, String token, string jsonObject)
        {
            //chuyen jsonObject thanh object
            DTO_ChiTietChamCongNhanVien obj = JsonConvert.DeserializeObject<DTO_ChiTietChamCongNhanVien>(jsonObject);
            return QuanLyXetABC_Save(publicKey, token, obj);
        }
        public bool QuanLyXetABC_SaveList(String publicKey, String token, List<DTO_ChiTietChamCongNhanVien> objList)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                CC_ChiTietChamCongNhanVien_Factory factory = CC_ChiTietChamCongNhanVien_Factory.New();
                foreach (var obj in objList)
                {
                    if (obj != null)
                    {

                        CC_ChiTietChamCongNhanVien objFromDB = factory.GetById(obj.Oid);
                        if (objFromDB != null)
                        {
                            //cap nhat
                            objFromDB.CopyIncludedPropertiesFrom(obj, "DanhGia", "DienGiai", "TrangThai");
                        }

                    }
                }
                //////////////
                try
                {
                    factory.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                return false;
            }
            return false;
        }
        public bool QuanLyXetABC_SaveList_Json(String publicKey, String token, string jsonObjectList)
        {//DANG SD
            //chuyen jsonObject thanh object
            List<DTO_ChiTietChamCongNhanVien> objList = JsonConvert.DeserializeObject<List<DTO_ChiTietChamCongNhanVien>>(jsonObjectList);
            return QuanLyXetABC_SaveList(publicKey, token, objList);
        }
        #endregion


        public bool QuanLyXetABC_KhoaVaMoKhoaList(String publicKey, String token, int thang, int nam, Guid idBoPhan, bool khoa)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                CC_ChiTietChamCongNhanVien_Factory factory = CC_ChiTietChamCongNhanVien_Factory.New();
                IQueryable<CC_ChiTietChamCongNhanVien> objList = factory.GetListByThangNamAndBoPhan(thang,nam,idBoPhan);
                //
                foreach (var obj in objList)
                {
                    if (obj != null)
                    {
                        //
                        CC_ChiTietChamCongNhanVien objFromDB = factory.GetById(obj.Oid);
                        if (objFromDB != null)
                        {
                            objFromDB.Khoa = khoa;
                            if (objFromDB.Khoa == false)
                            {
                                objFromDB.DanhGia = objFromDB.SoNgayCong > 0 ? "A" : "Không xét";
                                objFromDB.TrangThai = false;
                            }
                            else
                            {
                                objFromDB.TrangThai = true;
                            }
                        }

                    }
                }
                //////////////
                try
                {
                    factory.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        public bool QuanLyXetABC_XetVaKhongXetList(String publicKey, String token, List<DTO_ChiTietChamCongNhanVien> objList, bool xet)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                CC_ChiTietChamCongNhanVien_Factory factory = CC_ChiTietChamCongNhanVien_Factory.New();
                foreach (var obj in objList)
                {
                    if (obj != null)
                    {

                        CC_ChiTietChamCongNhanVien objFromDB = factory.GetById(obj.Oid);
                        if (objFromDB != null)
                        {
                            objFromDB.TrangThai = xet;
                        }

                    }
                }
                //////////////
                try
                {
                    factory.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                return false;
            }
            return false;
        }


        public bool QuanLyXetABC_KhoaVaMoKhoaList_Json(String publicKey, String token, int thang, int nam, Guid idBoPhan, bool khoa)
        {//DANG SD
            return QuanLyXetABC_KhoaVaMoKhoaList(publicKey, token, thang, nam, idBoPhan, khoa);
        }
        public bool QuanLyXetABC_XetVaKhongXetList_Json(String publicKey, String token, string jsonObjectList, bool xet)
        {//DANG SD
            //chuyen jsonObject thanh object
            List<DTO_ChiTietChamCongNhanVien> objList = JsonConvert.DeserializeObject<List<DTO_ChiTietChamCongNhanVien>>(jsonObjectList);
            return QuanLyXetABC_XetVaKhongXetList(publicKey, token, objList, xet);
        }

        public int CauHinhXetABC_GetThoiGian(String publicKey, String token,Guid Oid)
        {
                CauHinhXetABC_Factory factory = CauHinhXetABC_Factory.New();
                DTO_CauHinhXetABC obj = factory.GetCauHinhXetABC(Oid).Map<DTO_CauHinhXetABC>();
                return obj.ThoiGian??0;
        }

        public bool CauHinhXetABC_Update(String publicKey, String token, Guid Oid, int day)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                CauHinhXetABC_Factory factory = CauHinhXetABC_Factory.New();
                var obj = factory.GetCauHinhXetABC(Oid);
                if (obj != null)
                {
                    obj.ThoiGian = day;
                }
                try
                {
                    factory.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }               
            }
            return false;
        }

    }
}
