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
    public partial class DTO_WebUser
    {




        //them
        //[DataMember]
        //public string MaNhanSu { get; set; }
        [DataMember]
        public string SoHieuCongChuc { get; set; }
        [DataMember]
        public string HoVaTen { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string TenBoPhan { get; set; }
        [DataMember]
        public string LoaiTaiKhoan { get; set; }


        //
        [DataMember]
        public System.Guid Oid { get; set; }
        [DataMember]
        public Nullable<System.Guid> ThongTinNhanVien { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public Nullable<bool> HoatDong { get; set; }
        [DataMember]
        public Nullable<bool> UserChamCong { get; set; }
        [DataMember]
        public Nullable<System.Guid> WebGroupID { get; set; }
        [DataMember]
        public Nullable<System.Guid> DepartmentId { get; set; }
        [DataMember]
        public Nullable<int> AgentObjectTypeId { get; set; }
        [DataMember]
        public Nullable<int> OptimisticLockField { get; set; }
        [DataMember]
        public Nullable<int> GCRecord { get; set; }
        [DataMember]
        public string AdminEmail { get; set; }


        //them
        [DataMember]
        public IEnumerable<DTO_BoPhan> DanhSachDTO_BoPhan { get; set; }

        //public virtual Mdl_WebGroup WebGroup { get; set; }
        //public virtual ICollection<Mdl_WebUser_BoPhan> WebUser_BoPhan { get; set; }
        //public virtual ICollection<Mdl_CC_ChamCongTheoNgay> CC_ChamCongTheoNgay { get; set; }
        //public virtual Mdl_HoSo HoSo { get; set; }
    }
}
