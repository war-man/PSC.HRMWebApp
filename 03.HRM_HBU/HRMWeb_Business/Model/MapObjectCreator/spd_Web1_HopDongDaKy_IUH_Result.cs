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
    
    using System.Runtime.Serialization;
    [DataContract]
    public partial class spd_Web1_HopDongDaKy_IUH_Result
    {
    	[DataMember]
        public string SoHopDong { get; set; }
    	[DataMember]
        public string LoaiHopDong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayKy { get; set; }
    	[DataMember]
        public string NguoiKy { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    }
}
