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
    public partial class DTO_SucKhoe
    {




        //them
        //[DataMember]
        //public string MaNhanSu { get; set; }
        [DataMember]
        public Guid Oid { get; set; }
        [DataMember]
        public string MaQuanLy { get; set; }
        [DataMember]
        public string TenSucKhoe { get; set; }
        [DataMember]
        public int OptimisticLockField { get; set; }
        [DataMember]
        public int GCRecord { get; set; }

        //public virtual Mdl_WebGroup WebGroup { get; set; }
        //public virtual ICollection<Mdl_WebUser_BoPhan> WebUser_BoPhan { get; set; }
        //public virtual ICollection<Mdl_CC_ChamCongTheoNgay> CC_ChamCongTheoNgay { get; set; }
        //public virtual Mdl_HoSo HoSo { get; set; }
    }
}
