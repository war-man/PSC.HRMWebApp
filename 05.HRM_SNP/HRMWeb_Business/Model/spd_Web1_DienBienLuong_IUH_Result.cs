//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 05:03:08 ngay 23/05/2017
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_DienBienLuong_IUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_DienBienLuong_IUH_Result : ComplexObject
    {
    #region Primitive Properties
    
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
        public Nullable<int> VuotKhung
        {
            get
            {
                return _vuotKhung;
            }
            set
            {
    			Nullable<int> oldValue =  _vuotKhung;
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
        private Nullable<int> _vuotKhung;
        partial void On_VuotKhung_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_VuotKhung_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
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
        public Nullable<decimal> HSPCKhac
        {
            get
            {
                return _hSPCKhac;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCKhac;
    			bool stopChanging = false;
                On_HSPCKhac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCKhac");
    			if(!stopChanging)
    			{
    				_hSPCKhac = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCKhac");
    				On_HSPCKhac_Changed(oldValue, _hSPCKhac);//\\
    			}
            }
        }
    	public static String HSPCKhac_PropertyName { get { return "HSPCKhac"; } }
        private Nullable<decimal> _hSPCKhac;
        partial void On_HSPCKhac_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCKhac_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
