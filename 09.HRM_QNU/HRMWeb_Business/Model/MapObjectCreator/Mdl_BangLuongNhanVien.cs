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
    public partial class Mdl_BangLuongNhanVien
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> KyTinhLuong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayLap { get; set; }
    	[DataMember]
        public Nullable<bool> HienLenWeb { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinTruong { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiLuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChungTu { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_KyTinhLuong KyTinhLuong1 { get; set; }
    }
}
