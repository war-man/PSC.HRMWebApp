//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 12:14:05 ngay 06/04/2019
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_QuanLyNghiPhep")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_QuanLyNghiPhep : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_QuanLyNghiPhep()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_QuanLyNghiPhep()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_QuanLyNghiPhep object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_QuanLyNghiPhep CreateCC_QuanLyNghiPhep(System.Guid oid)
        {
            CC_QuanLyNghiPhep cC_QuanLyNghiPhep = new CC_QuanLyNghiPhep();
            cC_QuanLyNghiPhep.Oid = oid;
            return cC_QuanLyNghiPhep;
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
        public Nullable<System.Guid> NamHoc
        {
            get
            {
                return _namHoc;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _namHoc;
    			bool stopChanging = false;
                On_NamHoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NamHoc");
    			if(!stopChanging)
    			{
    				_namHoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NamHoc");
    				On_NamHoc_Changed(oldValue, _namHoc);//\\
    			}
            }
        }
    	public static String NamHoc_PropertyName { get { return "NamHoc"; } }
        private Nullable<System.Guid> _namHoc;
        partial void On_NamHoc_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_NamHoc_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> CongTy
        {
            get
            {
                return _congTy;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _congTy;
    			bool stopChanging = false;
                On_CongTy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CongTy");
    			if(!stopChanging)
    			{
    				_congTy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CongTy");
    				On_CongTy_Changed(oldValue, _congTy);//\\
    			}
            }
        }
    	public static String CongTy_PropertyName { get { return "CongTy"; } }
        private Nullable<System.Guid> _congTy;
        partial void On_CongTy_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_CongTy_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> NienDoTaiChinh
        {
            get
            {
                return _nienDoTaiChinh;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _nienDoTaiChinh;
    			bool stopChanging = false;
                On_NienDoTaiChinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NienDoTaiChinh");
    			if(!stopChanging)
    			{
    				_nienDoTaiChinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NienDoTaiChinh");
    				On_NienDoTaiChinh_Changed(oldValue, _nienDoTaiChinh);//\\
    			}
            }
        }
    	public static String NienDoTaiChinh_PropertyName { get { return "NienDoTaiChinh"; } }
        private Nullable<System.Guid> _nienDoTaiChinh;
        partial void On_NienDoTaiChinh_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_NienDoTaiChinh_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_ChiTietNghiPhep")]
        public EntityCollection<CC_ChiTietNghiPhep> CC_ChiTietNghiPhep
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_ChiTietNghiPhep>("ERPModel.FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_ChiTietNghiPhep");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_ChiTietNghiPhep_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_ChiTietNghiPhep>("ERPModel.FK_CC_ChiTietNghiPhep_CC_QuanLyNghiPhep", "CC_ChiTietNghiPhep", value);
    					On_CC_ChiTietNghiPhep_Changed(this.CC_ChiTietNghiPhep);//\\//
    				}
    			}
            }
        }
    	public static String CC_ChiTietNghiPhep_EntityCollectionPropertyName { get { return "CC_ChiTietNghiPhep"; } }
    	partial void On_CC_ChiTietNghiPhep_Changing(ref EntityCollection<CC_ChiTietNghiPhep> newValue, ref bool stopChanging);
    	partial void On_CC_ChiTietNghiPhep_Changed(EntityCollection<CC_ChiTietNghiPhep> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_QuanLyNghiPhep_CongTy", "CongTy")]
        public CongTy CongTy1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_CC_QuanLyNghiPhep_CongTy", "CongTy").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CongTy1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_CC_QuanLyNghiPhep_CongTy", "CongTy").Value = value;
    				On_CongTy1_Changed(this.CongTy1);//\\//
    			}
    	    }
        }
    	public static String CongTy1_ReferencePropertyName { get { return "CongTy1"; } }
    	partial void On_CongTy1_Changing(ref CongTy newValue, ref bool stopChanging);
    	partial void On_CongTy1_Changed(CongTy currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CongTy> CongTy1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_CC_QuanLyNghiPhep_CongTy", "CongTy");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CongTy>("ERPModel.FK_CC_QuanLyNghiPhep_CongTy", "CongTy", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_QuanLyNghiPhep_NamHoc", "NamHoc")]
        public NamHoc NamHoc1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NamHoc>("ERPModel.FK_CC_QuanLyNghiPhep_NamHoc", "NamHoc").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_NamHoc1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NamHoc>("ERPModel.FK_CC_QuanLyNghiPhep_NamHoc", "NamHoc").Value = value;
    				On_NamHoc1_Changed(this.NamHoc1);//\\//
    			}
    	    }
        }
    	public static String NamHoc1_ReferencePropertyName { get { return "NamHoc1"; } }
    	partial void On_NamHoc1_Changing(ref NamHoc newValue, ref bool stopChanging);
    	partial void On_NamHoc1_Changed(NamHoc currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<NamHoc> NamHoc1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NamHoc>("ERPModel.FK_CC_QuanLyNghiPhep_NamHoc", "NamHoc");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<NamHoc>("ERPModel.FK_CC_QuanLyNghiPhep_NamHoc", "NamHoc", value);
                }
            }
        }

        #endregion

    }
}
