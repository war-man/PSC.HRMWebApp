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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhThamGiaHoatDongXaHoi_IUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhThamGiaHoatDongXaHoi_IUH_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TuNam
        {
            get
            {
                return _tuNam;
            }
            set
            {
    			string oldValue =  _tuNam;
    			bool stopChanging = false;
                On_TuNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNam");
    			if(!stopChanging)
    			{
    				_tuNam = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TuNam");
    				On_TuNam_Changed(oldValue, _tuNam);//\\
    			}
            }
        }
    	public static String TuNam_PropertyName { get { return "TuNam"; } }
        private string _tuNam;
        partial void On_TuNam_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TuNam_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DenNam
        {
            get
            {
                return _denNam;
            }
            set
            {
    			string oldValue =  _denNam;
    			bool stopChanging = false;
                On_DenNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNam");
    			if(!stopChanging)
    			{
    				_denNam = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DenNam");
    				On_DenNam_Changed(oldValue, _denNam);//\\
    			}
            }
        }
    	public static String DenNam_PropertyName { get { return "DenNam"; } }
        private string _denNam;
        partial void On_DenNam_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DenNam_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiDung
        {
            get
            {
                return _noiDung;
            }
            set
            {
    			string oldValue =  _noiDung;
    			bool stopChanging = false;
                On_NoiDung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiDung");
    			if(!stopChanging)
    			{
    				_noiDung = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiDung");
    				On_NoiDung_Changed(oldValue, _noiDung);//\\
    			}
            }
        }
    	public static String NoiDung_PropertyName { get { return "NoiDung"; } }
        private string _noiDung;
        partial void On_NoiDung_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiDung_Changed(string oldValue, string currentValue);

    #endregion

    }
}
