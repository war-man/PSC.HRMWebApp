//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 04:17:17 ngay 30/08/2016
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhKyLuat_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhKyLuat_Result : ComplexObject
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
        public string HinhThucKyLuat
        {
            get
            {
                return _hinhThucKyLuat;
            }
            set
            {
    			string oldValue =  _hinhThucKyLuat;
    			bool stopChanging = false;
                On_HinhThucKyLuat_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HinhThucKyLuat");
    			if(!stopChanging)
    			{
    				_hinhThucKyLuat = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HinhThucKyLuat");
    				On_HinhThucKyLuat_Changed(oldValue, _hinhThucKyLuat);//\\
    			}
            }
        }
    	public static String HinhThucKyLuat_PropertyName { get { return "HinhThucKyLuat"; } }
        private string _hinhThucKyLuat;
        partial void On_HinhThucKyLuat_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HinhThucKyLuat_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoQuyetDinh
        {
            get
            {
                return _soQuyetDinh;
            }
            set
            {
    			string oldValue =  _soQuyetDinh;
    			bool stopChanging = false;
                On_SoQuyetDinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoQuyetDinh");
    			if(!stopChanging)
    			{
    				_soQuyetDinh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoQuyetDinh");
    				On_SoQuyetDinh_Changed(oldValue, _soQuyetDinh);//\\
    			}
            }
        }
    	public static String SoQuyetDinh_PropertyName { get { return "SoQuyetDinh"; } }
        private string _soQuyetDinh;
        partial void On_SoQuyetDinh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoQuyetDinh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string LyDo
        {
            get
            {
                return _lyDo;
            }
            set
            {
    			string oldValue =  _lyDo;
    			bool stopChanging = false;
                On_LyDo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LyDo");
    			if(!stopChanging)
    			{
    				_lyDo = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LyDo");
    				On_LyDo_Changed(oldValue, _lyDo);//\\
    			}
            }
        }
    	public static String LyDo_PropertyName { get { return "LyDo"; } }
        private string _lyDo;
        partial void On_LyDo_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LyDo_Changed(string oldValue, string currentValue);

    #endregion

    }
}
