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
    public class HoSo_Factory : BaseFactory<Entities, HoSo>
    {
        //static readonly Log4netCustom.ILog TracingLog_ = Log4netCustom.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static ERP_Core.BaseEntityObject CreateStandAloneObject()
        {
            return HoSo_Factory.New().CreateAloneObject();
        }
        public static HoSo_Factory New()
        {
            return new HoSo_Factory();
        }
        public HoSo_Factory()
            : base(Database.NewEntities())
        {

        }

        #region Custom
        public IQueryable<HoSo> GetAll_GCRecordIsNull()
        {//su dung cho cham cong only
            var result = from o in this.ObjectSet
                         where o.GCRecord == null
                         orderby o.HoTen ascending
                         select o;
            return result;
        }
        public IQueryable<HoSo> GetAll_HoSo()
        {//su dung cho cham cong only
            var result = from o in this.ObjectSet
                         where o.GCRecord == null && o.NhanVien.TinhTrang1.DaNghiViec==false
                         select o;
            return result;
        }
        public IQueryable<CC_XepLoaiDanhGia> GetAll_XepLoai()
        {//su dung cho cham cong only
            var result = from o in this.Context.CC_XepLoaiDanhGia
                         where o.GCRecord == null
                         select o;
            return result;
        }
        public CC_XepLoaiDanhGia GetIdXepLoaiByName(string name)
        {//su dung cho cham cong only
            var result = (from o in this.Context.CC_XepLoaiDanhGia
                         where o.GCRecord == null && o.TenXepLoai==name
                         select o).FirstOrDefault();
            return result;
        }

        public IQueryable<HoSo> GetAll_KhongPhaiGiangVien_GCRecordIsNull()
        {//su dung cho cham cong only
            //Guid giangVienId = Guid.Parse("D8A7B32D-CCE6-4DA9-9F6D-6D28F5046D03");
            LoaiNhanSu_Factory loaiNhanSuFactory = LoaiNhanSu_Factory.New();
            loaiNhanSuFactory.Context = this.Context;
            IQueryable<LoaiNhanSu> loaiKhongPhaiGiangVienList = loaiNhanSuFactory.GetListByNotLikeName_GCRecordIsNull("giảng viên");
            var result = from o in this.ObjectSet
                         where o.GCRecord == null
                         && loaiKhongPhaiGiangVienList.Any(x => x.Oid == o.NhanVien.ThongTinNhanVien.LoaiNhanSu)
                         //&& o.NhanVien.ThongTinNhanVien.LoaiNhanSu != Guid.Parse("D8A7B32D-CCE6-4DA9-9F6D-6D28F5046D03")
                         //&& o.NhanVien.ThongTinNhanVien.LoaiNhanSu1.TenLoaiNhanSu.ToLower().Contains("giảng viên")==false
                         orderby o.HoTen ascending
                         select o;
            return result;
        }

        public IQueryable<HoSo> GetListByMaBoPhan_GCRecordIsNull(Guid? maBoPhan)
        {//su dung cho cham cong only
            bool tatCaBoPhan = (maBoPhan == null ? true : false);
            var result = from o in this.ObjectSet
                         where o.GCRecord == null
                            && (tatCaBoPhan || o.NhanVien.Department == maBoPhan)
                            && o.NhanVien.TinhTrang1.DaNghiViec == false
                         orderby o.HoTen ascending
                         select o;
            return result;
        }
        public HoSo GetByID(Guid oid)
        {
            var result = (from o in this.ObjectSet
                          where o.Oid == oid
                          select o).SingleOrDefault();
            return result;
        }
        public HoSo GetByManageCode(string maQuanly)
        {
            var result = (from o in this.ObjectSet
                          where o.MaQuanLy== maQuanly
                          select o).SingleOrDefault();
            return result;
        }
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
