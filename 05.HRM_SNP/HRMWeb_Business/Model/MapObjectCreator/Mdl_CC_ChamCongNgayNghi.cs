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
        public Nullable<System.Guid> TinhThanh { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    	[DataMember]
        public Nullable<int> SoNgay { get; set; }
    	[DataMember]
        public Nullable<byte> XepLoaiDanhGia { get; set; }
    	[DataMember]
        public string DienGiai { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDBoPhan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDHinhThucNghi { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayTao { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDWebUser { get; set; }
    	[DataMember]
        public Nullable<int> SoNgayNghiPhepNamTruoc { get; set; }
    	[DataMember]
        public Nullable<int> TruNgayPhepDiDuong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.Guid> HinhThucNghi { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_Department Department { get; set; }
    	//[DataMember]
        //public virtual Mdl_Department Department1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_CC_HinhThucNghi CC_HinhThucNghi { get; set; }
    	//[DataMember]
        //public virtual Mdl_HoSo HoSo { get; set; }
    	//[DataMember]
        //public virtual Mdl_ThongTinNhanVien ThongTinNhanVien1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_TinhThanh TinhThanh1 { get; set; }
    }
}
