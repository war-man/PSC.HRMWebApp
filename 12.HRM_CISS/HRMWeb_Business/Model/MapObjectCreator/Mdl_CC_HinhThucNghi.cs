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
    public partial class Mdl_CC_HinhThucNghi
    {
        /*
    	ko xai
    	public Mdl_CC_HinhThucNghi()
        {
            this.CC_ChamCongNgayNghi = new HashSet<Mdl_CC_ChamCongNgayNghi>();
            this.CC_ChamCongTheoNgay = new HashSet<Mdl_CC_ChamCongTheoNgay>();
            this.CC_CaChamCong = new HashSet<Mdl_CC_CaChamCong>();
            this.CC_HinhThucKhac = new HashSet<Mdl_CC_HinhThucKhac>();
            this.CC_HinhThucKhac1 = new HashSet<Mdl_CC_HinhThucKhac>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenHinhThucNghi { get; set; }
    	[DataMember]
        public string KyHieu { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<byte> PhanLoai { get; set; }
    	[DataMember]
        public Nullable<decimal> GiaTri { get; set; }
    	[DataMember]
        public Nullable<decimal> SoNgayToiDa { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CongTy { get; set; }
    	[DataMember]
        public Nullable<decimal> DoUuTien { get; set; }
    	[DataMember]
        public Nullable<bool> HinhThucNghi { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongNgayNghi> CC_ChamCongNgayNghi { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_ChamCongTheoNgay> CC_ChamCongTheoNgay { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_CaChamCong> CC_CaChamCong { get; set; }
    	//[DataMember]
        //public virtual Mdl_CongTy CongTy1 { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_HinhThucKhac> CC_HinhThucKhac { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_HinhThucKhac> CC_HinhThucKhac1 { get; set; }
    }
}
