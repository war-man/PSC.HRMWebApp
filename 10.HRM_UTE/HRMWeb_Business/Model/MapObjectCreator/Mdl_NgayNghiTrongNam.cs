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
    public partial class Mdl_NgayNghiTrongNam
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> QuanLyNgayNghiTrongNam { get; set; }
    	[DataMember]
        public string TenNgayNghi { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayNghi { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayNghiBu { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_QuanLyNgayNghiTrongNam QuanLyNgayNghiTrongNam1 { get; set; }
    }
}
