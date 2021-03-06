//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-O8ODB0C\thevi luc 09:44:27 ngay 17/09/2019
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_BangLuong_LuongTamUng_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_BangLuong_LuongTamUng_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_BangLuong_LuongTamUng_Result object.
        /// </summary>
        /// <param name="kTVayMuaNha">Initial value of the KTVayMuaNha property.</param>
        /// <param name="kTDienNuoc">Initial value of the KTDienNuoc property.</param>
        /// <param name="kTThuePhong">Initial value of the KTThuePhong property.</param>
        /// <param name="kTThueThuNhap">Initial value of the KTThueThuNhap property.</param>
        /// <param name="kTKhac">Initial value of the KTKhac property.</param>
        /// <param name="dPCD">Initial value of the DPCD property.</param>
        /// <param name="uH1NL">Initial value of the UH1NL property.</param>
        /// <param name="truyThu">Initial value of the TruyThu property.</param>
        /// <param name="ghiChu">Initial value of the GhiChu property.</param>
        public static spd_Web1_BangLuong_LuongTamUng_Result Createspd_Web1_BangLuong_LuongTamUng_Result(decimal kTVayMuaNha, decimal kTDienNuoc, decimal kTThuePhong, decimal kTThueThuNhap, decimal kTKhac, decimal dPCD, decimal uH1NL, decimal truyThu, string ghiChu)
        {
            spd_Web1_BangLuong_LuongTamUng_Result spd_Web1_BangLuong_LuongTamUng_Result = new spd_Web1_BangLuong_LuongTamUng_Result();
            spd_Web1_BangLuong_LuongTamUng_Result.KTVayMuaNha = kTVayMuaNha;
            spd_Web1_BangLuong_LuongTamUng_Result.KTDienNuoc = kTDienNuoc;
            spd_Web1_BangLuong_LuongTamUng_Result.KTThuePhong = kTThuePhong;
            spd_Web1_BangLuong_LuongTamUng_Result.KTThueThuNhap = kTThueThuNhap;
            spd_Web1_BangLuong_LuongTamUng_Result.KTKhac = kTKhac;
            spd_Web1_BangLuong_LuongTamUng_Result.DPCD = dPCD;
            spd_Web1_BangLuong_LuongTamUng_Result.UH1NL = uH1NL;
            spd_Web1_BangLuong_LuongTamUng_Result.TruyThu = truyThu;
            spd_Web1_BangLuong_LuongTamUng_Result.GhiChu = ghiChu;
            return spd_Web1_BangLuong_LuongTamUng_Result;
        }

        #endregion

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
        public Nullable<int> STTBoPhan
        {
            get
            {
                return _sTTBoPhan;
            }
            set
            {
    			Nullable<int> oldValue =  _sTTBoPhan;
    			bool stopChanging = false;
                On_STTBoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("STTBoPhan");
    			if(!stopChanging)
    			{
    				_sTTBoPhan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("STTBoPhan");
    				On_STTBoPhan_Changed(oldValue, _sTTBoPhan);//\\
    			}
            }
        }
    	public static String STTBoPhan_PropertyName { get { return "STTBoPhan"; } }
        private Nullable<int> _sTTBoPhan;
        partial void On_STTBoPhan_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_STTBoPhan_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenBoPhan
        {
            get
            {
                return _tenBoPhan;
            }
            set
            {
    			string oldValue =  _tenBoPhan;
    			bool stopChanging = false;
                On_TenBoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenBoPhan");
    			if(!stopChanging)
    			{
    				_tenBoPhan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenBoPhan");
    				On_TenBoPhan_Changed(oldValue, _tenBoPhan);//\\
    			}
            }
        }
    	public static String TenBoPhan_PropertyName { get { return "TenBoPhan"; } }
        private string _tenBoPhan;
        partial void On_TenBoPhan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenBoPhan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string STTLoaiNhanVien
        {
            get
            {
                return _sTTLoaiNhanVien;
            }
            set
            {
    			string oldValue =  _sTTLoaiNhanVien;
    			bool stopChanging = false;
                On_STTLoaiNhanVien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("STTLoaiNhanVien");
    			if(!stopChanging)
    			{
    				_sTTLoaiNhanVien = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("STTLoaiNhanVien");
    				On_STTLoaiNhanVien_Changed(oldValue, _sTTLoaiNhanVien);//\\
    			}
            }
        }
    	public static String STTLoaiNhanVien_PropertyName { get { return "STTLoaiNhanVien"; } }
        private string _sTTLoaiNhanVien;
        partial void On_STTLoaiNhanVien_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_STTLoaiNhanVien_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenLoaiNhanVien
        {
            get
            {
                return _tenLoaiNhanVien;
            }
            set
            {
    			string oldValue =  _tenLoaiNhanVien;
    			bool stopChanging = false;
                On_TenLoaiNhanVien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenLoaiNhanVien");
    			if(!stopChanging)
    			{
    				_tenLoaiNhanVien = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenLoaiNhanVien");
    				On_TenLoaiNhanVien_Changed(oldValue, _tenLoaiNhanVien);//\\
    			}
            }
        }
    	public static String TenLoaiNhanVien_PropertyName { get { return "TenLoaiNhanVien"; } }
        private string _tenLoaiNhanVien;
        partial void On_TenLoaiNhanVien_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenLoaiNhanVien_Changed(string oldValue, string currentValue);
    
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
        public Nullable<decimal> TienLCB
        {
            get
            {
                return _tienLCB;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tienLCB;
    			bool stopChanging = false;
                On_TienLCB_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TienLCB");
    			if(!stopChanging)
    			{
    				_tienLCB = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TienLCB");
    				On_TienLCB_Changed(oldValue, _tienLCB);//\\
    			}
            }
        }
    	public static String TienLCB_PropertyName { get { return "TienLCB"; } }
        private Nullable<decimal> _tienLCB;
        partial void On_TienLCB_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TienLCB_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TienPCCV
        {
            get
            {
                return _tienPCCV;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tienPCCV;
    			bool stopChanging = false;
                On_TienPCCV_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TienPCCV");
    			if(!stopChanging)
    			{
    				_tienPCCV = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TienPCCV");
    				On_TienPCCV_Changed(oldValue, _tienPCCV);//\\
    			}
            }
        }
    	public static String TienPCCV_PropertyName { get { return "TienPCCV"; } }
        private Nullable<decimal> _tienPCCV;
        partial void On_TienPCCV_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TienPCCV_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TienPCVK
        {
            get
            {
                return _tienPCVK;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tienPCVK;
    			bool stopChanging = false;
                On_TienPCVK_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TienPCVK");
    			if(!stopChanging)
    			{
    				_tienPCVK = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TienPCVK");
    				On_TienPCVK_Changed(oldValue, _tienPCVK);//\\
    			}
            }
        }
    	public static String TienPCVK_PropertyName { get { return "TienPCVK"; } }
        private Nullable<decimal> _tienPCVK;
        partial void On_TienPCVK_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TienPCVK_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
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
        public Nullable<decimal> PhuCapTienAn
        {
            get
            {
                return _phuCapTienAn;
            }
            set
            {
    			Nullable<decimal> oldValue =  _phuCapTienAn;
    			bool stopChanging = false;
                On_PhuCapTienAn_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhuCapTienAn");
    			if(!stopChanging)
    			{
    				_phuCapTienAn = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhuCapTienAn");
    				On_PhuCapTienAn_Changed(oldValue, _phuCapTienAn);//\\
    			}
            }
        }
    	public static String PhuCapTienAn_PropertyName { get { return "PhuCapTienAn"; } }
        private Nullable<decimal> _phuCapTienAn;
        partial void On_PhuCapTienAn_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_PhuCapTienAn_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal KTVayMuaNha
        {
            get
            {
                return _kTVayMuaNha;
            }
            set
            {
    			decimal oldValue =  _kTVayMuaNha;
    			bool stopChanging = false;
                On_KTVayMuaNha_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KTVayMuaNha");
    			if(!stopChanging)
    			{
    				_kTVayMuaNha = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KTVayMuaNha");
    				On_KTVayMuaNha_Changed(oldValue, _kTVayMuaNha);//\\
    			}
            }
        }
    	public static String KTVayMuaNha_PropertyName { get { return "KTVayMuaNha"; } }
        private decimal _kTVayMuaNha;
        partial void On_KTVayMuaNha_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_KTVayMuaNha_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal KTDienNuoc
        {
            get
            {
                return _kTDienNuoc;
            }
            set
            {
    			decimal oldValue =  _kTDienNuoc;
    			bool stopChanging = false;
                On_KTDienNuoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KTDienNuoc");
    			if(!stopChanging)
    			{
    				_kTDienNuoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KTDienNuoc");
    				On_KTDienNuoc_Changed(oldValue, _kTDienNuoc);//\\
    			}
            }
        }
    	public static String KTDienNuoc_PropertyName { get { return "KTDienNuoc"; } }
        private decimal _kTDienNuoc;
        partial void On_KTDienNuoc_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_KTDienNuoc_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal KTThuePhong
        {
            get
            {
                return _kTThuePhong;
            }
            set
            {
    			decimal oldValue =  _kTThuePhong;
    			bool stopChanging = false;
                On_KTThuePhong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KTThuePhong");
    			if(!stopChanging)
    			{
    				_kTThuePhong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KTThuePhong");
    				On_KTThuePhong_Changed(oldValue, _kTThuePhong);//\\
    			}
            }
        }
    	public static String KTThuePhong_PropertyName { get { return "KTThuePhong"; } }
        private decimal _kTThuePhong;
        partial void On_KTThuePhong_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_KTThuePhong_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal KTThueThuNhap
        {
            get
            {
                return _kTThueThuNhap;
            }
            set
            {
    			decimal oldValue =  _kTThueThuNhap;
    			bool stopChanging = false;
                On_KTThueThuNhap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KTThueThuNhap");
    			if(!stopChanging)
    			{
    				_kTThueThuNhap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KTThueThuNhap");
    				On_KTThueThuNhap_Changed(oldValue, _kTThueThuNhap);//\\
    			}
            }
        }
    	public static String KTThueThuNhap_PropertyName { get { return "KTThueThuNhap"; } }
        private decimal _kTThueThuNhap;
        partial void On_KTThueThuNhap_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_KTThueThuNhap_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal KTKhac
        {
            get
            {
                return _kTKhac;
            }
            set
            {
    			decimal oldValue =  _kTKhac;
    			bool stopChanging = false;
                On_KTKhac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KTKhac");
    			if(!stopChanging)
    			{
    				_kTKhac = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KTKhac");
    				On_KTKhac_Changed(oldValue, _kTKhac);//\\
    			}
            }
        }
    	public static String KTKhac_PropertyName { get { return "KTKhac"; } }
        private decimal _kTKhac;
        partial void On_KTKhac_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_KTKhac_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal DPCD
        {
            get
            {
                return _dPCD;
            }
            set
            {
    			decimal oldValue =  _dPCD;
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
        private decimal _dPCD;
        partial void On_DPCD_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_DPCD_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal UH1NL
        {
            get
            {
                return _uH1NL;
            }
            set
            {
    			decimal oldValue =  _uH1NL;
    			bool stopChanging = false;
                On_UH1NL_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("UH1NL");
    			if(!stopChanging)
    			{
    				_uH1NL = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("UH1NL");
    				On_UH1NL_Changed(oldValue, _uH1NL);//\\
    			}
            }
        }
    	public static String UH1NL_PropertyName { get { return "UH1NL"; } }
        private decimal _uH1NL;
        partial void On_UH1NL_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_UH1NL_Changed(decimal oldValue, decimal currentValue);
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal TruyThu
        {
            get
            {
                return _truyThu;
            }
            set
            {
    			decimal oldValue =  _truyThu;
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
        private decimal _truyThu;
        partial void On_TruyThu_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_TruyThu_Changed(decimal oldValue, decimal currentValue);
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }
            set
            {
    			string oldValue =  _ghiChu;
    			bool stopChanging = false;
                On_GhiChu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GhiChu");
    			if(!stopChanging)
    			{
    				_ghiChu = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("GhiChu");
    				On_GhiChu_Changed(oldValue, _ghiChu);//\\
    			}
            }
        }
    	public static String GhiChu_PropertyName { get { return "GhiChu"; } }
        private string _ghiChu;
        partial void On_GhiChu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_GhiChu_Changed(string oldValue, string currentValue);

    #endregion

    }
}
