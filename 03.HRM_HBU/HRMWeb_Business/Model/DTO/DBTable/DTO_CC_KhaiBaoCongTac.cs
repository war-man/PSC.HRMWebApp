//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace HRMWeb_Business.Model
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class DTO_CC_KhaiBaoCongTac
    {
        [DataMember]
        public System.Guid Oid { get; set; }
        [DataMember]
        public System.Guid IDNhanVien { get; set; }
        [DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
        [DataMember]
        public string NoiDung { get; set; }
        [DataMember]
        public string Buoi { get; set; }
        [DataMember]
        public Nullable<System.DateTime> NgayTao { get; set; }
        [DataMember]
        public System.Guid IDWebUser { get; set; }
        [DataMember]
        public Nullable<int> TrangThai { get; set; }
    
    }
}
