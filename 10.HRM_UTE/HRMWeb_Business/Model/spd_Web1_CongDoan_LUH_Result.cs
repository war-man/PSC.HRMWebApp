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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_CongDoan_LUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_CongDoan_LUH_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ToChucCongDoan
        {
            get
            {
                return _toChucCongDoan;
            }
            set
            {
    			string oldValue =  _toChucCongDoan;
    			bool stopChanging = false;
                On_ToChucCongDoan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ToChucCongDoan");
    			if(!stopChanging)
    			{
    				_toChucCongDoan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ToChucCongDoan");
    				On_ToChucCongDoan_Changed(oldValue, _toChucCongDoan);//\\
    			}
            }
        }
    	public static String ToChucCongDoan_PropertyName { get { return "ToChucCongDoan"; } }
        private string _toChucCongDoan;
        partial void On_ToChucCongDoan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ToChucCongDoan_Changed(string oldValue, string currentValue);
    
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
        public string SoThe
        {
            get
            {
                return _soThe;
            }
            set
            {
    			string oldValue =  _soThe;
    			bool stopChanging = false;
                On_SoThe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoThe");
    			if(!stopChanging)
    			{
    				_soThe = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoThe");
    				On_SoThe_Changed(oldValue, _soThe);//\\
    			}
            }
        }
    	public static String SoThe_PropertyName { get { return "SoThe"; } }
        private string _soThe;
        partial void On_SoThe_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoThe_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChucVu
        {
            get
            {
                return _chucVu;
            }
            set
            {
    			string oldValue =  _chucVu;
    			bool stopChanging = false;
                On_ChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChucVu");
    			if(!stopChanging)
    			{
    				_chucVu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChucVu");
    				On_ChucVu_Changed(oldValue, _chucVu);//\\
    			}
            }
        }
    	public static String ChucVu_PropertyName { get { return "ChucVu"; } }
        private string _chucVu;
        partial void On_ChucVu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChucVu_Changed(string oldValue, string currentValue);

    #endregion

    }
}
