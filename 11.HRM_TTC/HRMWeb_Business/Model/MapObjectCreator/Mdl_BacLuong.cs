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
    public partial class Mdl_BacLuong
    {
        /*
    	ko xai
    	public Mdl_BacLuong()
        {
            this.NhanVienThongTinLuongs = new HashSet<Mdl_NhanVienThongTinLuong>();
            this.NgachLuongs = new HashSet<Mdl_NgachLuong>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NgachLuong { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenBacLuong { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongCoBan { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongKinhDoanh { get; set; }
    	[DataMember]
        public Nullable<bool> BacLuongCu { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongTy { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_CongTy CongTy1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVienThongTinLuong> NhanVienThongTinLuongs { get; set; }
    	//[DataMember]
        //public virtual Mdl_NgachLuong NgachLuong1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NgachLuong> NgachLuongs { get; set; }
    }
}
