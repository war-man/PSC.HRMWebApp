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
    public partial class Mdl_NienDoTaiChinh
    {
        /*
    	ko xai
    	public Mdl_NienDoTaiChinh()
        {
            this.CC_QuanLyPhepHe = new HashSet<Mdl_CC_QuanLyPhepHe>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongTy { get; set; }
    	[DataMember]
        public string TenNienDo { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    	[DataMember]
        public Nullable<decimal> SoThang { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> BatDauHe { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> KetThucHe { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgayNghiHe { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_QuanLyPhepHe> CC_QuanLyPhepHe { get; set; }
    	//[DataMember]
        //public virtual Mdl_CongTy CongTy1 { get; set; }
    }
}
