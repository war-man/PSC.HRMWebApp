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
        public Nullable<int> NghiNuaNgay { get; set; }
        [DataMember]
        public Nullable<int> NghiCoPhep { get; set; }
        [DataMember]
        public Nullable<int> NghiRo { get; set; }
        [DataMember]
        public Nullable<int> NghiThaiSan { get; set; }
        [DataMember]
        public Nullable<int> NghiHe { get; set; }
        [DataMember]
        public string DanhGia { get; set; }
        //[DataMember]
        //public Nullable<int> OptimisticLockField { get; set; }
        //[DataMember]
        //public Nullable<int> GCRecord { get; set; }
        [DataMember]
        public string BoPhanTheoBangCong { get; set; }
        [DataMember]
        public Nullable<decimal> SoNgayCong { get; set; }
        [DataMember]
        public string DienGiai { get; set; }
        [DataMember]
        public Nullable<bool> TrangThai { get; set; }
        [DataMember]
        public Nullable<bool> Khoa { get; set; }
        [DataMember]
        public string DanhGiaTruocDieuChinh { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongChuan { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongThucTe { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongCangTra { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongNghi { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongSuaChua { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongLamLe { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongNghiLe { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongAnCa { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongDocHai { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayCongLamDem { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayNghiPhep { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayNghiKhongPhep { get; set; }
        [DataMember]
        public Nullable<Decimal> NgayNghiThaiSan { get; set; }
        [DataMember]
        public string XepLoaiCanBo { get; set; }
        [DataMember]
        public Nullable<Decimal> HeSoXepLoai { get; set; }
        [DataMember]
        public Nullable<Decimal> HeSoNgayCong { get; set; }
        //public virtual Mdl_BoPhan BoPhan1 { get; set; }
        //public virtual Mdl_QuanLyChamCongNhanVien QuanLyChamCongNhanVien1 { get; set; }
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien1 { get; set; }
    }
}
