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
    public partial class Mdl_CC_CaChamCong
    {
        /*
    	ko xai
    	public Mdl_CC_CaChamCong()
        {
            this.CC_DangKyKhungGioLamViec = new HashSet<Mdl_CC_DangKyKhungGioLamViec>();
            this.CC_ChamCongTheoNgay = new HashSet<Mdl_CC_ChamCongTheoNgay>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string ThoiGianVaoSang { get; set; }
    	[DataMember]
        public string ThoiGianRaSang { get; set; }
    	[DataMember]
        public string ThoiGianBatDauNghiGiuaCa { get; set; }
    	[DataMember]
        public string ThoiGianKetThucNghiGiuaCa { get; set; }
    	[DataMember]
        public string ThoiGianVaoChieu { get; set; }
    	[DataMember]
        public string ThoiGianRaChieu { get; set; }
    	[DataMember]
        public Nullable<int> SoPhutCong { get; set; }
    	[DataMember]
        public Nullable<int> SoPhutTru { get; set; }
    	[DataMember]
        public Nullable<int> TongSoGioLamViec { get; set; }
    	[DataMember]
        public Nullable<bool> Active { get; set; }
    	[DataMember]
        public byte LoaiCa { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<decimal> TongSoGioLamViecBuoiSang { get; set; }
    	[DataMember]
        public Nullable<decimal> TongSoGioLamViecBuoiChieu { get; set; }
    	[DataMember]
        public Nullable<decimal> TongSoGioLamViecCaNgay { get; set; }
    	[DataMember]
        public string TenCa { get; set; }
    	[DataMember]
        public Nullable<decimal> TongSoGioNghiGiuaCa { get; set; }
    	[DataMember]
        public string ThoiGianBDQuetBuoiSang { get; set; }
    	[DataMember]
        public string ThoiGianKTQuetBuoiChieu { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_DangKyKhungGioLamViec> CC_DangKyKhungGioLamViec { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongTheoNgay> CC_ChamCongTheoNgay { get; set; }
    }
}
