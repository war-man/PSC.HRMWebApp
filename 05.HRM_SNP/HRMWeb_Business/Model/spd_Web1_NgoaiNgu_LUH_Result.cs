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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_NgoaiNgu_LUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_NgoaiNgu_LUH_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenNgoaiNgu
        {
            get
            {
                return _tenNgoaiNgu;
            }
            set
            {
    			string oldValue =  _tenNgoaiNgu;
    			bool stopChanging = false;
                On_TenNgoaiNgu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenNgoaiNgu");
    			if(!stopChanging)
    			{
    				_tenNgoaiNgu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenNgoaiNgu");
    				On_TenNgoaiNgu_Changed(oldValue, _tenNgoaiNgu);//\\
    			}
            }
        }
    	public static String TenNgoaiNgu_PropertyName { get { return "TenNgoaiNgu"; } }
        private string _tenNgoaiNgu;
        partial void On_TenNgoaiNgu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenNgoaiNgu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TrinhDo
        {
            get
            {
                return _trinhDo;
            }
            set
            {
    			string oldValue =  _trinhDo;
    			bool stopChanging = false;
                On_TrinhDo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TrinhDo");
    			if(!stopChanging)
    			{
    				_trinhDo = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TrinhDo");
    				On_TrinhDo_Changed(oldValue, _trinhDo);//\\
    			}
            }
        }
    	public static String TrinhDo_PropertyName { get { return "TrinhDo"; } }
        private string _trinhDo;
        partial void On_TrinhDo_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TrinhDo_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> Diem
        {
            get
            {
                return _diem;
            }
            set
            {
    			Nullable<decimal> oldValue =  _diem;
    			bool stopChanging = false;
                On_Diem_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Diem");
    			if(!stopChanging)
    			{
    				_diem = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Diem");
    				On_Diem_Changed(oldValue, _diem);//\\
    			}
            }
        }
    	public static String Diem_PropertyName { get { return "Diem"; } }
        private Nullable<decimal> _diem;
        partial void On_Diem_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_Diem_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
