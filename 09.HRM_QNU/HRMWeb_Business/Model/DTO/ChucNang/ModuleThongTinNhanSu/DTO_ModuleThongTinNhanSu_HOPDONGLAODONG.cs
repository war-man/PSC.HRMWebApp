

using System.Runtime.Serialization;

namespace HRMWeb_Business.Model
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class DTO_ModuleThongTinNhanSu_HOPDONGLAODONG
    {
        [DataMember]
        public DTO_ModuleThongTinNhanSu_HopDong HopDong { get; set; }

        [DataMember]
        public IEnumerable<DTO_ModuleThongTinNhanSu_HopDongDaKy> DanhSach_HopDongDaKy { get; set; }

   
    }
}
