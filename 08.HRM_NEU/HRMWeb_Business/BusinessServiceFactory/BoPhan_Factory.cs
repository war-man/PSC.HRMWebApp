﻿using System;
using System.Collections.Generic;
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
using System.Web.Configuration;

namespace HRMWeb_Business.BusinessServiceFactory
{
    public class BoPhan_Factory : BaseFactory<Entities, BoPhan>
    {
        //static readonly Log4netCustom.ILog TracingLog_ = Log4netCustom.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static ERP_Core.BaseEntityObject CreateStandAloneObject()
        {
            return BoPhan_Factory.New().CreateAloneObject();
        }
        public static BoPhan_Factory New()
        {
            return new BoPhan_Factory();
        }
        public BoPhan_Factory()
            : base(Database.NewEntities())
        {

        }

        #region Custom

        public IQueryable<BoPhan> GetAll_GCRecordIsNull()
        {//su dung cho cham cong only
            Guid bpc = new Guid(WebConfigurationManager.AppSettings["BoPhanCha"]);
            var result = from o in this.ObjectSet
                         where o.GCRecord == null
                         && (o.NgungHoatDong == null || o.NgungHoatDong == false)
                         && (o.BoPhanCha == bpc || o.BoPhan2.BoPhanCha == bpc)
                         orderby o.STT ascending, o.TenBoPhan ascending
                         select o;
            return result;
        }
        public BoPhan GetByID(Guid oid)
        {
            var result = (from o in this.ObjectSet
                          where o.Oid == oid
                          select o).SingleOrDefault();
            return result;
        }
        public IQueryable<BoPhan> GetDanhSachBoPhan_DuocPhanQuyenChoWebUserId_GCRecordIsNull(Guid webUserId)
        {//su dung cho cham cong only
            var isAdmin = (from o in this.Context.WebUsers
                          where o.Oid == webUserId
                          select o.WebGroupID).SingleOrDefault() == new Guid("05A1BF24-BD1C-455F-96F6-7C4237F4659E");
            Guid bpc = new Guid(WebConfigurationManager.AppSettings["BoPhanCha"]);
            var result = (from o in this.Context.BoPhans
                          where (isAdmin || o.WebUser_BoPhan.Any(x => x.IDWebUser == webUserId))
                          //trường SPKT
                          && (o.BoPhanCha == bpc || o.BoPhan2.BoPhanCha == bpc)
                          && o.GCRecord == null
                          orderby o.STT ascending, o.TenBoPhan ascending
                          select o);
            return result;
        }
        //public IQueryable<BoPhan> GetDanhSachBoPhan_DuocPhanQuyenChoWebUserId_GCRecordIsNull(Guid webUserId)
        //{//su dung cho cham cong only
        //    var result = (from o in this.Context.BoPhans
        //                  where o.WebUser_BoPhan.Any(x => x.IDWebUser == webUserId)
        //                  && o.BoPhanCha != null
        //                  && o.GCRecord == null
        //                  orderby o.STT ascending, o.TenBoPhan ascending
        //                  select o);
        //    return result;
        //}

        public IEnumerable<DTO_KiemTraPhongBanXetABC> KiemTraPhongBanXetABC_Find(int thang, int nam, Boolean? daXetXongABC)
        {
            string thangNam = thang.ToString() + " - " + nam.ToString();
            Boolean tatCaTrangThaiXetABC = daXetXongABC == null ? true : false;


            IEnumerable<DTO_KiemTraPhongBanXetABC> query = null;
            Guid bpc = new Guid(WebConfigurationManager.AppSettings["BoPhanCha"]);
            query = (from o in this.Context.BoPhans
                     let tonTaiTrangThaiChuaXet = o.ChiTietChamCongNhanViens.Any(x => (x.TrangThai ?? false) == false
                                                                && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Month == thang
                                                                && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam
                                                                )
                     where (tatCaTrangThaiXetABC || !daXetXongABC == tonTaiTrangThaiChuaXet)                                                 
                           && o.BoPhanCha== bpc
                           && o.GCRecord==null

                     select new DTO_KiemTraPhongBanXetABC() { TenPhongBan = o.TenBoPhan, ThangNam = thangNam, TrangThai = (tonTaiTrangThaiChuaXet == true ? "Chưa xét" : "Đã xét") }).ToList();

            //if (daXetXongABC == false)
            //    query = (from o in this.Context.BoPhans
            //             where o.ChiTietChamCongNhanViens.Any(x => (x.TrangThai ?? false) == false && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Month == thang
            //                                                    && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam)
            //             select new DTO_KiemTraPhongBanXetABC() { TenPhongBan = o.TenBoPhan, ThangNam = thangNam }).ToList();
            //else
            //{
            //    query = (from o in this.Context.BoPhans
            //             where !o.ChiTietChamCongNhanViens.Any(x => (x.TrangThai ?? false) == false && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Month == thang
            //                                                    && x.QuanLyChamCongNhanVien1.KyTinhLuong1.TuNgay.Value.Year == nam)
            //             select new DTO_KiemTraPhongBanXetABC() { TenPhongBan = o.TenBoPhan, ThangNam = thangNam }).ToList();
            //}
            return query;
        }

        //public AppL Get_ByCPUID(String cpuid)
        //{
        //    var result = (from o in this.ObjectSet
        //                  where o.CPUID == cpuid
        //                  select o).SingleOrDefault();
        //    return result;
        //}
        //public void AddOrUpdate(String cpuid, String lKey, String description)
        //{
        //    AppL oldObj = this.Get_ByCPUID(cpuid);
        //    if (oldObj == null)
        //    {
        //        AppL obj = this.CreateManagedObject();
        //        obj.CPUID = cpuid;
        //        obj.LKey = lKey;
        //        obj.Description = description;
        //    }
        //    else
        //    {
        //        oldObj.LKey = lKey;
        //        oldObj.Description = description;
        //    }

        //}
        //public static void FullDelete(Entities context, params Object[] deleteList)
        //{
        //    //foreach (AppL item in deleteList)
        //    //{
        //    //    context.DeleteObject(item);
        //    //}
        //}
        #endregion
    }//end class
}
