

using System.Runtime.Serialization;

namespace HRMWeb_Business.Model
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class DTO_ModuleThongTinNhanSu_HopDongDaKy
    {
        [DataMember]
        public string SoHopDong { get; set; }
        [DataMember]
        public string LoaiHopDong { get; set; }
        [DataMember]
        public Nullable<System.DateTime> NgayKy { get; set; }
        [DataMember]
        public string NguoiKy { get; set; }
        [DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DenNgay { get; set; }
    }
}
