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
    public partial class Mdl_TrinhDoChuyenMon
    {
        /*
    	ko xai
    	public Mdl_TrinhDoChuyenMon()
        {
            this.BoPhans = new HashSet<Mdl_BoPhan>();
            this.ThongTinTinhLuongs = new HashSet<Mdl_ThongTinTinhLuong>();
            this.NhanVienTrinhDoes = new HashSet<Mdl_NhanVienTrinhDo>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenTrinhDoChuyenMon { get; set; }
    	[DataMember]
        public Nullable<int> CapDo { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_BoPhan> BoPhans { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinTinhLuong> ThongTinTinhLuongs { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVienTrinhDo> NhanVienTrinhDoes { get; set; }
    }
}
