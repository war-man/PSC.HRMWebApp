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
    public partial class Mdl_ChucVu
    {
        /*
    	ko xai
    	public Mdl_ChucVu()
        {
            this.ThongTinNhanViens = new HashSet<Mdl_ThongTinNhanVien>();
            this.ThongTinNhanViens1 = new HashSet<Mdl_ThongTinNhanVien>();
            this.ThongTinNhanViens2 = new HashSet<Mdl_ThongTinNhanVien>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<int> ThuTu { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenChucVu { get; set; }
    	[DataMember]
        public Nullable<byte> PhanLoai { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCChucVu { get; set; }
    	[DataMember]
        public Nullable<decimal> HSPCQuanLy { get; set; }
    	[DataMember]
        public Nullable<decimal> PhuCapDienThoai { get; set; }
    	[DataMember]
        public Nullable<decimal> SoLitXang { get; set; }
    	[DataMember]
        public Nullable<decimal> TyTrongDiemDanhGia { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<int> AgentObjectTypeId { get; set; }
    	[DataMember]
        public Nullable<bool> LaQuanLy { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoTCDLD { get; set; }
    	[DataMember]
        public Nullable<decimal> HeSoTNTT { get; set; }
    	[DataMember]
        public string GhiChu { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNhanVien> ThongTinNhanViens { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNhanVien> ThongTinNhanViens1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNhanVien> ThongTinNhanViens2 { get; set; }
    }
}
