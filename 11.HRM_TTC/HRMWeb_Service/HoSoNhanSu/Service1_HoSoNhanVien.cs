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
using Newtonsoft.Json;

namespace HRMWeb_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public partial class Service1 : IService1
    {
        private static void GetSetChild(HoSo hoSo)
        {
            if (hoSo.NhanVien.BoPhan != null)
            {
                hoSo.MaBoPhan = hoSo.NhanVien.BoPhan;
            }
        }
        // ////////////////////////////////////////////
        public DTO_HoSoNhanVien Get_HoSoNhanVienBy_Id(String publicKey, String token, Guid id)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                try
                {
                    HoSo_Factory factory = HoSo_Factory.New();
                    var tmpObj = factory.GetHoSoNhanVienByID(id);
                    //
                    return tmpObj;
                }
                catch (Exception ex) { throw ex; }
               
            }
            else
            {
                return null;
            }
        }

        public String Get_HoSoNhanVienBy_Id_Json(String publicKey, String token, Guid id)
        {//DANG SD
            DTO_HoSoNhanVien obj = Get_HoSoNhanVienBy_Id(publicKey, token, id);
            String json = JsonConvert.SerializeObject(obj);
            return json;
        }
        // ///////////////////////////////////////
        public IEnumerable<DTO_HoSoNhanVien> GetList_HoSoNhanVien(String publicKey, String token)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                HoSo_Factory factory = HoSo_Factory.New();
                IEnumerable<HoSo> tmpList = factory.GetAll_GCRecordIsNull().ToList();
                foreach (HoSo hoSo in tmpList)
                {
                    GetSetChild(hoSo);
                }
                IEnumerable<DTO_HoSoNhanVien> list = tmpList.Map<DTO_HoSoNhanVien>();
                return list;
            }
            else
            {
                return null;
            }
        }



        public String GetList_HoSoNhanVien_Json(String publicKey, String token)
        {
            IEnumerable<DTO_HoSoNhanVien> list = GetList_HoSoNhanVien(publicKey, token);
            String json = JsonConvert.SerializeObject(list);
            return json;
        }
        // ///////////////////////////////////////
        public IEnumerable<DTO_HoSoNhanVien> GetList_HoSoNhanVienBy_MaBoPhan(String publicKey, String token, Guid? maBoPhan, Guid company)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                HoSo_Factory factory = HoSo_Factory.New();
                IEnumerable<DTO_HoSoNhanVien> tmpList = factory.GetListByMaBoPhan_GCRecordIsNull(maBoPhan, company);
                //
                return tmpList;
            }
            else
            {
                return null;
            }
        }
        public String KhaiBaoCongTac_DanhSachTruongDonVi_Json(String publicKey, String token)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                HoSo_Factory factory = HoSo_Factory.New();
                IEnumerable<HoSo> tmpList = factory.KhaiBaoCongTac_DanhSachTruongDonVi().ToList();
                IEnumerable<DTO_HoSoNhanVien> list = tmpList.Map<DTO_HoSoNhanVien>();
                String json = JsonConvert.SerializeObject(list);
                return json;
            }
            else
            {
                return null;
            }
        }
        public String GetList_HoSoNhanVienBy_MaBoPhan_Json(String publicKey, String token, Guid? maBoPhan,Guid company)
        {//DANG SD
            IEnumerable<DTO_HoSoNhanVien> list = GetList_HoSoNhanVienBy_MaBoPhan(publicKey, token, maBoPhan, company);
            String json = JsonConvert.SerializeObject(list);
            return json;
        }

        public String GetList_HoSoNhanVienCoIDChamCong_Json(String publicKey, String token)
        {//DANG SD
            IEnumerable<DTO_HoSoNhanVien> list = GetList_HoSoNhanVienCoIDChamCong(publicKey, token);
            String json = JsonConvert.SerializeObject(list);
            return json;
        }

        public IEnumerable<DTO_HoSoNhanVien> GetList_HoSoNhanVienCoIDChamCong(String publicKey, String token)
        {
            if (Helper.TrustTest(publicKey, token))
            {
                HoSo_Factory factory = HoSo_Factory.New();
                IEnumerable<HoSo> tmpList = factory.GetList_HoSoNhanVienCoIDChamCong().ToList();

                //
                List<DTO_HoSoNhanVien> list = tmpList.Map<DTO_HoSoNhanVien>().ToList();
                //
                DTO_HoSoNhanVien item = new DTO_HoSoNhanVien();
                item.Oid = Guid.Empty;
                item.HoTen = "Tất cả";
                list.Insert(0,item);
                //
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
