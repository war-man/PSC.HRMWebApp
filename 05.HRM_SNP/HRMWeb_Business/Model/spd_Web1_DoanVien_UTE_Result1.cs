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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_DoanVien_UTE_Result1")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_DoanVien_UTE_Result1 : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ToChucDoan
        {
            get
            {
                return _toChucDoan;
            }
            set
            {
    			string oldValue =  _toChucDoan;
    			bool stopChanging = false;
                On_ToChucDoan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ToChucDoan");
    			if(!stopChanging)
    			{
    				_toChucDoan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ToChucDoan");
    				On_ToChucDoan_Changed(oldValue, _toChucDoan);//\\
    			}
            }
        }
    	public static String ToChucDoan_PropertyName { get { return "ToChucDoan"; } }
        private string _toChucDoan;
        partial void On_ToChucDoan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ToChucDoan_Changed(string oldValue, string currentValue);
    
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
        public string NgayCap
        {
            get
            {
                return _ngayCap;
            }
            set
            {
    			string oldValue =  _ngayCap;
    			bool stopChanging = false;
                On_NgayCap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayCap");
    			if(!stopChanging)
    			{
    				_ngayCap = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayCap");
    				On_NgayCap_Changed(oldValue, _ngayCap);//\\
    			}
            }
        }
    	public static String NgayCap_PropertyName { get { return "NgayCap"; } }
        private string _ngayCap;
        partial void On_NgayCap_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayCap_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgayKetNap
        {
            get
            {
                return _ngayKetNap;
            }
            set
            {
    			string oldValue =  _ngayKetNap;
    			bool stopChanging = false;
                On_NgayKetNap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayKetNap");
    			if(!stopChanging)
    			{
    				_ngayKetNap = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayKetNap");
    				On_NgayKetNap_Changed(oldValue, _ngayKetNap);//\\
    			}
            }
        }
    	public static String NgayKetNap_PropertyName { get { return "NgayKetNap"; } }
        private string _ngayKetNap;
        partial void On_NgayKetNap_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayKetNap_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> NoiKetNap
        {
            get
            {
                return _noiKetNap;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _noiKetNap;
    			bool stopChanging = false;
                On_NoiKetNap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiKetNap");
    			if(!stopChanging)
    			{
    				_noiKetNap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NoiKetNap");
    				On_NoiKetNap_Changed(oldValue, _noiKetNap);//\\
    			}
            }
        }
    	public static String NoiKetNap_PropertyName { get { return "NoiKetNap"; } }
        private Nullable<System.Guid> _noiKetNap;
        partial void On_NoiKetNap_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_NoiKetNap_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
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
