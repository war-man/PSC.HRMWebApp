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
    public partial class DTO_KiemTraPhongBanXetABC
    {
        [DataMember]
        public Guid Oid { get; set; }

        [DataMember]
        public String TenPhongBan { get; set; }

        [DataMember]
        public String ThangNam { get; set; }

        [DataMember]
        public String TrangThai { get; set; }

        [DataMember]
        public String TrangThaiChot { get; set; }
    }
   
}
