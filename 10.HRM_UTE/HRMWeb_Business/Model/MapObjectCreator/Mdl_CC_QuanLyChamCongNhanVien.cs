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
    public partial class Mdl_CC_QuanLyChamCongNhanVien
    {
        /*
    	ko xai
    	public Mdl_CC_QuanLyChamCongNhanVien()
        {
            this.CC_ChiTietChamCongNhanVien = new HashSet<Mdl_CC_ChiTietChamCongNhanVien>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinTruong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> KyTinhLuong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayLap { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CreatedUser { get; set; }
    	[DataMember]
        public Nullable<System.Guid> KyChamCong { get; set; }
    	[DataMember]
        public Nullable<bool> KhoaChamCong { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_KyTinhLuong KyTinhLuong1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChiTietChamCongNhanVien> CC_ChiTietChamCongNhanVien { get; set; }
    }
}
