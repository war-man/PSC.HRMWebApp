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
    public partial class DTO_DangKyKhungGioLamViec
    {
        [DataMember]
        public Guid Oid { get; set; }
        [DataMember]
        public Nullable<System.Guid> ThongTinNhanVien { get; set; }
        [DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
        [DataMember]
        public Nullable<System.Guid> CaChamCong { get; set; }
        [DataMember]
        public Nullable<System.Guid> KyDangKy { get; set; }
        [DataMember]
        public string TenCa { get; set; }
        [DataMember]
        public string TenKy { get; set; }
        [DataMember]
        public string TrangThai { get; set; }
        [DataMember]
        public string HoTen { get; set; }
        [DataMember]
        public string TenPhongBan { get; set; }
        [DataMember]
        public string SoHieuCongChuc { get; set; }

        [DataMember]
        public IEnumerable<DTO_CC_CaChamCongApDung> CaChamCongApDung { get; set; }

        [DataMember]
        public string TenCaChamCongApDung { get; set; }


        [DataMember]
        public Nullable<System.Guid> CaChamCongMoi { get; set; }
        [DataMember]
        public string DuLieuDaDangKy { get; set; }
        [DataMember]
        public string DuLieuDaThayDoi { get; set; }
        [DataMember]
        public Nullable<System.DateTime> TuNgayThayDoi { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DenNgayThayDoi { get; set; }
        [DataMember]
        public string TenCaMoi { get; set; }
        [DataMember]
        public bool ChoPhepDoi { get; set; }
        [DataMember]
        public string TrangThaiDoiCa { get; set; }

    }
}
