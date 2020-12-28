﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Transactions;
using ERP_Core;
using HRMWeb_Business.BusinessServiceFactory;
using HRMWeb_Business.Model;
using Newtonsoft.Json;

namespace HRMWeb_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public partial class Service1 : IService1
    {

        public IEnumerable<DTO_QuanLyKhaiBaoCongTac_Find> QuanLyKhaiBaoCongTac_Find(String publicKey, String token, int thang, int nam, Guid? boPhanId, int? trangThai, string maNhanSu, Guid webUserId)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                CC_KhaiBaoCongTac_Factory factory = CC_KhaiBaoCongTac_Factory.New();
                IEnumerable<DTO_QuanLyKhaiBaoCongTac_Find> objList = factory.QuanLyKhaiBaoCongTac_Find(thang, nam, boPhanId, trangThai, maNhanSu, webUserId).ToList();
                foreach (DTO_QuanLyKhaiBaoCongTac_Find cc in objList)
                {
                    cc.TuNgayString = FormatTime(cc.TuNgay.Value.Hour) + " giờ " + FormatTime(cc.TuNgay.Value.Minute) + " ngày " + FormatTime(cc.TuNgay.Value.Day) + "/" + FormatTime(cc.TuNgay.Value.Month) + "/" + cc.TuNgay.Value.Year.ToString();
                    cc.DenNgayString = FormatTime(cc.DenNgay.Value.Hour) + " giờ " + FormatTime(cc.DenNgay.Value.Minute) + " ngày " + FormatTime(cc.DenNgay.Value.Day) + "/" + FormatTime(cc.DenNgay.Value.Month) + "/" + cc.DenNgay.Value.Year.ToString();
                    switch (cc.Buoi)
                    {
                        case "0":
                            {
                                cc.Buoi = "Cả ngày";
                            }
                            break;
                        case "1":
                            {
                                cc.Buoi = "Buổi sáng";
                            }
                            break;
                        case "2":
                            {
                                cc.Buoi = "Buổi chiều";
                            }
                            break;
                    }
                }
                return objList;
            }
            else
            {
                throw new Exception("Chứng thực không hợp lệ");
            }
        }
        public String QuanLyKhaiBaoCongTac_Find_Json(String publicKey, String token, int thang, int nam, Guid? boPhanId, int? trangThai, string maNhanSu, Guid webUserId)
        {//DANG SD
            IEnumerable<DTO_QuanLyKhaiBaoCongTac_Find> list = QuanLyKhaiBaoCongTac_Find(publicKey, token, thang, nam, boPhanId, trangThai, maNhanSu, webUserId);
            String json = JsonConvert.SerializeObject(list);
            return json;
        }


        public bool QuanLyKhaiBaoCongTac_ThayDoiTrangThaiList(String publicKey, String token, List<DTO_QuanLyKhaiBaoCongTac_Find> objList, int trangThai)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                using (var tran = new TransactionScope(TransactionScopeOption.Required,
                                    TimeSpan.FromSeconds(360)))
                {


                    CC_KhaiBaoCongTac_Factory factory = CC_KhaiBaoCongTac_Factory.New();
                    foreach (var obj in objList)
                    {
                        if (obj != null)
                        {

                            CC_KhaiBaoCongTac objFromDB = factory.GetByID(obj.Oid);
                            if (objFromDB != null)
                            {
                                objFromDB.TrangThai = trangThai;
                                if (trangThai == 1)
                                {
                                    //thay đổi cột hình thức nghĩ các ngày trong thời gian nghỉ của nhân viên sang null (làm cả ngày)

                                    factory.Context.spd_WebChamCong_CC_ChamCongTheoNgay_CapNhatKhaiBaoCongTac(
                                        objFromDB.IDNhanVien, objFromDB.TuNgay,objFromDB.Buoi);
                                }
                                else if (trangThai == 0)
                                {
                                    factory.Context.spd_WebChamCong_CC_ChamCongTheoNgay_CapNhatTrangThaiChamCong(
                                        objFromDB.IDNhanVien, objFromDB.TuNgay, objFromDB.DenNgay, false);
                                }
                            }

                        }
                    }
                    //////////////
                    try
                    {
                        factory.SaveChangesWithoutTransactionScope();
                        tran.Complete();
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

        public bool QuanLyKhaiBaoCongTac_ThayDoiTrangThaiList_Json(String publicKey, String token, string jsonObjectList, int trangThai)
        {//DANG SD
            //chuyen jsonObject thanh object
            List<DTO_QuanLyKhaiBaoCongTac_Find> objList = JsonConvert.DeserializeObject<List<DTO_QuanLyKhaiBaoCongTac_Find>>(jsonObjectList);
            return QuanLyKhaiBaoCongTac_ThayDoiTrangThaiList(publicKey, token, objList, trangThai);
        }



        public bool QuanLyKhaiBaoCongTac_DeleteList(String publicKey, String token, List<DTO_QuanLyKhaiBaoCongTac_Find> objList)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                using (var transaction = new TransactionScope(TransactionScopeOption.Required,
                    TimeSpan.FromSeconds(360)))
                {
                    CC_KhaiBaoCongTac_Factory factory = CC_KhaiBaoCongTac_Factory.New();
                    foreach (var obj in objList)
                    {
                        if (obj != null)
                        {

                            CC_KhaiBaoCongTac stupidObj = new CC_KhaiBaoCongTac() { Oid = obj.Oid };
                            factory.Attach(stupidObj);
                            CC_KhaiBaoCongTac_Factory.FullDelete(factory.Context, stupidObj);

                            CC_KhaiBaoCongTac objFromDB = CC_KhaiBaoCongTac_Factory.New().GetByID(obj.Oid);
                            factory.Context.spd_WebChamCong_CC_ChamCongTheoNgay_CapNhatTrangThaiChamCong(
                                objFromDB.IDNhanVien, objFromDB.TuNgay, objFromDB.DenNgay, false);

                        }
                    }
                    //////////////
                    try
                    {
                        factory.SaveChangesWithoutTransactionScope();
                        transaction.Complete();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return false;
            }
            return false;
        }

        public bool QuanLyKhaiBaoCongTac_DeleteListList_Json(String publicKey, String token, string jsonObjectList)
        {//DANG SD
            //chuyen jsonObject thanh object
            List<DTO_QuanLyKhaiBaoCongTac_Find> objList = JsonConvert.DeserializeObject<List<DTO_QuanLyKhaiBaoCongTac_Find>>(jsonObjectList);
            return QuanLyKhaiBaoCongTac_DeleteList(publicKey, token, objList);
        }

    }
}
