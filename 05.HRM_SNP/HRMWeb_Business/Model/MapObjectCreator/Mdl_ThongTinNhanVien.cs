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
            this.WebUsers = new HashSet<Mdl_WebUser>();
            this.CC_ChiTietChamCong = new HashSet<Mdl_CC_ChiTietChamCong>();
            this.CC_ChamCongNgayNghi = new HashSet<Mdl_CC_ChamCongNgayNghi>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<bool> KhoaHoSo { get; set; }
    	[DataMember]
        public Nullable<bool> BienChe { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoBienChe { get; set; }
    	[DataMember]
        public Nullable<System.Guid> LoaiNhanSu { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVu { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayBoNhiemChucVu { get; set; }
    	[DataMember]
        public Nullable<bool> ChamCong { get; set; }
    	[DataMember]
        public string IDChamCong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuDang { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoDang { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChucVuDoan { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayVaoDoan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CapBacQuanHam { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayNhapNgu { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayXuatNgu { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_LoaiNhanSu LoaiNhanSu1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_NhanVien NhanVien { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_WebUser> WebUsers { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChiTietChamCong> CC_ChiTietChamCong { get; set; }
    	//[DataMember]
        //public virtual Mdl_ChucVu ChucVu1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongNgayNghi> CC_ChamCongNgayNghi { get; set; }
    }
}
