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
    public partial class Mdl_QuanHuyen
    {
        /*
    	ko xai
    	public Mdl_QuanHuyen()
        {
            this.XaPhuongs = new HashSet<Mdl_XaPhuong>();
            this.DiaChis = new HashSet<Mdl_DiaChi>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenQuanHuyen { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TinhThanh { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_TinhThanh TinhThanh1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_XaPhuong> XaPhuongs { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_DiaChi> DiaChis { get; set; }
    }
}
