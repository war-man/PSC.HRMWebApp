//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 03:34:42 ngay 05/01/2017
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
//using System.Data.EntityClient;
using System.Data.Entity.Core.EntityClient;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
//using System.Data.Objects.DataClasses;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace HRMWeb_Business.Model
{
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Report_Luong_ChiTietTongThuNhapTungNhanVienTest_Result2")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Report_Luong_ChiTietTongThuNhapTungNhanVienTest_Result2 : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoTaiKhoan
        {
            get
            {
                return _soTaiKhoan;
            }
            set
            {
    			string oldValue =  _soTaiKhoan;
    			bool stopChanging = false;
                On_SoTaiKhoan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoTaiKhoan");
    			if(!stopChanging)
    			{
    				_soTaiKhoan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoTaiKhoan");
    				On_SoTaiKhoan_Changed(oldValue, _soTaiKhoan);//\\
    			}
            }
        }
    	public static String SoTaiKhoan_PropertyName { get { return "SoTaiKhoan"; } }
        private string _soTaiKhoan;
        partial void On_SoTaiKhoan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoTaiKhoan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string Ho
        {
            get
            {
                return _ho;
            }
            set
            {
    			string oldValue =  _ho;
    			bool stopChanging = false;
                On_Ho_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Ho");
    			if(!stopChanging)
    			{
    				_ho = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("Ho");
    				On_Ho_Changed(oldValue, _ho);//\\
    			}
            }
        }
    	public static String Ho_PropertyName { get { return "Ho"; } }
        private string _ho;
        partial void On_Ho_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_Ho_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string Ten
        {
            get
            {
                return _ten;
            }
            set
            {
    			string oldValue =  _ten;
    			bool stopChanging = false;
                On_Ten_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Ten");
    			if(!stopChanging)
    			{
    				_ten = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("Ten");
    				On_Ten_Changed(oldValue, _ten);//\\
    			}
            }
        }
    	public static String Ten_PropertyName { get { return "Ten"; } }
        private string _ten;
        partial void On_Ten_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_Ten_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string MaNgach
        {
            get
            {
                return _maNgach;
            }
            set
            {
    			string oldValue =  _maNgach;
    			bool stopChanging = false;
                On_MaNgach_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MaNgach");
    			if(!stopChanging)
    			{
    				_maNgach = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("MaNgach");
    				On_MaNgach_Changed(oldValue, _maNgach);//\\
    			}
            }
        }
    	public static String MaNgach_PropertyName { get { return "MaNgach"; } }
        private string _maNgach;
        partial void On_MaNgach_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_MaNgach_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HeSoLuong
        {
            get
            {
                return _heSoLuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _heSoLuong;
    			bool stopChanging = false;
                On_HeSoLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HeSoLuong");
    			if(!stopChanging)
    			{
    				_heSoLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HeSoLuong");
    				On_HeSoLuong_Changed(oldValue, _heSoLuong);//\\
    			}
            }
        }
    	public static String HeSoLuong_PropertyName { get { return "HeSoLuong"; } }
        private Nullable<decimal> _heSoLuong;
        partial void On_HeSoLuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HeSoLuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> VuotKhung
        {
            get
            {
                return _vuotKhung;
            }
            set
            {
    			Nullable<decimal> oldValue =  _vuotKhung;
    			bool stopChanging = false;
                On_VuotKhung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("VuotKhung");
    			if(!stopChanging)
    			{
    				_vuotKhung = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("VuotKhung");
    				On_VuotKhung_Changed(oldValue, _vuotKhung);//\\
    			}
            }
        }
    	public static String VuotKhung_PropertyName { get { return "VuotKhung"; } }
        private Nullable<decimal> _vuotKhung;
        partial void On_VuotKhung_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_VuotKhung_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCVuotKhung
        {
            get
            {
                return _hSPCVuotKhung;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCVuotKhung;
    			bool stopChanging = false;
                On_HSPCVuotKhung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCVuotKhung");
    			if(!stopChanging)
    			{
    				_hSPCVuotKhung = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCVuotKhung");
    				On_HSPCVuotKhung_Changed(oldValue, _hSPCVuotKhung);//\\
    			}
            }
        }
    	public static String HSPCVuotKhung_PropertyName { get { return "HSPCVuotKhung"; } }
        private Nullable<decimal> _hSPCVuotKhung;
        partial void On_HSPCVuotKhung_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCVuotKhung_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCChucVu
        {
            get
            {
                return _hSPCChucVu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCChucVu;
    			bool stopChanging = false;
                On_HSPCChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCChucVu");
    			if(!stopChanging)
    			{
    				_hSPCChucVu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCChucVu");
    				On_HSPCChucVu_Changed(oldValue, _hSPCChucVu);//\\
    			}
            }
        }
    	public static String HSPCChucVu_PropertyName { get { return "HSPCChucVu"; } }
        private Nullable<decimal> _hSPCChucVu;
        partial void On_HSPCChucVu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCChucVu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> ThamNien
        {
            get
            {
                return _thamNien;
            }
            set
            {
    			Nullable<decimal> oldValue =  _thamNien;
    			bool stopChanging = false;
                On_ThamNien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThamNien");
    			if(!stopChanging)
    			{
    				_thamNien = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThamNien");
    				On_ThamNien_Changed(oldValue, _thamNien);//\\
    			}
            }
        }
    	public static String ThamNien_PropertyName { get { return "ThamNien"; } }
        private Nullable<decimal> _thamNien;
        partial void On_ThamNien_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_ThamNien_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCThamNienNhaGiao
        {
            get
            {
                return _hSPCThamNienNhaGiao;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCThamNienNhaGiao;
    			bool stopChanging = false;
                On_HSPCThamNienNhaGiao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCThamNienNhaGiao");
    			if(!stopChanging)
    			{
    				_hSPCThamNienNhaGiao = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCThamNienNhaGiao");
    				On_HSPCThamNienNhaGiao_Changed(oldValue, _hSPCThamNienNhaGiao);//\\
    			}
            }
        }
    	public static String HSPCThamNienNhaGiao_PropertyName { get { return "HSPCThamNienNhaGiao"; } }
        private Nullable<decimal> _hSPCThamNienNhaGiao;
        partial void On_HSPCThamNienNhaGiao_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCThamNienNhaGiao_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongHeSoLuong
        {
            get
            {
                return _tongHeSoLuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongHeSoLuong;
    			bool stopChanging = false;
                On_TongHeSoLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongHeSoLuong");
    			if(!stopChanging)
    			{
    				_tongHeSoLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongHeSoLuong");
    				On_TongHeSoLuong_Changed(oldValue, _tongHeSoLuong);//\\
    			}
            }
        }
    	public static String TongHeSoLuong_PropertyName { get { return "TongHeSoLuong"; } }
        private Nullable<decimal> _tongHeSoLuong;
        partial void On_TongHeSoLuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongHeSoLuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> PTHuongLuong
        {
            get
            {
                return _pTHuongLuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _pTHuongLuong;
    			bool stopChanging = false;
                On_PTHuongLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PTHuongLuong");
    			if(!stopChanging)
    			{
    				_pTHuongLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PTHuongLuong");
    				On_PTHuongLuong_Changed(oldValue, _pTHuongLuong);//\\
    			}
            }
        }
    	public static String PTHuongLuong_PropertyName { get { return "PTHuongLuong"; } }
        private Nullable<decimal> _pTHuongLuong;
        partial void On_PTHuongLuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_PTHuongLuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongTienLuong
        {
            get
            {
                return _tongTienLuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongTienLuong;
    			bool stopChanging = false;
                On_TongTienLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongTienLuong");
    			if(!stopChanging)
    			{
    				_tongTienLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongTienLuong");
    				On_TongTienLuong_Changed(oldValue, _tongTienLuong);//\\
    			}
            }
        }
    	public static String TongTienLuong_PropertyName { get { return "TongTienLuong"; } }
        private Nullable<decimal> _tongTienLuong;
        partial void On_TongTienLuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongTienLuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayNghiViec
        {
            get
            {
                return _soNgayNghiViec;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayNghiViec;
    			bool stopChanging = false;
                On_SoNgayNghiViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayNghiViec");
    			if(!stopChanging)
    			{
    				_soNgayNghiViec = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayNghiViec");
    				On_SoNgayNghiViec_Changed(oldValue, _soNgayNghiViec);//\\
    			}
            }
        }
    	public static String SoNgayNghiViec_PropertyName { get { return "SoNgayNghiViec"; } }
        private Nullable<decimal> _soNgayNghiViec;
        partial void On_SoNgayNghiViec_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayNghiViec_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TienNgayNghiViec
        {
            get
            {
                return _tienNgayNghiViec;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tienNgayNghiViec;
    			bool stopChanging = false;
                On_TienNgayNghiViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TienNgayNghiViec");
    			if(!stopChanging)
    			{
    				_tienNgayNghiViec = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TienNgayNghiViec");
    				On_TienNgayNghiViec_Changed(oldValue, _tienNgayNghiViec);//\\
    			}
            }
        }
    	public static String TienNgayNghiViec_PropertyName { get { return "TienNgayNghiViec"; } }
        private Nullable<decimal> _tienNgayNghiViec;
        partial void On_TienNgayNghiViec_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TienNgayNghiViec_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayBHXHTra
        {
            get
            {
                return _soNgayBHXHTra;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayBHXHTra;
    			bool stopChanging = false;
                On_SoNgayBHXHTra_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayBHXHTra");
    			if(!stopChanging)
    			{
    				_soNgayBHXHTra = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayBHXHTra");
    				On_SoNgayBHXHTra_Changed(oldValue, _soNgayBHXHTra);//\\
    			}
            }
        }
    	public static String SoNgayBHXHTra_PropertyName { get { return "SoNgayBHXHTra"; } }
        private Nullable<decimal> _soNgayBHXHTra;
        partial void On_SoNgayBHXHTra_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayBHXHTra_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TienBHXHTra
        {
            get
            {
                return _tienBHXHTra;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tienBHXHTra;
    			bool stopChanging = false;
                On_TienBHXHTra_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TienBHXHTra");
    			if(!stopChanging)
    			{
    				_tienBHXHTra = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TienBHXHTra");
    				On_TienBHXHTra_Changed(oldValue, _tienBHXHTra);//\\
    			}
            }
        }
    	public static String TienBHXHTra_PropertyName { get { return "TienBHXHTra"; } }
        private Nullable<decimal> _tienBHXHTra;
        partial void On_TienBHXHTra_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TienBHXHTra_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> BHYT
        {
            get
            {
                return _bHYT;
            }
            set
            {
    			Nullable<decimal> oldValue =  _bHYT;
    			bool stopChanging = false;
                On_BHYT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BHYT");
    			if(!stopChanging)
    			{
    				_bHYT = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("BHYT");
    				On_BHYT_Changed(oldValue, _bHYT);//\\
    			}
            }
        }
    	public static String BHYT_PropertyName { get { return "BHYT"; } }
        private Nullable<decimal> _bHYT;
        partial void On_BHYT_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_BHYT_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> BHTN
        {
            get
            {
                return _bHTN;
            }
            set
            {
    			Nullable<decimal> oldValue =  _bHTN;
    			bool stopChanging = false;
                On_BHTN_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BHTN");
    			if(!stopChanging)
    			{
    				_bHTN = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("BHTN");
    				On_BHTN_Changed(oldValue, _bHTN);//\\
    			}
            }
        }
    	public static String BHTN_PropertyName { get { return "BHTN"; } }
        private Nullable<decimal> _bHTN;
        partial void On_BHTN_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_BHTN_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> BHXH
        {
            get
            {
                return _bHXH;
            }
            set
            {
    			Nullable<decimal> oldValue =  _bHXH;
    			bool stopChanging = false;
                On_BHXH_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BHXH");
    			if(!stopChanging)
    			{
    				_bHXH = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("BHXH");
    				On_BHXH_Changed(oldValue, _bHXH);//\\
    			}
            }
        }
    	public static String BHXH_PropertyName { get { return "BHXH"; } }
        private Nullable<decimal> _bHXH;
        partial void On_BHXH_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_BHXH_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> DPCD
        {
            get
            {
                return _dPCD;
            }
            set
            {
    			Nullable<decimal> oldValue =  _dPCD;
    			bool stopChanging = false;
                On_DPCD_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DPCD");
    			if(!stopChanging)
    			{
    				_dPCD = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DPCD");
    				On_DPCD_Changed(oldValue, _dPCD);//\\
    			}
            }
        }
    	public static String DPCD_PropertyName { get { return "DPCD"; } }
        private Nullable<decimal> _dPCD;
        partial void On_DPCD_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_DPCD_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongKhoanTru
        {
            get
            {
                return _tongKhoanTru;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongKhoanTru;
    			bool stopChanging = false;
                On_TongKhoanTru_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongKhoanTru");
    			if(!stopChanging)
    			{
    				_tongKhoanTru = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongKhoanTru");
    				On_TongKhoanTru_Changed(oldValue, _tongKhoanTru);//\\
    			}
            }
        }
    	public static String TongKhoanTru_PropertyName { get { return "TongKhoanTru"; } }
        private Nullable<decimal> _tongKhoanTru;
        partial void On_TongKhoanTru_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongKhoanTru_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> PhuCapUuDai
        {
            get
            {
                return _phuCapUuDai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _phuCapUuDai;
    			bool stopChanging = false;
                On_PhuCapUuDai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhuCapUuDai");
    			if(!stopChanging)
    			{
    				_phuCapUuDai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhuCapUuDai");
    				On_PhuCapUuDai_Changed(oldValue, _phuCapUuDai);//\\
    			}
            }
        }
    	public static String PhuCapUuDai_PropertyName { get { return "PhuCapUuDai"; } }
        private Nullable<decimal> _phuCapUuDai;
        partial void On_PhuCapUuDai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_PhuCapUuDai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCUuDai
        {
            get
            {
                return _hSPCUuDai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCUuDai;
    			bool stopChanging = false;
                On_HSPCUuDai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCUuDai");
    			if(!stopChanging)
    			{
    				_hSPCUuDai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCUuDai");
    				On_HSPCUuDai_Changed(oldValue, _hSPCUuDai);//\\
    			}
            }
        }
    	public static String HSPCUuDai_PropertyName { get { return "HSPCUuDai"; } }
        private Nullable<decimal> _hSPCUuDai;
        partial void On_HSPCUuDai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCUuDai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> PhuCapKiemNhiem
        {
            get
            {
                return _phuCapKiemNhiem;
            }
            set
            {
    			Nullable<decimal> oldValue =  _phuCapKiemNhiem;
    			bool stopChanging = false;
                On_PhuCapKiemNhiem_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhuCapKiemNhiem");
    			if(!stopChanging)
    			{
    				_phuCapKiemNhiem = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhuCapKiemNhiem");
    				On_PhuCapKiemNhiem_Changed(oldValue, _phuCapKiemNhiem);//\\
    			}
            }
        }
    	public static String PhuCapKiemNhiem_PropertyName { get { return "PhuCapKiemNhiem"; } }
        private Nullable<decimal> _phuCapKiemNhiem;
        partial void On_PhuCapKiemNhiem_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_PhuCapKiemNhiem_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCKiemNhiem
        {
            get
            {
                return _hSPCKiemNhiem;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCKiemNhiem;
    			bool stopChanging = false;
                On_HSPCKiemNhiem_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCKiemNhiem");
    			if(!stopChanging)
    			{
    				_hSPCKiemNhiem = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCKiemNhiem");
    				On_HSPCKiemNhiem_Changed(oldValue, _hSPCKiemNhiem);//\\
    			}
            }
        }
    	public static String HSPCKiemNhiem_PropertyName { get { return "HSPCKiemNhiem"; } }
        private Nullable<decimal> _hSPCKiemNhiem;
        partial void On_HSPCKiemNhiem_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCKiemNhiem_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCDocHai
        {
            get
            {
                return _hSPCDocHai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCDocHai;
    			bool stopChanging = false;
                On_HSPCDocHai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCDocHai");
    			if(!stopChanging)
    			{
    				_hSPCDocHai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCDocHai");
    				On_HSPCDocHai_Changed(oldValue, _hSPCDocHai);//\\
    			}
            }
        }
    	public static String HSPCDocHai_PropertyName { get { return "HSPCDocHai"; } }
        private Nullable<decimal> _hSPCDocHai;
        partial void On_HSPCDocHai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCDocHai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCTrachNhiem
        {
            get
            {
                return _hSPCTrachNhiem;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCTrachNhiem;
    			bool stopChanging = false;
                On_HSPCTrachNhiem_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCTrachNhiem");
    			if(!stopChanging)
    			{
    				_hSPCTrachNhiem = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCTrachNhiem");
    				On_HSPCTrachNhiem_Changed(oldValue, _hSPCTrachNhiem);//\\
    			}
            }
        }
    	public static String HSPCTrachNhiem_PropertyName { get { return "HSPCTrachNhiem"; } }
        private Nullable<decimal> _hSPCTrachNhiem;
        partial void On_HSPCTrachNhiem_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCTrachNhiem_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongHSPC
        {
            get
            {
                return _tongHSPC;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongHSPC;
    			bool stopChanging = false;
                On_TongHSPC_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongHSPC");
    			if(!stopChanging)
    			{
    				_tongHSPC = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongHSPC");
    				On_TongHSPC_Changed(oldValue, _tongHSPC);//\\
    			}
            }
        }
    	public static String TongHSPC_PropertyName { get { return "TongHSPC"; } }
        private Nullable<decimal> _tongHSPC;
        partial void On_TongHSPC_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongHSPC_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongTienPhuCap
        {
            get
            {
                return _tongTienPhuCap;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongTienPhuCap;
    			bool stopChanging = false;
                On_TongTienPhuCap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongTienPhuCap");
    			if(!stopChanging)
    			{
    				_tongTienPhuCap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongTienPhuCap");
    				On_TongTienPhuCap_Changed(oldValue, _tongTienPhuCap);//\\
    			}
            }
        }
    	public static String TongTienPhuCap_PropertyName { get { return "TongTienPhuCap"; } }
        private Nullable<decimal> _tongTienPhuCap;
        partial void On_TongTienPhuCap_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongTienPhuCap_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TruyThu
        {
            get
            {
                return _truyThu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _truyThu;
    			bool stopChanging = false;
                On_TruyThu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TruyThu");
    			if(!stopChanging)
    			{
    				_truyThu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TruyThu");
    				On_TruyThu_Changed(oldValue, _truyThu);//\\
    			}
            }
        }
    	public static String TruyThu_PropertyName { get { return "TruyThu"; } }
        private Nullable<decimal> _truyThu;
        partial void On_TruyThu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TruyThu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> ThucLanh
        {
            get
            {
                return _thucLanh;
            }
            set
            {
    			Nullable<decimal> oldValue =  _thucLanh;
    			bool stopChanging = false;
                On_ThucLanh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThucLanh");
    			if(!stopChanging)
    			{
    				_thucLanh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThucLanh");
    				On_ThucLanh_Changed(oldValue, _thucLanh);//\\
    			}
            }
        }
    	public static String ThucLanh_PropertyName { get { return "ThucLanh"; } }
        private Nullable<decimal> _thucLanh;
        partial void On_ThucLanh_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_ThucLanh_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
