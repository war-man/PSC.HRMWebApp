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
    public partial class Mdl_NhanVienTrinhDo
    {
        /*
    	ko xai
    	public Mdl_NhanVienTrinhDo()
        {
            this.NhanViens = new HashSet<Mdl_NhanVien>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TrinhDoVanHoa { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TrinhDoChuyenMon { get; set; }
    	[DataMember]
        public Nullable<System.Guid> ChuyenNganhDaoTao { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TruongDaoTao { get; set; }
    	[DataMember]
        public Nullable<System.Guid> HinhThucDaoTao { get; set; }
    	[DataMember]
        public Nullable<int> NamTotNghiep { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> NgayCapBang { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TrinhDoTinHoc { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NgoaiNgu { get; set; }
    	[DataMember]
        public Nullable<System.Guid> TrinhDoNgoaiNgu { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<System.Guid> HocHam { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVien> NhanViens { get; set; }
    }
}
