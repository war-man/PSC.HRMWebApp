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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="WebUser_BoPhan")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WebUser_BoPhan : ERP_Core.BaseEntityObject//EntityObject
    {
    	static WebUser_BoPhan()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public WebUser_BoPhan()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new WebUser_BoPhan object.
        /// </summary>
        /// <param name="iDWebUser">Initial value of the IDWebUser property.</param>
        /// <param name="boPhanID">Initial value of the BoPhanID property.</param>
        public static WebUser_BoPhan CreateWebUser_BoPhan(System.Guid iDWebUser, System.Guid boPhanID)
        {
            WebUser_BoPhan webUser_BoPhan = new WebUser_BoPhan();
            webUser_BoPhan.IDWebUser = iDWebUser;
            webUser_BoPhan.BoPhanID = boPhanID;
            return webUser_BoPhan;
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
        public System.Guid BoPhanID
        {
            get
            {
                return _boPhanID;
            }
            set
            {
                if (_boPhanID != value)
                {
        			System.Guid oldValue =  _boPhanID;
        			bool stopChanging = false;
                    On_BoPhanID_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("BoPhanID");
        			if(!stopChanging)
        			{
        				_boPhanID = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("BoPhanID");
        				On_BoPhanID_Changed(oldValue, _boPhanID);//\\
        			}
                }
            }
        }
    	public static String BoPhanID_PropertyName { get { return "BoPhanID"; } }
        private System.Guid _boPhanID;
        partial void On_BoPhanID_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_BoPhanID_Changed(System.Guid oldValue, System.Guid currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebUser_BoPhan_BoPhan", "BoPhan")]
        public BoPhan BoPhan
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_WebUser_BoPhan_BoPhan", "BoPhan").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_BoPhan_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_WebUser_BoPhan_BoPhan", "BoPhan").Value = value;
    				On_BoPhan_Changed(this.BoPhan);//\\//
    			}
    	    }
        }
    	public static String BoPhan_ReferencePropertyName { get { return "BoPhan"; } }
    	partial void On_BoPhan_Changing(ref BoPhan newValue, ref bool stopChanging);
    	partial void On_BoPhan_Changed(BoPhan currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BoPhan> BoPhanReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_WebUser_BoPhan_BoPhan", "BoPhan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BoPhan>("ERPModel.FK_WebUser_BoPhan_BoPhan", "BoPhan", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebUser_BoPhan_WebUsers", "WebUser")]
        public WebUser WebUser
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebUser>("ERPModel.FK_WebUser_BoPhan_WebUsers", "WebUser").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_WebUser_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebUser>("ERPModel.FK_WebUser_BoPhan_WebUsers", "WebUser").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WebUser>("ERPModel.FK_WebUser_BoPhan_WebUsers", "WebUser");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WebUser>("ERPModel.FK_WebUser_BoPhan_WebUsers", "WebUser", value);
                }
            }
        }

        #endregion

    }
}
