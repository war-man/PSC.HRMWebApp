

using System.Runtime.Serialization;

namespace HRMWeb_Business.Model
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class DTO_ModuleThongTinNhanSu_ChiTietThuNhapCaNhan
    {
        [DataMember]
        public string TenBoPhan { get; set; }
        [DataMember]
        public string HoTen { get; set; }
        [DataMember]
        public string TenKy { get; set; }
        [DataMember]
        public decimal LuongCoBan { get; set; }
        [DataMember]
        public Nullable<decimal> HeSoLuong { get; set; }
        [DataMember]
        public Nullable<decimal> PhanTramHuongLuong { get; set; }
        [DataMember]
        public Nullable<decimal> HSPCKhuVuc { get; set; }
        [DataMember]
        public Nullable<decimal> MucHuongPhuCapLamDem { get; set; }
        [DataMember]
        public Nullable<decimal> HeSoBaoHiem { get; set; }
        [DataMember]
        public Nullable<decimal> HeSoChenhLechBaoLuu { get; set; }
        [DataMember]
        public Nullable<decimal> HSPCChucVu { get; set; }
        [DataMember]
        public Nullable<decimal> HeSoTo { get; set; }
        [DataMember]
        public Nullable<decimal> HSPCDocHai { get; set; }
        [DataMember]
        public Nullable<decimal> HSPCVuotKhung { get; set; }
        [DataMember]
        public Nullable<decimal> HSPCThamNien { get; set; }
        [DataMember]
        public decimal LuongTamUng { get; set; }
        [DataMember]
        public decimal LuongChinh { get; set; }
        [DataMember]
        public decimal PhuCapChucVu { get; set; }
        [DataMember]
        public decimal PhuCapThamNienVuotKhung { get; set; }
        [DataMember]
        public decimal PhuCapCLBaoLuu { get; set; }
        [DataMember]
        public decimal LuongThamNien { get; set; }
        [DataMember]
        public decimal BHXH { get; set; }
        [DataMember]
        public decimal BHYT { get; set; }
        [DataMember]
        public decimal BHTN { get; set; }
        [DataMember]
        public decimal LuongSanPham { get; set; }
        [DataMember]
        public decimal LuongNangSuat { get; set; }
        [DataMember]
        public decimal LuongCangTra { get; set; }
        [DataMember]
        public decimal LuongSuaChua { get; set; }
        [DataMember]
        public decimal LuongDieuTiet { get; set; }
        [DataMember]
        public decimal LuongLamLe { get; set; }
        [DataMember]
        public decimal LuongNghiLe { get; set; }
        [DataMember]
        public decimal LuongThoiGian { get; set; }
        [DataMember]
        public decimal PhuCapTienAn { get; set; }
        [DataMember]
        public decimal PhuCapLamDem { get; set; }
        [DataMember]
        public decimal PhuCapDocHai { get; set; }
        [DataMember]
        public Nullable<decimal> TongThuNhapLuongKy1 { get; set; }
        [DataMember]
        public Nullable<decimal> TongThuNhapLuongKy2 { get; set; }
        [DataMember]
        public Nullable<decimal> TongKhauTru { get; set; }
        [DataMember]
        public Nullable<decimal> ThucLanh { get; set; }
    }
}
