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
    public partial class Mdl_CC_QuanLyChamCong
    {
        /*
    	ko xai
    	public Mdl_CC_QuanLyChamCong()
        {
            this.CC_ChiTietChamCong = new HashSet<Mdl_CC_ChiTietChamCong>();
            this.KyTinhLuongs = new HashSet<Mdl_KyTinhLuong>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongTy { get; set; }
    	[DataMember]
        public Nullable<System.Guid> KyChamCong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayLap { get; set; }
    	[DataMember]
        public Nullable<bool> KhoaChamCong { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongTyCha { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_CC_KyChamCong CC_KyChamCong { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChiTietChamCong> CC_ChiTietChamCong { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_KyTinhLuong> KyTinhLuongs { get; set; }
    	//[DataMember]
        //public virtual Mdl_CongTy CongTy1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_CongTy CongTy2 { get; set; }
    }
}
