//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace HRMWeb_Business.Model
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class DTO_QuanLyChamCongNhanVien
    {
        //[DataMember]
        //public IEnumerable<DTO_ChiTietChamCongNhanVien> DanhSachDTO_ChiTietChamCongNhanVien { get; set; }
        [DataMember]
        public System.Guid Oid { get; set; }
        [DataMember]
        public Nullable<System.Guid> ThongTinTruong { get; set; }
        [DataMember]
        public Nullable<System.Guid> KyTinhLuong { get; set; }
        [DataMember]
        public Nullable<System.DateTime> NgayLap { get; set; }
        [DataMember]
        public Nullable<System.Guid> CreatedUser { get; set; }
        //[DataMember]
        //public Nullable<int> OptimisticLockField { get; set; }
        //[DataMember]
        //public Nullable<int> GCRecord { get; set; }

        //public virtual ICollection<Mdl_ChiTietChamCongNhanVien> ChiTietChamCongNhanViens { get; set; }
    }
}
