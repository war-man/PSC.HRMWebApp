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
    public partial class Mdl_NganHang
    {
        /*
    	ko xai
    	public Mdl_NganHang()
        {
            this.NganHang1 = new HashSet<Mdl_NganHang>();
            this.ThongTinTinhLuongs = new HashSet<Mdl_ThongTinTinhLuong>();
            this.TaiKhoanNganHangs = new HashSet<Mdl_TaiKhoanNganHang>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenNganHang { get; set; }
    	[DataMember]
        public string TenVietTat { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TrucThuoc { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_NganHang> NganHang1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_NganHang NganHang2 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinTinhLuong> ThongTinTinhLuongs { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_TaiKhoanNganHang> TaiKhoanNganHangs { get; set; }
    }
}
