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
    public partial class DTO_QuanLyChamCong_ThongTinChamCongThang
    {
        [DataMember]
        public String MaNhanSu { get; set; }
        [DataMember]
        public String MaTapDoan { get; set; }
        [DataMember]
        public String Ho{ get; set; }
        [DataMember]
        public String Ten { get; set; }
        [DataMember]
        public String HoTen { get; set; }
        [DataMember]
        public String TenDonVi { get; set; }

        [DataMember]
        public Boolean LaNhanVienToChucHanhChinh { get; set; }

        [DataMember]
        public System.Guid IDNhanVien { get; set; }

        [DataMember]
        public IEnumerable<DTO_QuanLyChamCong_ChamCongNgay> ChiTietChamCong { get; set; }

        [DataMember]
        public Nullable<Decimal> NgayHuongLuong;

        [DataMember]
        public Nullable<Decimal> NgayPhep;

        [DataMember]
        public Nullable<Decimal> NgayKhongLuong;

        [DataMember]
        public Nullable<Decimal> NgayHuongBHXH;

        [DataMember]
        public Nullable<Decimal> NgayHe;

        [DataMember]
        public Nullable<Decimal> TongCong;

        [DataMember]
        public String TenCa { get; set; }

        [DataMember]
        public String DanhGia { get; set; }
    }
}
