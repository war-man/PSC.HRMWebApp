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
    public partial class Mdl_CongTy
    {
        /*
    	ko xai
    	public Mdl_CongTy()
        {
            this.CC_QuanLyChamCong = new HashSet<Mdl_CC_QuanLyChamCong>();
            this.WebUsers = new HashSet<Mdl_WebUser>();
            this.CC_ChamCongTheoNgay = new HashSet<Mdl_CC_ChamCongTheoNgay>();
            this.CC_KyChamCong = new HashSet<Mdl_CC_KyChamCong>();
            this.CC_QuanLyNghiPhep = new HashSet<Mdl_CC_QuanLyNghiPhep>();
            this.CC_QuanLyCongNgoaiGio = new HashSet<Mdl_CC_QuanLyCongNgoaiGio>();
            this.BacLuongs = new HashSet<Mdl_BacLuong>();
            this.NhanViens = new HashSet<Mdl_NhanVien>();
            this.NgachLuongs = new HashSet<Mdl_NgachLuong>();
            this.BoPhans = new HashSet<Mdl_BoPhan>();
            this.KyTinhLuongs = new HashSet<Mdl_KyTinhLuong>();
            this.CC_NgayNghiTrongNam = new HashSet<Mdl_CC_NgayNghiTrongNam>();
            this.CC_HinhThucNghi = new HashSet<Mdl_CC_HinhThucNghi>();
            this.CC_QuanLyPhepHe = new HashSet<Mdl_CC_QuanLyPhepHe>();
            this.NienDoTaiChinhs = new HashSet<Mdl_NienDoTaiChinh>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string TenVietTat { get; set; }
    	[DataMember]
        public string DonViChuQuan { get; set; }
    	[DataMember]
        public Nullable<int> NamThanhLap { get; set; }
    	[DataMember]
        public Nullable<System.Guid> DiaChi { get; set; }
    	[DataMember]
        public string DienThoai { get; set; }
    	[DataMember]
        public string Email { get; set; }
    	[DataMember]
        public string Fax { get; set; }
    	[DataMember]
        public string WebSite { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinChung { get; set; }
    	[DataMember]
        public string MaSoThue { get; set; }
    	[DataMember]
        public Nullable<System.Guid> MocTinhThueTNCN { get; set; }
    	[DataMember]
        public byte[] Logo { get; set; }
    	[DataMember]
        public Nullable<System.Guid> HeDaoTao { get; set; }
    	[DataMember]
        public Nullable<System.Guid> DinhPhi { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiTruong { get; set; }
    	[DataMember]
        public string URLLogo { get; set; }
    	[DataMember]
        public Nullable<bool> SuDungPOS { get; set; }
    	[DataMember]
        public Nullable<System.Guid> MocQuyDoiThuNhapKhongThue { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_QuanLyChamCong> CC_QuanLyChamCong { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_WebUser> WebUsers { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongTheoNgay> CC_ChamCongTheoNgay { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_KyChamCong> CC_KyChamCong { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_QuanLyNghiPhep> CC_QuanLyNghiPhep { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_QuanLyCongNgoaiGio> CC_QuanLyCongNgoaiGio { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_BacLuong> BacLuongs { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVien> NhanViens { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NgachLuong> NgachLuongs { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_BoPhan> BoPhans { get; set; }
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_KyTinhLuong> KyTinhLuongs { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_NgayNghiTrongNam> CC_NgayNghiTrongNam { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_HinhThucNghi> CC_HinhThucNghi { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_QuanLyPhepHe> CC_QuanLyPhepHe { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NienDoTaiChinh> NienDoTaiChinhs { get; set; }
    }
}
