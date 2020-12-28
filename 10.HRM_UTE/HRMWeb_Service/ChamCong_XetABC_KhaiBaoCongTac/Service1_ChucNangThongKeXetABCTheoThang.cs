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
        #region Find
        //dem so mau tin
        /*
        public int ThongKeXetABCTheoThang_FindCount(String publicKey, String token, int thang, int nam, Guid? boPhanId, string maNhanSu, Guid webUserId)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                int count = 0;
                ChiTietChamCongNhanVien_Factory factory = ChiTietChamCongNhanVien_Factory.New();
                count = factory.ThongKeXetABCTheoThang_FindCount(thang, nam, boPhanId, maNhanSu, webUserId);


                return count;
            }
            else
            {
                return 0;
            }
        }
        */
        public IEnumerable<DTO_ThongKeXetABCTheoThang> ThongKeXetABCTheoThang_Find(String publicKey, String token, int thang, int nam, Guid? boPhanId, string maNhanSu, Guid webUserId)
        {

            if (Helper.TrustTest(publicKey, token))
            {
                var factory = CC_ChiTietChamCongNhanVien_Factory.New();

                IEnumerable<DTO_ThongKeXetABCTheoThang> list = factory.ThongKeXetABCTheoThang_Find(thang, nam, boPhanId, maNhanSu, webUserId).ToList();
                return list;


            }
            else
            {
                return null;
            }
        }
        public String ThongKeXetABCTheoThang_Find_Json(String publicKey, String token, int thang, int nam, Guid? boPhanId, Guid? idLoaiNhanSu, string maNhanSu, Guid webUserId)
        {//DANG SD
            IEnumerable<DTO_ThongKeXetABCTheoThang> list = ThongKeXetABCTheoThang_Find(publicKey, token, thang, nam, boPhanId, maNhanSu, webUserId);
            String json = JsonConvert.SerializeObject(list);
            return json;
        }





        public IEnumerable<DTO_ThongKeXetABCTheoThang> ThongKeXetABCTheoThang_Cua1NhanVien_Find(String publicKey, String token, int thang, int nam, Guid nhanVienID)
        {

            if (Helper.TrustTest(publicKey, token))
            {
                var factory = CC_ChiTietChamCongNhanVien_Factory.New();

                IEnumerable<DTO_ThongKeXetABCTheoThang> list = factory.ThongKeXetABCTheoThang_Cua1NhanVien_Find(thang, nam, nhanVienID).ToList();
                return list;


            }
            else
            {
                return null;
            }
        }
        public String ThongKeXetABCTheoThang_Cua1NhanVien_Find_Json(String publicKey, String token, int thang, int nam, Guid nhanVienID)
        {//DANG SD
            IEnumerable<DTO_ThongKeXetABCTheoThang> list = ThongKeXetABCTheoThang_Cua1NhanVien_Find(publicKey, token, thang, nam, nhanVienID);
            String json = JsonConvert.SerializeObject(list);
            return json;
        }


        /*
        public IEnumerable<DTO_ThongKeXetABCTheoThang> ThongKeXetABCTheoThang_Find_PhanTrang(String publicKey, String token, int thang,
            int nam, Guid? boPhanId, string maNhanSu, int trang, int soMauTinMoiTrang, Guid webUserId)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                var factory = ChiTietChamCongNhanVien_Factory.New();

                IEnumerable<DTO_ThongKeXetABCTheoThang> list = factory.ThongKeXetABCTheoThang_CoPhanTrang(thang, nam, boPhanId, maNhanSu, trang, soMauTinMoiTrang, webUserId).ToList();
                return list;


            }
            else
            {
                return null;
            }
        }

        public String ThongKeXetABCTheoThang_Find_PhanTrang_Json(String publicKey, String token, int thang, int nam, Guid? boPhanId, string maNhanSu, int trang, int soMauTinMoiTrang, Guid webUserId)
        {
            //IEnumerable<DTO_ChiTietChamCongNhanVien> list = QuanLyXetABC_Find_PhanTrang(publicKey, token, thang, nam, boPhanId, idLoaiNhanSu, diHoc, trang, soMauTinMoiTrang);
            //String json = JsonConvert.SerializeObject(list);
            //return json;

            //if (Helper.TrustTest(publicKey, token))
            //{
            //DateTime date = new DateTime(nam, thang, ngay);
            IEnumerable<DTO_ThongKeXetABCTheoThang> list = ThongKeXetABCTheoThang_Find_PhanTrang(publicKey, token, thang, nam, boPhanId, maNhanSu, trang, soMauTinMoiTrang, webUserId);
            int count = ThongKeXetABCTheoThang_FindCount(publicKey, token, thang, nam, boPhanId, maNhanSu,  webUserId);
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
    }
}
