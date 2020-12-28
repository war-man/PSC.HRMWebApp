

using System.Runtime.Serialization;

namespace HRMWeb_Business.Model
{
    using System;
    using System.Collections.Generic;
    [DataContract]
    public partial class DTO_ModuleThongTinNhanSu_QuaTrinhKyLuat
    {
        [DataMember]
        public Nullable<System.DateTime> TuNgay { get; set; }
        [DataMember]
        public string HinhThucKyLuat { get; set; }
        [DataMember]
        public string SoQuyetDinh { get; set; }
        [DataMember]
        public string LyDo { get; set; }
    }
}
