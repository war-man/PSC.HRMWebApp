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
            this.ThongTinNhanViens = new HashSet<Mdl_ThongTinNhanVien>();
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
        public Nullable<byte> LoaiCa { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public string TenCa { get; set; }
    	[DataMember]
        public string ThoiGianRaThu7 { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_DangKyKhungGioLamViec> CC_DangKyKhungGioLamViec { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNhanVien> ThongTinNhanViens { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongTheoNgay> CC_ChamCongTheoNgay { get; set; }
    }
}
