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
    public partial class Mdl_CoQuanThue
    {
        /*
    	ko xai
    	public Mdl_CoQuanThue()
        {
            this.CoQuanThue1 = new HashSet<Mdl_CoQuanThue>();
            this.NhanVienThongTinLuongs = new HashSet<Mdl_NhanVienThongTinLuong>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenCoQuanThue { get; set; }
    	[DataMember]
        public Nullable<System.Guid> DonViChuQuan { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CoQuanThue> CoQuanThue1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_CoQuanThue CoQuanThue2 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVienThongTinLuong> NhanVienThongTinLuongs { get; set; }
    }
}
