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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_TaiKhoanNganHang_UTE_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_TaiKhoanNganHang_UTE_Result : ComplexObject
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
        public string NganHang
        {
            get
            {
                return _nganHang;
            }
            set
            {
    			string oldValue =  _nganHang;
    			bool stopChanging = false;
                On_NganHang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NganHang");
    			if(!stopChanging)
    			{
    				_nganHang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NganHang");
    				On_NganHang_Changed(oldValue, _nganHang);//\\
    			}
            }
        }
    	public static String NganHang_PropertyName { get { return "NganHang"; } }
        private string _nganHang;
        partial void On_NganHang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NganHang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> TaiKhoanChinh
        {
            get
            {
                return _taiKhoanChinh;
            }
            set
            {
    			Nullable<bool> oldValue =  _taiKhoanChinh;
    			bool stopChanging = false;
                On_TaiKhoanChinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TaiKhoanChinh");
    			if(!stopChanging)
    			{
    				_taiKhoanChinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TaiKhoanChinh");
    				On_TaiKhoanChinh_Changed(oldValue, _taiKhoanChinh);//\\
    			}
            }
        }
    	public static String TaiKhoanChinh_PropertyName { get { return "TaiKhoanChinh"; } }
        private Nullable<bool> _taiKhoanChinh;
        partial void On_TaiKhoanChinh_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_TaiKhoanChinh_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);

    #endregion

    }
}
