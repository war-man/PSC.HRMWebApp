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
    public partial class Mdl_CC_KhaiBaoCongTac
    {
        /*
    	ko xai
    	public Mdl_CC_KhaiBaoCongTac()
        {
            this.CC_Attachments = new HashSet<Mdl_CC_Attachments>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public System.Guid IDNhanVien { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    	[DataMember]
        public string NoiDung { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayTao { get; set; }
    	[DataMember]
        public System.Guid IDWebUser { get; set; }
    	[DataMember]
        public Nullable<int> TrangThai { get; set; }
    	[DataMember]
        public Nullable<byte> Buoi { get; set; }
    	[DataMember]
        public string DiaDiem { get; set; }
    	[DataMember]
        public Nullable<int> So { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NguoiKy { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgay { get; set; }
    	[DataMember]
        public Nullable<System.Guid> WebUserDuyet { get; set; }
    	[DataMember]
        public string PhanHoi_NguoiDuyet { get; set; }
    	[DataMember]
        public Nullable<bool> IsTruongPhong { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_Attachments> CC_Attachments { get; set; }
    	//[DataMember]
        //public virtual Mdl_HoSo HoSo { get; set; }
    	//[DataMember]
        //public virtual Mdl_HoSo HoSo1 { get; set; }
    }
}
