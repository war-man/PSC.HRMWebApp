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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="WebUser_Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WebUser_Department : ERP_Core.BaseEntityObject//EntityObject
    {
    	static WebUser_Department()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public WebUser_Department()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new WebUser_Department object.
        /// </summary>
        /// <param name="iDWebUser">Initial value of the IDWebUser property.</param>
        /// <param name="departmentID">Initial value of the DepartmentID property.</param>
        public static WebUser_Department CreateWebUser_Department(System.Guid iDWebUser, System.Guid departmentID)
        {
            WebUser_Department webUser_Department = new WebUser_Department();
            webUser_Department.IDWebUser = iDWebUser;
            webUser_Department.DepartmentID = departmentID;
            return webUser_Department;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid IDWebUser
        {
            get
            {
                return _iDWebUser;
            }
            set
            {
                if (_iDWebUser != value)
                {
        			System.Guid oldValue =  _iDWebUser;
        			bool stopChanging = false;
                    On_IDWebUser_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("IDWebUser");
        			if(!stopChanging)
        			{
        				_iDWebUser = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("IDWebUser");
        				On_IDWebUser_Changed(oldValue, _iDWebUser);//\\
        			}
                }
            }
        }
    	public static String IDWebUser_PropertyName { get { return "IDWebUser"; } }
        private System.Guid _iDWebUser;
        partial void On_IDWebUser_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_IDWebUser_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid DepartmentID
        {
            get
            {
                return _departmentID;
            }
            set
            {
                if (_departmentID != value)
                {
        			System.Guid oldValue =  _departmentID;
        			bool stopChanging = false;
                    On_DepartmentID_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("DepartmentID");
        			if(!stopChanging)
        			{
        				_departmentID = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("DepartmentID");
        				On_DepartmentID_Changed(oldValue, _departmentID);//\\
        			}
                }
            }
        }
    	public static String DepartmentID_PropertyName { get { return "DepartmentID"; } }
        private System.Guid _departmentID;
        partial void On_DepartmentID_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_DepartmentID_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DienGiai
        {
            get
            {
                return _dienGiai;
            }
            set
            {
    			string oldValue =  _dienGiai;
    			bool stopChanging = false;
                On_DienGiai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DienGiai");
    			if(!stopChanging)
    			{
    				_dienGiai = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DienGiai");
    				On_DienGiai_Changed(oldValue, _dienGiai);//\\
    			}
            }
        }
    	public static String DienGiai_PropertyName { get { return "DienGiai"; } }
        private string _dienGiai;
        partial void On_DienGiai_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DienGiai_Changed(string oldValue, string currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebUser_Department_Department", "Department")]
        public Department Department
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("ERPModel.FK_WebUser_Department_Department", "Department").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_Department_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("ERPModel.FK_WebUser_Department_Department", "Department").Value = value;
    				On_Department_Changed(this.Department);//\\//
    			}
    	    }
        }
    	public static String Department_ReferencePropertyName { get { return "Department"; } }
    	partial void On_Department_Changing(ref Department newValue, ref bool stopChanging);
    	partial void On_Department_Changed(Department currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("ERPModel.FK_WebUser_Department_Department", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("ERPModel.FK_WebUser_Department_Department", "Department", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebUser_Department_WebUsers", "WebUser")]
        public WebUser WebUser
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebUser>("ERPModel.FK_WebUser_Department_WebUsers", "WebUser").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_WebUser_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebUser>("ERPModel.FK_WebUser_Department_WebUsers", "WebUser").Value = value;
    				On_WebUser_Changed(this.WebUser);//\\//
    			}
    	    }
        }
    	public static String WebUser_ReferencePropertyName { get { return "WebUser"; } }
    	partial void On_WebUser_Changing(ref WebUser newValue, ref bool stopChanging);
    	partial void On_WebUser_Changed(WebUser currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<WebUser> WebUserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebUser>("ERPModel.FK_WebUser_Department_WebUsers", "WebUser");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WebUser>("ERPModel.FK_WebUser_Department_WebUsers", "WebUser", value);
                }
            }
        }

        #endregion

    }
}
