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
    public partial class Mdl_TinhThanh
    {
        /*
    	ko xai
    	public Mdl_TinhThanh()
        {
            this.HoSoes = new HashSet<Mdl_HoSo>();
            this.CC_ChamCongNgayNghi = new HashSet<Mdl_CC_ChamCongNgayNghi>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenTinhThanh { get; set; }
    	[DataMember]
        public Nullable<System.Guid> QuocGia { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgayDiDuong { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_HoSo> HoSoes { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongNgayNghi> CC_ChamCongNgayNghi { get; set; }
    }
}
