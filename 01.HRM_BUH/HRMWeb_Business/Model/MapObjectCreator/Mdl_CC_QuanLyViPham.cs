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
    public partial class Mdl_CC_QuanLyViPham
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> cc_HinhThucViPham { get; set; }
    	[DataMember]
        public Nullable<int> ThoiGianTre { get; set; }
    	[DataMember]
        public Nullable<int> ThoiGianSom { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChamCongTheoNgay { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_CC_HinhThucViPham CC_HinhThucViPham1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_CC_ChamCongTheoNgay CC_ChamCongTheoNgay { get; set; }
    }
}
