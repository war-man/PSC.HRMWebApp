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
    public partial class Mdl_BoPhan
    {
        /*
    	ko xai
    	public Mdl_BoPhan()
        {
            this.BoPhan1 = new HashSet<Mdl_BoPhan>();
            this.NhanViens = new HashSet<Mdl_NhanVien>();
            this.WebUser_BoPhan = new HashSet<Mdl_WebUser_BoPhan>();
            this.ThongTinNhanViens = new HashSet<Mdl_ThongTinNhanVien>();
            this.CC_ChamCongTheoNgay = new HashSet<Mdl_CC_ChamCongTheoNgay>();
            this.CC_ChamCongNgayNghi = new HashSet<Mdl_CC_ChamCongNgayNghi>();
            this.ChiTietChamCongNhanViens = new HashSet<Mdl_ChiTietChamCongNhanVien>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public Nullable<int> STT { get; set; }
    	[DataMember]
        public string TenBoPhan { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiBoPhan { get; set; }
    	[DataMember]
        public Nullable<System.Guid> BoPhanCha { get; set; }
    	[DataMember]
        public Nullable<decimal> MThamSoPCTrachNhiem { get; set; }
    	[DataMember]
        public Nullable<decimal> MThamSoLuongKy2 { get; set; }
    	[DataMember]
        public Nullable<bool> NgungHoatDong { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ThongTinTruong { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<int> ObjectType { get; set; }
    	[DataMember]
        public Nullable<int> SoGiangVien { get; set; }
    	[DataMember]
        public Nullable<int> SoSinhVien { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_BoPhan> BoPhan1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan2 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVien> NhanViens { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_WebUser_BoPhan> WebUser_BoPhan { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ThongTinNhanVien> ThongTinNhanViens { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongTheoNgay> CC_ChamCongTheoNgay { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongNgayNghi> CC_ChamCongNgayNghi { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_ChiTietChamCongNhanVien> ChiTietChamCongNhanViens { get; set; }
    }
}
