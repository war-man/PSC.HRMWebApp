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
    public partial class Mdl_CC_DangKyChamCongNgoaiGio
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDBoPhan { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> Ngay { get; set; }
    	[DataMember]
        public Nullable<decimal> SoPhutThucTe { get; set; }
    	[DataMember]
        public Nullable<decimal> SoPhutDangKy { get; set; }
    	[DataMember]
        public Nullable<System.Guid> LyDo { get; set; }
    	[DataMember]
        public Nullable<byte> Duyet { get; set; }
    	[DataMember]
        public string TuGio { get; set; }
    	[DataMember]
        public string DenGio { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_CC_LyDoDangKyChamCongNgoaiGio CC_LyDoDangKyChamCongNgoaiGio { get; set; }
    	//[DataMember]
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien { get; set; }
    }
}
