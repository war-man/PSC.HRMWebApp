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
    public partial class Mdl_ChiTietNghiPhep
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinNghiPhep { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    	[DataMember]
        public Nullable<int> TongSoNgayNghiPhep { get; set; }
    	[DataMember]
        public Nullable<int> SoNgayQuaHan { get; set; }
    	[DataMember]
        public Nullable<bool> Khoa { get; set; }
    	[DataMember]
        public string GhiChu { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_ThongTinNghiPhep ThongTinNghiPhep1 { get; set; }
    }
}