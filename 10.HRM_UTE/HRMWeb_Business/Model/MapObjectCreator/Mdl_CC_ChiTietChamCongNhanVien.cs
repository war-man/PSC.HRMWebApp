//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMWeb_Business.Model.MapObjectCreator
{
    using System;
    using System.Collections.Generic;
    
    using System.Runtime.Serialization;//[DataContract],[DataMember]
    [DataContract]
    public partial class Mdl_CC_ChiTietChamCongNhanVien
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CC_QuanLyChamCongNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinNhanVien { get; set; }
    	[DataMember]
        public Nullable<decimal> NghiCoPhep { get; set; }
    	[DataMember]
        public Nullable<decimal> NghiRo { get; set; }
    	[DataMember]
        public Nullable<decimal> NghiThaiSan { get; set; }
    	[DataMember]
        public string DanhGia { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgayCong { get; set; }
    	[DataMember]
        public string DienGiai { get; set; }
    	[DataMember]
        public string BoPhanTheoBangCong { get; set; }
    	[DataMember]
        public Nullable<decimal> NghiOm { get; set; }
    	[DataMember]
        public Nullable<decimal> NghiDiHocKhongLuong { get; set; }
    	[DataMember]
        public Nullable<decimal> NghiDiHocCoLuong { get; set; }
    	[DataMember]
        public Nullable<bool> TrangThai { get; set; }
    	[DataMember]
        public Nullable<bool> Khoa { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiCanBo { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_CC_QuanLyChamCongNhanVien CC_QuanLyChamCongNhanVien1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien1 { get; set; }
    }
}
