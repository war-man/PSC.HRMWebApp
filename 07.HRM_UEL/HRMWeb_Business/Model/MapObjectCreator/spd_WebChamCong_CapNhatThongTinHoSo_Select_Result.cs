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
    public partial class spd_WebChamCong_CapNhatThongTinHoSo_Select_Result
    {
    	[DataMember]
        public Nullable<System.Guid> TonGiao { get; set; }
    	[DataMember]
        public string TenTonGiao { get; set; }
    	[DataMember]
        public Nullable<int> ChieuCao { get; set; }
    	[DataMember]
        public Nullable<int> CanNang { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TinhTrangHonNhan { get; set; }
    	[DataMember]
        public string TenTinhTrangHonNhan { get; set; }
    	[DataMember]
        public string CMND { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayCap { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NoiCap { get; set; }
    	[DataMember]
        public string TenNoiCap { get; set; }
    	[DataMember]
        public string DienThoaiDiDong { get; set; }
    }
}
