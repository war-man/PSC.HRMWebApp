//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 01:49:02 ngay 20/01/2017
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_HopDong_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_HopDong_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_HopDong_Result object.
        /// </summary>
        /// <param name="mucLuongDuocHuong">Initial value of the MucLuongDuocHuong property.</param>
        public static spd_Web1_HopDong_Result Createspd_Web1_HopDong_Result(string mucLuongDuocHuong)
        {
            spd_Web1_HopDong_Result spd_Web1_HopDong_Result = new spd_Web1_HopDong_Result();
            spd_Web1_HopDong_Result.MucLuongDuocHuong = mucLuongDuocHuong;
            return spd_Web1_HopDong_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoHopDong
        {
            get
            {
                return _soHopDong;
            }
            set
            {
    			string oldValue =  _soHopDong;
    			bool stopChanging = false;
                On_SoHopDong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoHopDong");
    			if(!stopChanging)
    			{
    				_soHopDong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoHopDong");
    				On_SoHopDong_Changed(oldValue, _soHopDong);//\\
    			}
            }
        }
    	public static String SoHopDong_PropertyName { get { return "SoHopDong"; } }
        private string _soHopDong;
        partial void On_SoHopDong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoHopDong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string LoaiHopDong
        {
            get
            {
                return _loaiHopDong;
            }
            set
            {
    			string oldValue =  _loaiHopDong;
    			bool stopChanging = false;
                On_LoaiHopDong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LoaiHopDong");
    			if(!stopChanging)
    			{
    				_loaiHopDong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LoaiHopDong");
    				On_LoaiHopDong_Changed(oldValue, _loaiHopDong);//\\
    			}
            }
        }
    	public static String LoaiHopDong_PropertyName { get { return "LoaiHopDong"; } }
        private string _loaiHopDong;
        partial void On_LoaiHopDong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LoaiHopDong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayKy
        {
            get
            {
                return _ngayKy;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayKy;
    			bool stopChanging = false;
                On_NgayKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayKy");
    			if(!stopChanging)
    			{
    				_ngayKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayKy");
    				On_NgayKy_Changed(oldValue, _ngayKy);//\\
    			}
            }
        }
    	public static String NgayKy_PropertyName { get { return "NgayKy"; } }
        private Nullable<System.DateTime> _ngayKy;
        partial void On_NgayKy_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayKy_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChucVuNguoiKy
        {
            get
            {
                return _chucVuNguoiKy;
            }
            set
            {
    			string oldValue =  _chucVuNguoiKy;
    			bool stopChanging = false;
                On_ChucVuNguoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChucVuNguoiKy");
    			if(!stopChanging)
    			{
    				_chucVuNguoiKy = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChucVuNguoiKy");
    				On_ChucVuNguoiKy_Changed(oldValue, _chucVuNguoiKy);//\\
    			}
            }
        }
    	public static String ChucVuNguoiKy_PropertyName { get { return "ChucVuNguoiKy"; } }
        private string _chucVuNguoiKy;
        partial void On_ChucVuNguoiKy_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChucVuNguoiKy_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NguoiKy
        {
            get
            {
                return _nguoiKy;
            }
            set
            {
    			string oldValue =  _nguoiKy;
    			bool stopChanging = false;
                On_NguoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NguoiKy");
    			if(!stopChanging)
    			{
    				_nguoiKy = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NguoiKy");
    				On_NguoiKy_Changed(oldValue, _nguoiKy);//\\
    			}
            }
        }
    	public static String NguoiKy_PropertyName { get { return "NguoiKy"; } }
        private string _nguoiKy;
        partial void On_NguoiKy_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NguoiKy_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> TuNgay
        {
            get
            {
                return _tuNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _tuNgay;
    			bool stopChanging = false;
                On_TuNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNgay");
    			if(!stopChanging)
    			{
    				_tuNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TuNgay");
    				On_TuNgay_Changed(oldValue, _tuNgay);//\\
    			}
            }
        }
    	public static String TuNgay_PropertyName { get { return "TuNgay"; } }
        private Nullable<System.DateTime> _tuNgay;
        partial void On_TuNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_TuNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> DenNgay
        {
            get
            {
                return _denNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _denNgay;
    			bool stopChanging = false;
                On_DenNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNgay");
    			if(!stopChanging)
    			{
    				_denNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DenNgay");
    				On_DenNgay_Changed(oldValue, _denNgay);//\\
    			}
            }
        }
    	public static String DenNgay_PropertyName { get { return "DenNgay"; } }
        private Nullable<System.DateTime> _denNgay;
        partial void On_DenNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_DenNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string MucLuongDuocHuong
        {
            get
            {
                return _mucLuongDuocHuong;
            }
            set
            {
    			string oldValue =  _mucLuongDuocHuong;
    			bool stopChanging = false;
                On_MucLuongDuocHuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MucLuongDuocHuong");
    			if(!stopChanging)
    			{
    				_mucLuongDuocHuong = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("MucLuongDuocHuong");
    				On_MucLuongDuocHuong_Changed(oldValue, _mucLuongDuocHuong);//\\
    			}
            }
        }
    	public static String MucLuongDuocHuong_PropertyName { get { return "MucLuongDuocHuong"; } }
        private string _mucLuongDuocHuong;
        partial void On_MucLuongDuocHuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_MucLuongDuocHuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChucDanhChuyenMon
        {
            get
            {
                return _chucDanhChuyenMon;
            }
            set
            {
    			string oldValue =  _chucDanhChuyenMon;
    			bool stopChanging = false;
                On_ChucDanhChuyenMon_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChucDanhChuyenMon");
    			if(!stopChanging)
    			{
    				_chucDanhChuyenMon = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChucDanhChuyenMon");
    				On_ChucDanhChuyenMon_Changed(oldValue, _chucDanhChuyenMon);//\\
    			}
            }
        }
    	public static String ChucDanhChuyenMon_PropertyName { get { return "ChucDanhChuyenMon"; } }
        private string _chucDanhChuyenMon;
        partial void On_ChucDanhChuyenMon_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChucDanhChuyenMon_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string MaNgachLuong
        {
            get
            {
                return _maNgachLuong;
            }
            set
            {
    			string oldValue =  _maNgachLuong;
    			bool stopChanging = false;
                On_MaNgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MaNgachLuong");
    			if(!stopChanging)
    			{
    				_maNgachLuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("MaNgachLuong");
    				On_MaNgachLuong_Changed(oldValue, _maNgachLuong);//\\
    			}
            }
        }
    	public static String MaNgachLuong_PropertyName { get { return "MaNgachLuong"; } }
        private string _maNgachLuong;
        partial void On_MaNgachLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_MaNgachLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenNgachLuong
        {
            get
            {
                return _tenNgachLuong;
            }
            set
            {
    			string oldValue =  _tenNgachLuong;
    			bool stopChanging = false;
                On_TenNgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenNgachLuong");
    			if(!stopChanging)
    			{
    				_tenNgachLuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenNgachLuong");
    				On_TenNgachLuong_Changed(oldValue, _tenNgachLuong);//\\
    			}
            }
        }
    	public static String TenNgachLuong_PropertyName { get { return "TenNgachLuong"; } }
        private string _tenNgachLuong;
        partial void On_TenNgachLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenNgachLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
    				_bacLuong = StructuralObject.SetValidValue(value, true);
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

    #endregion

    }
}
