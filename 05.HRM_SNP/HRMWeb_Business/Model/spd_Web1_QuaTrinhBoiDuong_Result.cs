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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhBoiDuong_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhBoiDuong_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TuNgay
        {
            get
            {
                return _tuNgay;
            }
            set
            {
    			string oldValue =  _tuNgay;
    			bool stopChanging = false;
                On_TuNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNgay");
    			if(!stopChanging)
    			{
    				_tuNgay = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TuNgay");
    				On_TuNgay_Changed(oldValue, _tuNgay);//\\
    			}
            }
        }
    	public static String TuNgay_PropertyName { get { return "TuNgay"; } }
        private string _tuNgay;
        partial void On_TuNgay_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TuNgay_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DenNgay
        {
            get
            {
                return _denNgay;
            }
            set
            {
    			string oldValue =  _denNgay;
    			bool stopChanging = false;
                On_DenNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNgay");
    			if(!stopChanging)
    			{
    				_denNgay = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DenNgay");
    				On_DenNgay_Changed(oldValue, _denNgay);//\\
    			}
            }
        }
    	public static String DenNgay_PropertyName { get { return "DenNgay"; } }
        private string _denNgay;
        partial void On_DenNgay_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DenNgay_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiBoiDuong
        {
            get
            {
                return _noiBoiDuong;
            }
            set
            {
    			string oldValue =  _noiBoiDuong;
    			bool stopChanging = false;
                On_NoiBoiDuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiBoiDuong");
    			if(!stopChanging)
    			{
    				_noiBoiDuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiBoiDuong");
    				On_NoiBoiDuong_Changed(oldValue, _noiBoiDuong);//\\
    			}
            }
        }
    	public static String NoiBoiDuong_PropertyName { get { return "NoiBoiDuong"; } }
        private string _noiBoiDuong;
        partial void On_NoiBoiDuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiBoiDuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiDungBoiDuong
        {
            get
            {
                return _noiDungBoiDuong;
            }
            set
            {
    			string oldValue =  _noiDungBoiDuong;
    			bool stopChanging = false;
                On_NoiDungBoiDuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiDungBoiDuong");
    			if(!stopChanging)
    			{
    				_noiDungBoiDuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiDungBoiDuong");
    				On_NoiDungBoiDuong_Changed(oldValue, _noiDungBoiDuong);//\\
    			}
            }
        }
    	public static String NoiDungBoiDuong_PropertyName { get { return "NoiDungBoiDuong"; } }
        private string _noiDungBoiDuong;
        partial void On_NoiDungBoiDuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiDungBoiDuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChungChiDuocCap
        {
            get
            {
                return _chungChiDuocCap;
            }
            set
            {
    			string oldValue =  _chungChiDuocCap;
    			bool stopChanging = false;
                On_ChungChiDuocCap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChungChiDuocCap");
    			if(!stopChanging)
    			{
    				_chungChiDuocCap = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChungChiDuocCap");
    				On_ChungChiDuocCap_Changed(oldValue, _chungChiDuocCap);//\\
    			}
            }
        }
    	public static String ChungChiDuocCap_PropertyName { get { return "ChungChiDuocCap"; } }
        private string _chungChiDuocCap;
        partial void On_ChungChiDuocCap_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChungChiDuocCap_Changed(string oldValue, string currentValue);

    #endregion

    }
}
