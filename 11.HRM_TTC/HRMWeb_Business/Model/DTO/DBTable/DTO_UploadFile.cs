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
    public partial class DTO_UploadFile
    {
        [DataMember]
        public System.Guid Oid { get; set; }

        [DataMember]
        public decimal STT { get; set; }

        [DataMember]
        public string TenLoaiGiayTo { get; set; }

        [DataMember]
        public string TenGiayTo { get; set; }

        [DataMember]
        public Nullable<System.DateTime> NgayLap { get; set; }

        [DataMember]
        public string DuongDanFileWeb { get; set; }
    }
}
