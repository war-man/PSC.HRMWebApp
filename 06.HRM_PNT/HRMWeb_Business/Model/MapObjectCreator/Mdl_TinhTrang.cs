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
    public partial class Mdl_TinhTrang
    {
        /*
    	ko xai
    	public Mdl_TinhTrang()
        {
            this.NhanViens = new HashSet<Mdl_NhanVien>();
        }*/
    
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string MaQuanLy { get; set; }
    	[DataMember]
        public string TenTinhTrang { get; set; }
    	[DataMember]
        public Nullable<bool> KhongConCongTacTaiTruong { get; set; }
    	[DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
    	[DataMember]
        public Nullable<int> GCRecord { get; set; }
    	[DataMember]
        public Nullable<bool> KhongTinhTNTT { get; set; }
    	[DataMember]
        public Nullable<byte> LoaiTinhTrang { get; set; }
    	[DataMember]
        public Nullable<int> PhanTramHuongLuong { get; set; }
    
    	//[DataMember]
        //public virtual ICollection<Mdl_NhanVien> NhanViens { get; set; }
    }
}