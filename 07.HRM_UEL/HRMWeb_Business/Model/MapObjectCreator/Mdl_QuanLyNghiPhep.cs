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
    public partial class Mdl_QuanLyNghiPhep
    {
        /*
    	ko xai
    	public Mdl_QuanLyNghiPhep()
        {
            this.ThongTinNghiPheps = new HashSet<Mdl_ThongTinNghiPhep>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<int> Nam { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayBatDau { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinTruong { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNghiPhep> ThongTinNghiPheps { get; set; }
    }
}
