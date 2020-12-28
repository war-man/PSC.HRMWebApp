//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-JDDLVPV\lieu luc 11:05:00 ngay 20/04/2020
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_LyDoDangKyChamCongNgoaiGio")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_LyDoDangKyChamCongNgoaiGio : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_LyDoDangKyChamCongNgoaiGio()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_LyDoDangKyChamCongNgoaiGio()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_LyDoDangKyChamCongNgoaiGio object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_LyDoDangKyChamCongNgoaiGio CreateCC_LyDoDangKyChamCongNgoaiGio(System.Guid oid)
        {
            CC_LyDoDangKyChamCongNgoaiGio cC_LyDoDangKyChamCongNgoaiGio = new CC_LyDoDangKyChamCongNgoaiGio();
            cC_LyDoDangKyChamCongNgoaiGio.Oid = oid;
            return cC_LyDoDangKyChamCongNgoaiGio;
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

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_DangKyChamCongNgoaiGio")]
        public EntityCollection<CC_DangKyChamCongNgoaiGio> CC_DangKyChamCongNgoaiGio
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_DangKyChamCongNgoaiGio>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_DangKyChamCongNgoaiGio");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_DangKyChamCongNgoaiGio_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_DangKyChamCongNgoaiGio>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_DangKyChamCongNgoaiGio", value);
    					On_CC_DangKyChamCongNgoaiGio_Changed(this.CC_DangKyChamCongNgoaiGio);//\\//
    				}
    			}
            }
        }
    	public static String CC_DangKyChamCongNgoaiGio_EntityCollectionPropertyName { get { return "CC_DangKyChamCongNgoaiGio"; } }
    	partial void On_CC_DangKyChamCongNgoaiGio_Changing(ref EntityCollection<CC_DangKyChamCongNgoaiGio> newValue, ref bool stopChanging);
    	partial void On_CC_DangKyChamCongNgoaiGio_Changed(EntityCollection<CC_DangKyChamCongNgoaiGio> currentValue);

        #endregion

    }
}