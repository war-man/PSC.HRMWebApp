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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_GiayChungNhan_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_GiayChungNhan_Result : ComplexObject
    {
    #region Primitive Properties
    
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
        public Nullable<System.DateTime> NgaySinh
        {
            get
            {
                return _ngaySinh;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngaySinh;
    			bool stopChanging = false;
                On_NgaySinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgaySinh");
    			if(!stopChanging)
    			{
    				_ngaySinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgaySinh");
    				On_NgaySinh_Changed(oldValue, _ngaySinh);//\\
    			}
            }
        }
    	public static String NgaySinh_PropertyName { get { return "NgaySinh"; } }
        private Nullable<System.DateTime> _ngaySinh;
        partial void On_NgaySinh_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgaySinh_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DiaChiThuongTru
        {
            get
            {
                return _diaChiThuongTru;
            }
            set
            {
    			string oldValue =  _diaChiThuongTru;
    			bool stopChanging = false;
                On_DiaChiThuongTru_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DiaChiThuongTru");
    			if(!stopChanging)
    			{
    				_diaChiThuongTru = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DiaChiThuongTru");
    				On_DiaChiThuongTru_Changed(oldValue, _diaChiThuongTru);//\\
    			}
            }
        }
    	public static String DiaChiThuongTru_PropertyName { get { return "DiaChiThuongTru"; } }
        private string _diaChiThuongTru;
        partial void On_DiaChiThuongTru_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DiaChiThuongTru_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiSinh
        {
            get
            {
                return _noiSinh;
            }
            set
            {
    			string oldValue =  _noiSinh;
    			bool stopChanging = false;
                On_NoiSinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiSinh");
    			if(!stopChanging)
    			{
    				_noiSinh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiSinh");
    				On_NoiSinh_Changed(oldValue, _noiSinh);//\\
    			}
            }
        }
    	public static String NoiSinh_PropertyName { get { return "NoiSinh"; } }
        private string _noiSinh;
        partial void On_NoiSinh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiSinh_Changed(string oldValue, string currentValue);
    
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
        public string TenChucDanh
        {
            get
            {
                return _tenChucDanh;
            }
            set
            {
    			string oldValue =  _tenChucDanh;
    			bool stopChanging = false;
                On_TenChucDanh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenChucDanh");
    			if(!stopChanging)
    			{
    				_tenChucDanh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenChucDanh");
    				On_TenChucDanh_Changed(oldValue, _tenChucDanh);//\\
    			}
            }
        }
    	public static String TenChucDanh_PropertyName { get { return "TenChucDanh"; } }
        private string _tenChucDanh;
        partial void On_TenChucDanh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenChucDanh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
    				_ngachLuong = StructuralObject.SetValidValue(value, true);
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

    #endregion

    }
}
