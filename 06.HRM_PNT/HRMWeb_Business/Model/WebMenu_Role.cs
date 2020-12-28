//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 03:34:42 ngay 05/01/2017
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="WebMenu_Role")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WebMenu_Role : ERP_Core.BaseEntityObject//EntityObject
    {
    	static WebMenu_Role()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public WebMenu_Role()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new WebMenu_Role object.
        /// </summary>
        /// <param name="webMenuID">Initial value of the WebMenuID property.</param>
        /// <param name="webGroupID">Initial value of the WebGroupID property.</param>
        public static WebMenu_Role CreateWebMenu_Role(System.Guid webMenuID, System.Guid webGroupID)
        {
            WebMenu_Role webMenu_Role = new WebMenu_Role();
            webMenu_Role.WebMenuID = webMenuID;
            webMenu_Role.WebGroupID = webGroupID;
            return webMenu_Role;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid WebMenuID
        {
            get
            {
                return _webMenuID;
            }
            set
            {
                if (_webMenuID != value)
                {
        			System.Guid oldValue =  _webMenuID;
        			bool stopChanging = false;
                    On_WebMenuID_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("WebMenuID");
        			if(!stopChanging)
        			{
        				_webMenuID = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("WebMenuID");
        				On_WebMenuID_Changed(oldValue, _webMenuID);//\\
        			}
                }
            }
        }
    	public static String WebMenuID_PropertyName { get { return "WebMenuID"; } }
        private System.Guid _webMenuID;
        partial void On_WebMenuID_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_WebMenuID_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid WebGroupID
        {
            get
            {
                return _webGroupID;
            }
            set
            {
                if (_webGroupID != value)
                {
        			System.Guid oldValue =  _webGroupID;
        			bool stopChanging = false;
                    On_WebGroupID_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("WebGroupID");
        			if(!stopChanging)
        			{
        				_webGroupID = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("WebGroupID");
        				On_WebGroupID_Changed(oldValue, _webGroupID);//\\
        			}
                }
            }
        }
    	public static String WebGroupID_PropertyName { get { return "WebGroupID"; } }
        private System.Guid _webGroupID;
        partial void On_WebGroupID_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_WebGroupID_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
    			string oldValue =  _description;
    			bool stopChanging = false;
                On_Description_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Description");
    			if(!stopChanging)
    			{
    				_description = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("Description");
    				On_Description_Changed(oldValue, _description);//\\
    			}
            }
        }
    	public static String Description_PropertyName { get { return "Description"; } }
        private string _description;
        partial void On_Description_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_Description_Changed(string oldValue, string currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebMenu_Role_webRole", "WebGroup")]
        public WebGroup WebGroup
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebGroup>("ERPModel.FK_WebMenu_Role_webRole", "WebGroup").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_WebGroup_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebGroup>("ERPModel.FK_WebMenu_Role_webRole", "WebGroup").Value = value;
    				On_WebGroup_Changed(this.WebGroup);//\\//
    			}
    	    }
        }
    	public static String WebGroup_ReferencePropertyName { get { return "WebGroup"; } }
    	partial void On_WebGroup_Changing(ref WebGroup newValue, ref bool stopChanging);
    	partial void On_WebGroup_Changed(WebGroup currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<WebGroup> WebGroupReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebGroup>("ERPModel.FK_WebMenu_Role_webRole", "WebGroup");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WebGroup>("ERPModel.FK_WebMenu_Role_webRole", "WebGroup", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebMenu_Role_WebMenu1", "WebMenu")]
        public WebMenu WebMenu
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebMenu>("ERPModel.FK_WebMenu_Role_WebMenu1", "WebMenu").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_WebMenu_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebMenu>("ERPModel.FK_WebMenu_Role_WebMenu1", "WebMenu").Value = value;
    				On_WebMenu_Changed(this.WebMenu);//\\//
    			}
    	    }
        }
    	public static String WebMenu_ReferencePropertyName { get { return "WebMenu"; } }
    	partial void On_WebMenu_Changing(ref WebMenu newValue, ref bool stopChanging);
    	partial void On_WebMenu_Changed(WebMenu currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<WebMenu> WebMenuReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebMenu>("ERPModel.FK_WebMenu_Role_WebMenu1", "WebMenu");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WebMenu>("ERPModel.FK_WebMenu_Role_WebMenu1", "WebMenu", value);
                }
            }
        }

        #endregion

    }
}
