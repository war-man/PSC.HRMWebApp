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
    public partial class Mdl_TaiKhoanNganHang
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinTruong { get; set; }
    	[DataMember]
        public string SoTaiKhoan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NganHang { get; set; }
    	[DataMember]
        public Nullable<bool> TaiKhoanChinh { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_NhanVien NhanVien1 { get; set; }
    }
}
