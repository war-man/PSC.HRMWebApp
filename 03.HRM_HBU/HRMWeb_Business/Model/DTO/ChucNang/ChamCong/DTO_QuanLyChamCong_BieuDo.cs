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
    public partial class DTO_QuanLyChamCong_BieuDoVaoRa
    {
        //Them vao
        [DataMember]
        public String MaNhanSu { get; set; }
        [DataMember]
        public String HoTen { get; set; }

        [DataMember]
        public System.Guid IDNhanVien { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Ngay { get; set; }
        [DataMember]
        public Nullable<System.DateTime> GioVao { get; set; }
        [DataMember]
        public Nullable<System.DateTime> GioRa { get; set; }
    }
}
