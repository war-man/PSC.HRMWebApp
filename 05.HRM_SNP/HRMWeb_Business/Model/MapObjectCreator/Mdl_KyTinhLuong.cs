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
    public partial class Mdl_KyTinhLuong
    {
        /*
    	ko xai
    	public Mdl_KyTinhLuong()
        {
            this.BangLuongNhanViens = new HashSet<Mdl_BangLuongNhanVien>();
            this.CC_QuanLyChamCong = new HashSet<Mdl_CC_QuanLyChamCong>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<int> Thang { get; set; }
    	[DataMember]
        public Nullable<int> Nam { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgay { get; set; }
    	[DataMember]
        public Nullable<bool> KhoaSo { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CommonInfo { get; set; }
    	[DataMember]
        public Nullable<System.Guid> MocTinhThueTNCN { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CompanyInfo { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> QuanLyChamCong { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_BangLuongNhanVien> BangLuongNhanViens { get; set; }
    	//[DataMember]
        //public virtual Mdl_CompanyInfo CompanyInfo1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_QuanLyChamCong> CC_QuanLyChamCong { get; set; }
    	//[DataMember]
        //public virtual Mdl_CC_QuanLyChamCong CC_QuanLyChamCong1 { get; set; }
    }
}
