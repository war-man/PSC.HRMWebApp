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
    public partial class Mdl_ThongTinNhanVien
    {
        /*
    	ko xai
    	public Mdl_ThongTinNhanVien()
        {
            this.CC_KhaiBaoChamCongGiangVien = new HashSet<Mdl_CC_KhaiBaoChamCongGiangVien>();
            this.CC_DangKyChamCongNgoaiGio = new HashSet<Mdl_CC_DangKyChamCongNgoaiGio>();
            this.ChiTietChamCongNhanViens = new HashSet<Mdl_ChiTietChamCongNhanVien>();
            this.CC_DangKyKhungGioLamViec = new HashSet<Mdl_CC_DangKyKhungGioLamViec>();
            this.WebUsers = new HashSet<Mdl_WebUser>();
            this.CC_ChamCongNgayNghi = new HashSet<Mdl_CC_ChamCongNgayNghi>();
            this.ThongTinNghiPheps = new HashSet<Mdl_ThongTinNghiPhep>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<bool> KhoaHoSo { get; set; }
    	[DataMember]
        public Nullable<bool> BienChe { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayNghiHuu { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVu { get; set; }
    	[DataMember]
        public Nullable<int> LanBoNhiemChucVu { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuKiemNhiem { get; set; }
    	[DataMember]
        public Nullable<System.Guid> LoaiNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> LoaiNhanSu { get; set; }
    	[DataMember]
        public Nullable<bool> ThamGiaGiangDay { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TaiBoMon { get; set; }
    	[DataMember]
        public string SoHieuCongChuc { get; set; }
    	[DataMember]
        public string SoHoSo { get; set; }
    	[DataMember]
        public string DienThoaiCoQuan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuCoQuanCaoNhat { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayBoNhiem { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoBienChe { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayTinhThamNienNhaGiao { get; set; }
    	[DataMember]
        public string Password { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NhomMau { get; set; }
    	[DataMember]
        public Nullable<int> ChieuCao { get; set; }
    	[DataMember]
        public Nullable<int> CanNang { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TinhTrangSucKhoe { get; set; }
    	[DataMember]
        public Nullable<bool> HopDongLaoDong { get; set; }
    	[DataMember]
        public Nullable<bool> HopDongKhoan { get; set; }
    	[DataMember]
        public Nullable<bool> LamTheoCa { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiLuongChinh { get; set; }
    	[DataMember]
        public Nullable<bool> ChamCong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayBoNhiemKiemNhiem { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuDang { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayBoNhiemDang { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoDangChinhThuc { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoDangDuBi { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NhomGiangVien { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan { get; set; }
    	//[DataMember]
        //public virtual Mdl_LoaiNhanSu LoaiNhanSu1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_KhaiBaoChamCongGiangVien> CC_KhaiBaoChamCongGiangVien { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_DangKyChamCongNgoaiGio> CC_DangKyChamCongNgoaiGio { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ChiTietChamCongNhanVien> ChiTietChamCongNhanViens { get; set; }
    	//[DataMember]
        //public virtual Mdl_NhanVien NhanVien { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_DangKyKhungGioLamViec> CC_DangKyKhungGioLamViec { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_WebUser> WebUsers { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucVu ChucVu1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucVu ChucVu2 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucVu ChucVu3 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongNgayNghi> CC_ChamCongNgayNghi { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNghiPhep> ThongTinNghiPheps { get; set; }
    }
}
