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
    public partial class DTO_ChamCongNgoaiGioTheoNgay
    {
        //Them vao
        [DataMember]
        public System.Guid Oid { get; set; }
        [DataMember]
        public decimal? SoCongNgoaiGio { get; set; }
        [DataMember]
        public decimal? SoCongNgoaiGioSau23Gio { get; set; }
        [DataMember]
        public decimal? SoCongNgoaiGioT7CN { get; set; }
        [DataMember]
        public decimal? SoCongNgoaiGioT7CNSau23Gio { get; set; }
        [DataMember]
        public decimal? SoCongNgoaiGioLe { get; set; }
        [DataMember]
        public decimal? SoCongNgoaiGioLeSau23Gio { get; set; }
        [DataMember]
        public DateTime? Ngay { get; set; }
        [DataMember]
        public string TenBoPhan { get; set; }
        [DataMember]
        public string TenNhanVien { get; set; }
        [DataMember]
        public string TuGio { get; set; }
        [DataMember]
        public string GioTuGio { get; set; }
        [DataMember]
        public string PhutTuGio { get; set; }
        [DataMember]
        public string DenGio { get; set; }
        [DataMember]
        public string GioDenGio { get; set; }
        [DataMember]
        public string PhutDenGio { get; set; }
    }
}
