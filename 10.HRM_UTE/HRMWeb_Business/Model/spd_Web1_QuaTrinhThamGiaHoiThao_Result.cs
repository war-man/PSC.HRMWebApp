//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi SERVERERP\tai luc 09:33:23 ngay 03/10/2017
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhThamGiaHoiThao_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhThamGiaHoiThao_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenHoiThao
        {
            get
            {
                return _tenHoiThao;
            }
            set
            {
    			string oldValue =  _tenHoiThao;
    			bool stopChanging = false;
                On_TenHoiThao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenHoiThao");
    			if(!stopChanging)
    			{
    				_tenHoiThao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenHoiThao");
    				On_TenHoiThao_Changed(oldValue, _tenHoiThao);//\\
    			}
            }
        }
    	public static String TenHoiThao_PropertyName { get { return "TenHoiThao"; } }
        private string _tenHoiThao;
        partial void On_TenHoiThao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenHoiThao_Changed(string oldValue, string currentValue);
    
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
        public string DiaDiem
        {
            get
            {
                return _diaDiem;
            }
            set
            {
    			string oldValue =  _diaDiem;
    			bool stopChanging = false;
                On_DiaDiem_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DiaDiem");
    			if(!stopChanging)
    			{
    				_diaDiem = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DiaDiem");
    				On_DiaDiem_Changed(oldValue, _diaDiem);//\\
    			}
            }
        }
    	public static String DiaDiem_PropertyName { get { return "DiaDiem"; } }
        private string _diaDiem;
        partial void On_DiaDiem_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DiaDiem_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuocGia
        {
            get
            {
                return _quocGia;
            }
            set
            {
    			string oldValue =  _quocGia;
    			bool stopChanging = false;
                On_QuocGia_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuocGia");
    			if(!stopChanging)
    			{
    				_quocGia = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuocGia");
    				On_QuocGia_Changed(oldValue, _quocGia);//\\
    			}
            }
        }
    	public static String QuocGia_PropertyName { get { return "QuocGia"; } }
        private string _quocGia;
        partial void On_QuocGia_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuocGia_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> CoBaiThamLuan
        {
            get
            {
                return _coBaiThamLuan;
            }
            set
            {
    			Nullable<bool> oldValue =  _coBaiThamLuan;
    			bool stopChanging = false;
                On_CoBaiThamLuan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CoBaiThamLuan");
    			if(!stopChanging)
    			{
    				_coBaiThamLuan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CoBaiThamLuan");
    				On_CoBaiThamLuan_Changed(oldValue, _coBaiThamLuan);//\\
    			}
            }
        }
    	public static String CoBaiThamLuan_PropertyName { get { return "CoBaiThamLuan"; } }
        private Nullable<bool> _coBaiThamLuan;
        partial void On_CoBaiThamLuan_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_CoBaiThamLuan_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);

    #endregion

    }
}
