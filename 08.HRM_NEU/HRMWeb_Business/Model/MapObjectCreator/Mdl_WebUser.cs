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
    public partial class Mdl_WebUser
    {
        /*
    	ko xai
    	public Mdl_WebUser()
        {
            this.CC_ChamCongNgayNghi = new HashSet<Mdl_CC_ChamCongNgayNghi>();
            this.WebUser_BoPhan = new HashSet<Mdl_WebUser_BoPhan>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinNhanVien { get; set; }
    	[DataMember]
        public string UserName { get; set; }
    	[DataMember]
        public string Password { get; set; }
    	[DataMember]
        public Nullable<bool> HoatDong { get; set; }
    	[DataMember]
        public Nullable<bool> UserChamCong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> WebGroupID { get; set; }
    	[DataMember]
        public string AdminEmail { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<int> AgentObjectTypeId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> DepartmentId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> GiangVienThinhGiang { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongNgayNghi> CC_ChamCongNgayNghi { get; set; }
    	//[DataMember]
        //public virtual Mdl_HoSo HoSo { get; set; }
    	//[DataMember]
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_WebGroup WebGroup { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_WebUser_BoPhan> WebUser_BoPhan { get; set; }
    }
}
