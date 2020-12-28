//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi SERVERERP\tai luc 05:27:29 ngay 19/04/2017
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="WebMenu")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WebMenu : ERP_Core.BaseEntityObject//EntityObject
    {
    	static WebMenu()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public WebMenu()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new WebMenu object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static WebMenu CreateWebMenu(System.Guid oid)
        {
            WebMenu webMenu = new WebMenu();
            webMenu.Oid = oid;
            return webMenu;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid Oid
        {
            get
            {
                return _oid;
            }
            set
            {
                if (_oid != value)
                {
        			System.Guid oldValue =  _oid;
        			bool stopChanging = false;
                    On_Oid_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("Oid");
        			if(!stopChanging)
        			{
        				_oid = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("Oid");
        				On_Oid_Changed(oldValue, _oid);//\\
        			}
                }
            }
        }
    	public static String Oid_PropertyName { get { return "Oid"; } }
        private System.Guid _oid;
        partial void On_Oid_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_Oid_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
    			string oldValue =  _name;
    			bool stopChanging = false;
                On_Name_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Name");
    			if(!stopChanging)
    			{
    				_name = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("Name");
    				On_Name_Changed(oldValue, _name);//\\
    			}
            }
        }
    	public static String Name_PropertyName { get { return "Name"; } }
        private string _name;
        partial void On_Name_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_Name_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
    			string oldValue =  _url;
    			bool stopChanging = false;
                On_Url_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Url");
    			if(!stopChanging)
    			{
    				_url = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("Url");
    				On_Url_Changed(oldValue, _url);//\\
    			}
            }
        }
    	public static String Url_PropertyName { get { return "Url"; } }
        private string _url;
        partial void On_Url_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_Url_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ParentId
        {
            get
            {
                return _parentId;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _parentId;
    			bool stopChanging = false;
                On_ParentId_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ParentId");
    			if(!stopChanging)
    			{
    				_parentId = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ParentId");
    				On_ParentId_Changed(oldValue, _parentId);//\\
    			}
            }
        }
    	public static String ParentId_PropertyName { get { return "ParentId"; } }
        private Nullable<System.Guid> _parentId;
        partial void On_ParentId_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ParentId_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> Global_idx
        {
            get
            {
                return _global_idx;
            }
            set
            {
    			Nullable<int> oldValue =  _global_idx;
    			bool stopChanging = false;
                On_Global_idx_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Global_idx");
    			if(!stopChanging)
    			{
    				_global_idx = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Global_idx");
    				On_Global_idx_Changed(oldValue, _global_idx);//\\
    			}
            }
        }
    	public static String Global_idx_PropertyName { get { return "Global_idx"; } }
        private Nullable<int> _global_idx;
        partial void On_Global_idx_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_Global_idx_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> Local_idx
        {
            get
            {
                return _local_idx;
            }
            set
            {
    			Nullable<int> oldValue =  _local_idx;
    			bool stopChanging = false;
                On_Local_idx_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Local_idx");
    			if(!stopChanging)
    			{
    				_local_idx = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Local_idx");
    				On_Local_idx_Changed(oldValue, _local_idx);//\\
    			}
            }
        }
    	public static String Local_idx_PropertyName { get { return "Local_idx"; } }
        private Nullable<int> _local_idx;
        partial void On_Local_idx_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_Local_idx_Changed(Nullable<int> oldValue, Nullable<int> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebMenu_Role_WebMenu1", "WebMenu_Role")]
        public EntityCollection<WebMenu_Role> WebMenu_Role
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<WebMenu_Role>("ERPModel.FK_WebMenu_Role_WebMenu1", "WebMenu_Role");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_WebMenu_Role_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<WebMenu_Role>("ERPModel.FK_WebMenu_Role_WebMenu1", "WebMenu_Role", value);
    					On_WebMenu_Role_Changed(this.WebMenu_Role);//\\//
    				}
    			}
            }
        }
    	public static String WebMenu_Role_EntityCollectionPropertyName { get { return "WebMenu_Role"; } }
    	partial void On_WebMenu_Role_Changing(ref EntityCollection<WebMenu_Role> newValue, ref bool stopChanging);
    	partial void On_WebMenu_Role_Changed(EntityCollection<WebMenu_Role> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebMenu_WebMenu", "WebMenu1")]
        public EntityCollection<WebMenu> WebMenu1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<WebMenu>("ERPModel.FK_WebMenu_WebMenu", "WebMenu1");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_WebMenu1_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<WebMenu>("ERPModel.FK_WebMenu_WebMenu", "WebMenu1", value);
    					On_WebMenu1_Changed(this.WebMenu1);//\\//
    				}
    			}
            }
        }
    	public static String WebMenu1_EntityCollectionPropertyName { get { return "WebMenu1"; } }
    	partial void On_WebMenu1_Changing(ref EntityCollection<WebMenu> newValue, ref bool stopChanging);
    	partial void On_WebMenu1_Changed(EntityCollection<WebMenu> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebMenu_WebMenu", "WebMenu")]
        public WebMenu WebMenu2
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebMenu>("ERPModel.FK_WebMenu_WebMenu", "WebMenu").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_WebMenu2_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebMenu>("ERPModel.FK_WebMenu_WebMenu", "WebMenu").Value = value;
    				On_WebMenu2_Changed(this.WebMenu2);//\\//
    			}
    	    }
        }
    	public static String WebMenu2_ReferencePropertyName { get { return "WebMenu2"; } }
    	partial void On_WebMenu2_Changing(ref WebMenu newValue, ref bool stopChanging);
    	partial void On_WebMenu2_Changed(WebMenu currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<WebMenu> WebMenu2Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebMenu>("ERPModel.FK_WebMenu_WebMenu", "WebMenu");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WebMenu>("ERPModel.FK_WebMenu_WebMenu", "WebMenu", value);
                }
            }
        }

        #endregion

    }
}
