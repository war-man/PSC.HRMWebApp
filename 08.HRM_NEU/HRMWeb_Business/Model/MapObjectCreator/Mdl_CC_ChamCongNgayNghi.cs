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
    public partial class Mdl_CC_ChamCongNgayNghi
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BangChamCongNgayNghi { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDBoPhan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CC_HinhThucNghi { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDHinhThucNghi { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CacBuoiTrongNgay_TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CacBuoiTrongNgay_DenNgay { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgay { get; set; }
    	[DataMember]
        public Nullable<byte> XepLoaiDanhGia { get; set; }
    	[DataMember]
        public string DienGiai { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDWebUsers { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayTao { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDWebUser { get; set; }
    	[DataMember]
        public Nullable<int> LoaiNghiPhep { get; set; }
    	[DataMember]
        public string NoiNghi { get; set; }
    	[DataMember]
        public string DiaChiLienHe { get; set; }
    	[DataMember]
        public string TenGiayXinPhep { get; set; }
    	[DataMember]
        public Nullable<int> TrangThai { get; set; }
    	[DataMember]
        public Nullable<int> TrangThaiAdmin { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TinhThanh { get; set; }
    	[DataMember]
        public Nullable<bool> TruNgayDiDuong { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgayDiDuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> HinhThucNghi { get; set; }
    	[DataMember]
        public string NuaBuoiTuNgay { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgayPhepConLai { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay1 { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay1 { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan { get; set; }
    	//[DataMember]
        //public virtual Mdl_CacBuoiTrongNgay CacBuoiTrongNgay { get; set; }
    	//[DataMember]
        //public virtual Mdl_CacBuoiTrongNgay CacBuoiTrongNgay1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_HinhThucNghi HinhThucNghi1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_HinhThucNghi HinhThucNghi2 { get; set; }
    	//[DataMember]
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien { get; set; }
    	//[DataMember]
        //public virtual Mdl_TinhThanh TinhThanh1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_WebUser WebUser { get; set; }
    }
}
