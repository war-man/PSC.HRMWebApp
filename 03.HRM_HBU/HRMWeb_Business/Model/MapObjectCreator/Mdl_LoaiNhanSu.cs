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
    public partial class Mdl_LoaiNhanSu
    {
        /*
    	ko xai
    	public Mdl_LoaiNhanSu()
        {
            this.ThongTinNhanViens = new HashSet<Mdl_ThongTinNhanVien>();
            this.ThongTinTinhLuongs = new HashSet<Mdl_ThongTinTinhLuong>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenLoaiNhanSu { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<int> CapDo { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNhanVien> ThongTinNhanViens { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinTinhLuong> ThongTinTinhLuongs { get; set; }
    }
}
