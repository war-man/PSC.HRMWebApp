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
    public partial class Mdl_NhanVien
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucDanh { get; set; }
    	[DataMember]
        public byte[] HinhAnh { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThanhPhanXuatThan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> UuTienGiaDinh { get; set; }
    	[DataMember]
        public Nullable<System.Guid> UuTienBanThan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongViecHienNay { get; set; }
    	[DataMember]
        public Nullable<System.Guid> HopDongHienTai { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoNganhGiaoDuc { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayTuyenDung { get; set; }
    	[DataMember]
        public string DonViTuyenDung { get; set; }
    	[DataMember]
        public string CongViecTuyenDung { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongViecDuocGiao { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoCoQuan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NhanVienThongTinLuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NhanVienTrinhDo { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TinhTrang { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinTruong { get; set; }
    	[DataMember]
        public Nullable<bool> BangCapDaKiemDuyet { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhanTinhLuong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayNghiViec { get; set; }
    	[DataMember]
        public Nullable<bool> LaDangVien { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoNganhNganHang { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhanCu { get; set; }
    	[DataMember]
        public Nullable<decimal> SoThangKhongTinhPhep { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan2 { get; set; }
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan3 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucDanh ChucDanh1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_HoSo HoSo { get; set; }
    	//[DataMember]
        //public virtual Mdl_NhanVienTrinhDo NhanVienTrinhDo1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_TinhTrang TinhTrang1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien { get; set; }
    }
}
