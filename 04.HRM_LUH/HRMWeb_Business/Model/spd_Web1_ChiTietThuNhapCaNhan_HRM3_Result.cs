//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 04:17:16 ngay 30/08/2016
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result object.
        /// </summary>
        /// <param name="maNhanSu">Initial value of the MaNhanSu property.</param>
        /// <param name="ngachLuong">Initial value of the NgachLuong property.</param>
        /// <param name="bacLuong">Initial value of the BacLuong property.</param>
        /// <param name="heSoLuong">Initial value of the HeSoLuong property.</param>
        /// <param name="luongCoBan">Initial value of the LuongCoBan property.</param>
        /// <param name="xepLoai">Initial value of the XepLoai property.</param>
        /// <param name="thuLaoGiangDay">Initial value of the ThuLaoGiangDay property.</param>
        /// <param name="luongNganSach">Initial value of the LuongNganSach property.</param>
        /// <param name="phuCap">Initial value of the PhuCap property.</param>
        /// <param name="thuNhapTangThem">Initial value of the ThuNhapTangThem property.</param>
        /// <param name="thuNhapKhac">Initial value of the ThuNhapKhac property.</param>
        /// <param name="ngoaiGio">Initial value of the NgoaiGio property.</param>
        /// <param name="khenThuong">Initial value of the KhenThuong property.</param>
        /// <param name="khauTruLuong">Initial value of the KhauTruLuong property.</param>
        /// <param name="thueTNCN">Initial value of the ThueTNCN property.</param>
        public static spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result Createspd_Web1_ChiTietThuNhapCaNhan_HRM3_Result(string maNhanSu, string ngachLuong, string bacLuong, decimal heSoLuong, decimal luongCoBan, string xepLoai, decimal thuLaoGiangDay, decimal luongNganSach, decimal phuCap, decimal thuNhapTangThem, decimal thuNhapKhac, decimal ngoaiGio, decimal khenThuong, decimal khauTruLuong, decimal thueTNCN)
        {
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result = new spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result();
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.MaNhanSu = maNhanSu;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.NgachLuong = ngachLuong;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.BacLuong = bacLuong;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.HeSoLuong = heSoLuong;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.LuongCoBan = luongCoBan;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.XepLoai = xepLoai;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.ThuLaoGiangDay = thuLaoGiangDay;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.LuongNganSach = luongNganSach;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.PhuCap = phuCap;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.ThuNhapTangThem = thuNhapTangThem;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.ThuNhapKhac = thuNhapKhac;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.NgoaiGio = ngoaiGio;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.KhenThuong = khenThuong;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.KhauTruLuong = khauTruLuong;
            spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result.ThueTNCN = thueTNCN;
            return spd_Web1_ChiTietThuNhapCaNhan_HRM3_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string MaNhanSu
        {
            get
            {
                return _maNhanSu;
            }
            set
            {
    			string oldValue =  _maNhanSu;
    			bool stopChanging = false;
                On_MaNhanSu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MaNhanSu");
    			if(!stopChanging)
    			{
    				_maNhanSu = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("MaNhanSu");
    				On_MaNhanSu_Changed(oldValue, _maNhanSu);//\\
    			}
            }
        }
    	public static String MaNhanSu_PropertyName { get { return "MaNhanSu"; } }
        private string _maNhanSu;
        partial void On_MaNhanSu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_MaNhanSu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string HoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
    			string oldValue =  _hoTen;
    			bool stopChanging = false;
                On_HoTen_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HoTen");
    			if(!stopChanging)
    			{
    				_hoTen = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HoTen");
    				On_HoTen_Changed(oldValue, _hoTen);//\\
    			}
            }
        }
    	public static String HoTen_PropertyName { get { return "HoTen"; } }
        private string _hoTen;
        partial void On_HoTen_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HoTen_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DonVi
        {
            get
            {
                return _donVi;
            }
            set
            {
    			string oldValue =  _donVi;
    			bool stopChanging = false;
                On_DonVi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DonVi");
    			if(!stopChanging)
    			{
    				_donVi = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DonVi");
    				On_DonVi_Changed(oldValue, _donVi);//\\
    			}
            }
        }
    	public static String DonVi_PropertyName { get { return "DonVi"; } }
        private string _donVi;
        partial void On_DonVi_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DonVi_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string NgachLuong
        {
            get
            {
                return _ngachLuong;
            }
            set
            {
    			string oldValue =  _ngachLuong;
    			bool stopChanging = false;
                On_NgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgachLuong");
    			if(!stopChanging)
    			{
    				_ngachLuong = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("NgachLuong");
    				On_NgachLuong_Changed(oldValue, _ngachLuong);//\\
    			}
            }
        }
    	public static String NgachLuong_PropertyName { get { return "NgachLuong"; } }
        private string _ngachLuong;
        partial void On_NgachLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgachLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string BacLuong
        {
            get
            {
                return _bacLuong;
            }
            set
            {
    			string oldValue =  _bacLuong;
    			bool stopChanging = false;
                On_BacLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BacLuong");
    			if(!stopChanging)
    			{
    				_bacLuong = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("BacLuong");
    				On_BacLuong_Changed(oldValue, _bacLuong);//\\
    			}
            }
        }
    	public static String BacLuong_PropertyName { get { return "BacLuong"; } }
        private string _bacLuong;
        partial void On_BacLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_BacLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal HeSoLuong
        {
            get
            {
                return _heSoLuong;
            }
            set
            {
    			decimal oldValue =  _heSoLuong;
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
        private decimal _heSoLuong;
        partial void On_HeSoLuong_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_HeSoLuong_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal LuongCoBan
        {
            get
            {
                return _luongCoBan;
            }
            set
            {
    			decimal oldValue =  _luongCoBan;
    			bool stopChanging = false;
                On_LuongCoBan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LuongCoBan");
    			if(!stopChanging)
    			{
    				_luongCoBan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LuongCoBan");
    				On_LuongCoBan_Changed(oldValue, _luongCoBan);//\\
    			}
            }
        }
    	public static String LuongCoBan_PropertyName { get { return "LuongCoBan"; } }
        private decimal _luongCoBan;
        partial void On_LuongCoBan_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_LuongCoBan_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string XepLoai
        {
            get
            {
                return _xepLoai;
            }
            set
            {
    			string oldValue =  _xepLoai;
    			bool stopChanging = false;
                On_XepLoai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("XepLoai");
    			if(!stopChanging)
    			{
    				_xepLoai = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("XepLoai");
    				On_XepLoai_Changed(oldValue, _xepLoai);//\\
    			}
            }
        }
    	public static String XepLoai_PropertyName { get { return "XepLoai"; } }
        private string _xepLoai;
        partial void On_XepLoai_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_XepLoai_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal ThuLaoGiangDay
        {
            get
            {
                return _thuLaoGiangDay;
            }
            set
            {
    			decimal oldValue =  _thuLaoGiangDay;
    			bool stopChanging = false;
                On_ThuLaoGiangDay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThuLaoGiangDay");
    			if(!stopChanging)
    			{
    				_thuLaoGiangDay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThuLaoGiangDay");
    				On_ThuLaoGiangDay_Changed(oldValue, _thuLaoGiangDay);//\\
    			}
            }
        }
    	public static String ThuLaoGiangDay_PropertyName { get { return "ThuLaoGiangDay"; } }
        private decimal _thuLaoGiangDay;
        partial void On_ThuLaoGiangDay_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_ThuLaoGiangDay_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal LuongNganSach
        {
            get
            {
                return _luongNganSach;
            }
            set
            {
    			decimal oldValue =  _luongNganSach;
    			bool stopChanging = false;
                On_LuongNganSach_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LuongNganSach");
    			if(!stopChanging)
    			{
    				_luongNganSach = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LuongNganSach");
    				On_LuongNganSach_Changed(oldValue, _luongNganSach);//\\
    			}
            }
        }
    	public static String LuongNganSach_PropertyName { get { return "LuongNganSach"; } }
        private decimal _luongNganSach;
        partial void On_LuongNganSach_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_LuongNganSach_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal PhuCap
        {
            get
            {
                return _phuCap;
            }
            set
            {
    			decimal oldValue =  _phuCap;
    			bool stopChanging = false;
                On_PhuCap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhuCap");
    			if(!stopChanging)
    			{
    				_phuCap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhuCap");
    				On_PhuCap_Changed(oldValue, _phuCap);//\\
    			}
            }
        }
    	public static String PhuCap_PropertyName { get { return "PhuCap"; } }
        private decimal _phuCap;
        partial void On_PhuCap_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_PhuCap_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal ThuNhapTangThem
        {
            get
            {
                return _thuNhapTangThem;
            }
            set
            {
    			decimal oldValue =  _thuNhapTangThem;
    			bool stopChanging = false;
                On_ThuNhapTangThem_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThuNhapTangThem");
    			if(!stopChanging)
    			{
    				_thuNhapTangThem = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThuNhapTangThem");
    				On_ThuNhapTangThem_Changed(oldValue, _thuNhapTangThem);//\\
    			}
            }
        }
    	public static String ThuNhapTangThem_PropertyName { get { return "ThuNhapTangThem"; } }
        private decimal _thuNhapTangThem;
        partial void On_ThuNhapTangThem_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_ThuNhapTangThem_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal ThuNhapKhac
        {
            get
            {
                return _thuNhapKhac;
            }
            set
            {
    			decimal oldValue =  _thuNhapKhac;
    			bool stopChanging = false;
                On_ThuNhapKhac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThuNhapKhac");
    			if(!stopChanging)
    			{
    				_thuNhapKhac = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThuNhapKhac");
    				On_ThuNhapKhac_Changed(oldValue, _thuNhapKhac);//\\
    			}
            }
        }
    	public static String ThuNhapKhac_PropertyName { get { return "ThuNhapKhac"; } }
        private decimal _thuNhapKhac;
        partial void On_ThuNhapKhac_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_ThuNhapKhac_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal NgoaiGio
        {
            get
            {
                return _ngoaiGio;
            }
            set
            {
    			decimal oldValue =  _ngoaiGio;
    			bool stopChanging = false;
                On_NgoaiGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgoaiGio");
    			if(!stopChanging)
    			{
    				_ngoaiGio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgoaiGio");
    				On_NgoaiGio_Changed(oldValue, _ngoaiGio);//\\
    			}
            }
        }
    	public static String NgoaiGio_PropertyName { get { return "NgoaiGio"; } }
        private decimal _ngoaiGio;
        partial void On_NgoaiGio_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_NgoaiGio_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal KhenThuong
        {
            get
            {
                return _khenThuong;
            }
            set
            {
    			decimal oldValue =  _khenThuong;
    			bool stopChanging = false;
                On_KhenThuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KhenThuong");
    			if(!stopChanging)
    			{
    				_khenThuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KhenThuong");
    				On_KhenThuong_Changed(oldValue, _khenThuong);//\\
    			}
            }
        }
    	public static String KhenThuong_PropertyName { get { return "KhenThuong"; } }
        private decimal _khenThuong;
        partial void On_KhenThuong_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_KhenThuong_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal KhauTruLuong
        {
            get
            {
                return _khauTruLuong;
            }
            set
            {
    			decimal oldValue =  _khauTruLuong;
    			bool stopChanging = false;
                On_KhauTruLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KhauTruLuong");
    			if(!stopChanging)
    			{
    				_khauTruLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KhauTruLuong");
    				On_KhauTruLuong_Changed(oldValue, _khauTruLuong);//\\
    			}
            }
        }
    	public static String KhauTruLuong_PropertyName { get { return "KhauTruLuong"; } }
        private decimal _khauTruLuong;
        partial void On_KhauTruLuong_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_KhauTruLuong_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal ThueTNCN
        {
            get
            {
                return _thueTNCN;
            }
            set
            {
    			decimal oldValue =  _thueTNCN;
    			bool stopChanging = false;
                On_ThueTNCN_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThueTNCN");
    			if(!stopChanging)
    			{
    				_thueTNCN = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThueTNCN");
    				On_ThueTNCN_Changed(oldValue, _thueTNCN);//\\
    			}
            }
        }
    	public static String ThueTNCN_PropertyName { get { return "ThueTNCN"; } }
        private decimal _thueTNCN;
        partial void On_ThueTNCN_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_ThueTNCN_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongThuNhap
        {
            get
            {
                return _tongThuNhap;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongThuNhap;
    			bool stopChanging = false;
                On_TongThuNhap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongThuNhap");
    			if(!stopChanging)
    			{
    				_tongThuNhap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongThuNhap");
    				On_TongThuNhap_Changed(oldValue, _tongThuNhap);//\\
    			}
            }
        }
    	public static String TongThuNhap_PropertyName { get { return "TongThuNhap"; } }
        private Nullable<decimal> _tongThuNhap;
        partial void On_TongThuNhap_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongThuNhap_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> ThucNhan
        {
            get
            {
                return _thucNhan;
            }
            set
            {
    			Nullable<decimal> oldValue =  _thucNhan;
    			bool stopChanging = false;
                On_ThucNhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThucNhan");
    			if(!stopChanging)
    			{
    				_thucNhan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThucNhan");
    				On_ThucNhan_Changed(oldValue, _thucNhan);//\\
    			}
            }
        }
    	public static String ThucNhan_PropertyName { get { return "ThucNhan"; } }
        private Nullable<decimal> _thucNhan;
        partial void On_ThucNhan_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_ThucNhan_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}