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
    public partial class Mdl_NhanVienThongTinLuong
    {
        /*
    	ko xai
    	public Mdl_NhanVienThongTinLuong()
        {
            this.NhanViens = new HashSet<Mdl_NhanVien>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<byte> PhanLoaiLuong { get; set; }
    	[DataMember]
        public Nullable<bool> TinhLuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NgachLuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BacLuong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayBoNhiemNgach { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayHuongLuong { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongKhoan { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongCoBan { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongKinhDoanh { get; set; }
    	[DataMember]
        public Nullable<decimal> HieuQuaCongViec { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> MocNangLuongDieuChinh { get; set; }
    	[DataMember]
        public string LyDoDieuChinh { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> MocNangLuongLanSau { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVu { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayHuongHSPCChucVu { get; set; }
    	[DataMember]
        public Nullable<int> VuotKhung { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCVuotKhung { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayHuongVuotKhung { get; set; }
    	[DataMember]
        public Nullable<decimal> ThamNien { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCThamNien { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayHuongThamNien { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVuDang { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVuDoan { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapKiemNhiem { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTrachNhiem { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCKhac { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongBHXH { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongBHYT { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongBHTN { get; set; }
    	[DataMember]
        public Nullable<bool> KhongDongCongDoan { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapDienThoai { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTienAn { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapTienXang { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapBanTru { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapNhaO { get; set; }
    	[DataMember]
        public Nullable<int> SoNguoiPhuThuoc { get; set; }
    	[DataMember]
        public Nullable<int> SoThangGiamTru { get; set; }
    	[DataMember]
        public string MaSoThue { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayCapMST { get; set; }
    	[DataMember]
        public Nullable<decimal> PhanTramTinhLuong { get; set; }
    	[DataMember]
        public Nullable<bool> TinhThueMacDinh { get; set; }
    	[DataMember]
        public Nullable<decimal> PhanTramTinhThue { get; set; }
    	[DataMember]
        public Nullable<bool> TinhCongChuanMacDinh { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongTheoDonGia { get; set; }
    	[DataMember]
        public Nullable<decimal> LuongGop { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoLuong { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapNgoaiNgu { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapBangCap { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BacLuong BacLuong1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_NgachLuong NgachLuong1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVien> NhanViens { get; set; }
    }
}
