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
    public partial class Mdl_CC_ChamCongTheoNgay
    {
        /*
    	ko xai
    	public Mdl_CC_ChamCongTheoNgay()
        {
            this.CC_QuanLyViPham = new HashSet<Mdl_CC_QuanLyViPham>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<int> IDNhanSu_ChamCong { get; set; }
    	[DataMember]
        public System.Guid IDNhanVien { get; set; }
    	[DataMember]
        public System.DateTime Ngay { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDHinhThucNghi { get; set; }
    	[DataMember]
        public System.Guid IDBoPhan { get; set; }
    	[DataMember]
        public System.Guid IDWebUsers { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> GioVaoSang { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> GioVaoChieu { get; set; }
    	[DataMember]
        public bool DaChamCong { get; set; }
    	[DataMember]
        public Nullable<bool> DiHoc { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> GioRaSang { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> GioRaChieu { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDHinhThucNghiOld { get; set; }
    	[DataMember]
        public Nullable<System.Guid> CC_CaChamCong { get; set; }
    	[DataMember]
        public string GhiChu { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayDoiCa { get; set; }
    	[DataMember]
        public bool NguoiDungChinhSua { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiCanBo { get; set; }
    	[DataMember]
        public Nullable<bool> Khoa { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan { get; set; }
    	//[DataMember]
        //public virtual Mdl_CC_CaChamCong CC_CaChamCong1 { get; set; }
    	//[DataMember]
        //public virtual Mdl_HinhThucNghi HinhThucNghi { get; set; }
    	//[DataMember]
        //public virtual Mdl_HoSo HoSo { get; set; }
    	//[DataMember]
        //public virtual ICollection<Mdl_CC_QuanLyViPham> CC_QuanLyViPham { get; set; }
    }
}
