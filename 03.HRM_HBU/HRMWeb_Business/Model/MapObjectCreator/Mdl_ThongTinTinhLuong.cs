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
    public partial class Mdl_ThongTinTinhLuong
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BangChotThongTinTinhLuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TinhTrang { get; set; }
    	[DataMember]
        public Nullable<bool> BangCapDaKiemDuyet { get; set; }
    	[DataMember]
        public Nullable<byte> TrangThaiThamGiaBaoHiem { get; set; }
    	[DataMember]
        public Nullable<bool> KhongThamGiaCongDoan { get; set; }
    	[DataMember]
        public Nullable<byte> PhanLoai { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiLuongChinh { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NgachLuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BacLuong { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoLuong { get; set; }
    	[DataMember]
        public Nullable<bool> Huong85PhanTramLuong { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongKhoan { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVu { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCDocHai { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCTrachNhiem { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCKhuVuc { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCKiemNhiem { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCLuuDong { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCUuDai { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCKhac { get; set; }
    	[DataMember]
        public Nullable<int> PhuCapUuDai { get; set; }
    	[DataMember]
        public Nullable<int> PhuCapDacThu { get; set; }
    	[DataMember]
        public Nullable<int> PhuCapDacBiet { get; set; }
    	[DataMember]
        public Nullable<decimal> ChenhLechBaoLuuLuong { get; set; }
    	[DataMember]
        public Nullable<int> VuotKhung { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCVuotKhung { get; set; }
    	[DataMember]
        public Nullable<decimal> ThamNien { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCThamNien { get; set; }
    	[DataMember]
        public Nullable<bool> TinhLuong { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongBaoHiem { get; set; }
    	[DataMember]
        public Nullable<decimal> PhanTramThamNienHC { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCThamNienHC { get; set; }
    	[DataMember]
        public Nullable<decimal> PhanTramTietChuan { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCKhoiHanhChinh { get; set; }
    	[DataMember]
        public Nullable<int> PhuCapThuHut { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVu1 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVu2 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVu3 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCTrachNhiem1 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCTrachNhiem2 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCTrachNhiem3 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCTrachNhiem4 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCTrachNhiem5 { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVuDang { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVuDoan { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVuCongDoan { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapDienThoai { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCThiDua { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChuyenMon { get; set; }
    	[DataMember]
        public Nullable<decimal> MThamSoPCTrachNhiem { get; set; }
    	[DataMember]
        public Nullable<decimal> MThamSoLuongKy2 { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTienAn { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTienXang { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTangThem { get; set; }
    	[DataMember]
        public Nullable<decimal> HSLTangThem { get; set; }
    	[DataMember]
        public Nullable<int> TiLeTangThem { get; set; }
    	[DataMember]
        public Nullable<decimal> ThamNienCongTac { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTrachNhiemCongViec { get; set; }
    	[DataMember]
        public Nullable<bool> KhongCuTru { get; set; }
    	[DataMember]
        public Nullable<bool> TamGiuLuong { get; set; }
    	[DataMember]
        public Nullable<int> SoNguoiPhuThuoc { get; set; }
    	[DataMember]
        public Nullable<int> SoNgayTinhTNTT { get; set; }
    	[DataMember]
        public Nullable<int> SoThangGiamTru { get; set; }
    	[DataMember]
        public string SoTaiKhoan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NganHang { get; set; }
    	[DataMember]
        public string GhiChu { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucDanh { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVu { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuKiemNhiem { get; set; }
    	[DataMember]
        public string ThangNamTNCongTac { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuDang { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuDoan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuDoanThe { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongViecHienNay { get; set; }
    	[DataMember]
        public Nullable<System.Guid> LoaiNhanSu { get; set; }
    	[DataMember]
        public Nullable<int> STT { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhanTinhLuong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoCoQuan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoMon { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongTai { get; set; }
    	[DataMember]
        public Nullable<decimal> MucLuong { get; set; }
    	[DataMember]
        public Nullable<int> PhuongThucTinhThue { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongDongBaoHiem { get; set; }
    	[DataMember]
        public Nullable<decimal> ThuongHieuQuaTheoThangTruocDieuChinh { get; set; }
    	[DataMember]
        public Nullable<decimal> ThuongHieuQuaTheoThangSauDieuChinh { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayDieuChinhMucThuNhap { get; set; }
    	[DataMember]
        public Nullable<bool> TinhThueTNCNMacDinh { get; set; }
    	[DataMember]
        public Nullable<decimal> ThuongHieuQuaTheoThang { get; set; }
    	[DataMember]
        public Nullable<decimal> SoThangKhongTinhThamNien { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCCongViec { get; set; }
    	[DataMember]
        public Nullable<int> PhuCapCongViec { get; set; }
    	[DataMember]
        public Nullable<int> PhuCapKhac { get; set; }
    	[DataMember]
        public Nullable<decimal> MucLuongTruocDieuChinh { get; set; }
    	[DataMember]
        public Nullable<decimal> MucLuongSauDieuChinh { get; set; }
    	[DataMember]
        public Nullable<System.Guid> LoaiNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayHuongThamNien { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapLaiXe { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVuBaoLuu { get; set; }
    	[DataMember]
        public Nullable<int> PhuCapKiemNhiem { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongKhoanNuocNgoai { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTienDien { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTienNuoc { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapBanAnNinh { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapBanTuVe { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoH1 { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoH2 { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoH3 { get; set; }
    	[DataMember]
        public Nullable<decimal> TiLeTNTTTheoMucPCUD { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNamLamChuyenVien { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNamCongTac { get; set; }
    	[DataMember]
        public Nullable<decimal> MucHuongTNTT { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongBHXH { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongBHYT { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongBHTN { get; set; }
    	[DataMember]
        public Nullable<decimal> SoKyDien { get; set; }
    	[DataMember]
        public Nullable<decimal> SoKyNuoc { get; set; }
    	[DataMember]
        public Nullable<decimal> HSLTangThemTheoThamNien { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgayLamViec { get; set; }
    	[DataMember]
        public Nullable<bool> LuongNET { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVuBaoHiem { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TrinhDoChuyenMon { get; set; }
    	[DataMember]
        public Nullable<System.Guid> HocHam { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoTCDLD { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoTNTT { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCThamNienBaoHiem { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTPBHLD { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoBangCap { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoThamNienTNTT { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTrachNhiemCongViecTruocDieuChinh { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapDienThoaiTruocDieuChinh { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTienXangTruocDieuChinh { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayDieuChinhMucPhuCap { get; set; }
    	[DataMember]
        public Nullable<bool> KhongTinhSinhNhat { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCTrachNhiem6 { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BangChotThongTinTinhLuong BangChotThongTinTinhLuong1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucVu ChucVu1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucVu ChucVu2 { get; set; }
    	//[DataMember]
        //public virtual Mdl_LoaiNhanSu LoaiNhanSu1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_TinhTrang TinhTrang1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucDanh ChucDanh1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan2 { get; set; }
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan3 { get; set; }
    	//[DataMember]
        //public virtual Mdl_TrinhDoChuyenMon TrinhDoChuyenMon1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_HocHam HocHam1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_NganHang NganHang1 { get; set; }
    }
}