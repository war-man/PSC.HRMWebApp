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
    public partial class DTO_ChiTietChamCongNhanVien
    {
        // them vao
        [DataMember]
        public string HoVaTen { get; set; }
        // them vao
        [DataMember]
        public string MaNhanSu { get; set; }
        [DataMember]
        public string TenPhongBan { get; set; }
        [DataMember]
        public string SoHieuCongChuc { get; set; }
        // them vao
        [DataMember]
        public string NgayNghiFormat { get; set; }

        [DataMember]
        public System.Guid Oid { get; set; }
        [DataMember]
        public Nullable<System.Guid> QuanLyChamCongNhanVien { get; set; }
        [DataMember]
        public Nullable<System.Guid> BoPhan { get; set; }
        [DataMember]
        public Nullable<System.Guid> ThongTinNhanVien { get; set; }
        [DataMember]
        public string NghiRo { get; set; }
        [DataMember]
        public string NghiThaiSan { get; set; }
        [DataMember]
        public string NghiCoPhep { get; set; }
        [DataMember]
        public string NghiDiHocCoLuong { get; set; }
        [DataMember]
        public string NghiDiHocKhongLuong { get; set; }
        [DataMember]
        public string NghiOm { get; set; }
        [DataMember]
        public string DanhGia { get; set; }
        [DataMember]
        public string BoPhanTheoBangCong { get; set; }
        [DataMember]
        public string SoNgayCong { get; set; }
        [DataMember]
        public string DienGiai { get; set; }
        [DataMember]
        public Nullable<bool> TrangThai { get; set; }
        [DataMember]
        public Nullable<bool> Khoa { get; set; }
        [DataMember]
        public string DanhGiaTruocDieuChinh { get; set; }
    
    }
}
