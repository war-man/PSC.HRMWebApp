//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 04:34:42 ngay 13/09/2018
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CacBuoiTrongNgay")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CacBuoiTrongNgay : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CacBuoiTrongNgay()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CacBuoiTrongNgay()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CacBuoiTrongNgay object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CacBuoiTrongNgay CreateCacBuoiTrongNgay(System.Guid oid)
        {
            CacBuoiTrongNgay cacBuoiTrongNgay = new CacBuoiTrongNgay();
            cacBuoiTrongNgay.Oid = oid;
            return cacBuoiTrongNgay;
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
        public string TenBuoi
        {
            get
            {
                return _tenBuoi;
            }
            set
            {
    			string oldValue =  _tenBuoi;
    			bool stopChanging = false;
                On_TenBuoi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenBuoi");
    			if(!stopChanging)
    			{
    				_tenBuoi = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenBuoi");
    				On_TenBuoi_Changed(oldValue, _tenBuoi);//\\
    			}
            }
        }
    	public static String TenBuoi_PropertyName { get { return "TenBuoi"; } }
        private string _tenBuoi;
        partial void On_TenBuoi_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenBuoi_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> GiaTri
        {
            get
            {
                return _giaTri;
            }
            set
            {
    			Nullable<decimal> oldValue =  _giaTri;
    			bool stopChanging = false;
                On_GiaTri_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GiaTri");
    			if(!stopChanging)
    			{
    				_giaTri = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("GiaTri");
    				On_GiaTri_Changed(oldValue, _giaTri);//\\
    			}
            }
        }
    	public static String GiaTri_PropertyName { get { return "GiaTri"; } }
        private Nullable<decimal> _giaTri;
        partial void On_GiaTri_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_GiaTri_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> OptimisticLockField
        {
            get
            {
                return _optimisticLockField;
            }
            set
            {
    			Nullable<int> oldValue =  _optimisticLockField;
    			bool stopChanging = false;
                On_OptimisticLockField_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("OptimisticLockField");
    			if(!stopChanging)
    			{
    				_optimisticLockField = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("OptimisticLockField");
    				On_OptimisticLockField_Changed(oldValue, _optimisticLockField);//\\
    			}
            }
        }
    	public static String OptimisticLockField_PropertyName { get { return "OptimisticLockField"; } }
        private Nullable<int> _optimisticLockField;
        partial void On_OptimisticLockField_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_OptimisticLockField_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> GCRecord
        {
            get
            {
                return _gCRecord;
            }
            set
            {
    			Nullable<int> oldValue =  _gCRecord;
    			bool stopChanging = false;
                On_GCRecord_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GCRecord");
    			if(!stopChanging)
    			{
    				_gCRecord = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("GCRecord");
    				On_GCRecord_Changed(oldValue, _gCRecord);//\\
    			}
            }
        }
    	public static String GCRecord_PropertyName { get { return "GCRecord"; } }
        private Nullable<int> _gCRecord;
        partial void On_GCRecord_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_GCRecord_Changed(Nullable<int> oldValue, Nullable<int> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_CacBuoiTrongNgay", "CC_ChamCongNgayNghi")]
        public EntityCollection<CC_ChamCongNgayNghi> CC_ChamCongNgayNghi
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_CacBuoiTrongNgay", "CC_ChamCongNgayNghi");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_ChamCongNgayNghi_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_CacBuoiTrongNgay", "CC_ChamCongNgayNghi", value);
    					On_CC_ChamCongNgayNghi_Changed(this.CC_ChamCongNgayNghi);//\\//
    				}
    			}
            }
        }
    	public static String CC_ChamCongNgayNghi_EntityCollectionPropertyName { get { return "CC_ChamCongNgayNghi"; } }
    	partial void On_CC_ChamCongNgayNghi_Changing(ref EntityCollection<CC_ChamCongNgayNghi> newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongNgayNghi_Changed(EntityCollection<CC_ChamCongNgayNghi> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_CacBuoiTrongNgay1", "CC_ChamCongNgayNghi")]
        public EntityCollection<CC_ChamCongNgayNghi> CC_ChamCongNgayNghi1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_CacBuoiTrongNgay1", "CC_ChamCongNgayNghi");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_ChamCongNgayNghi1_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_CacBuoiTrongNgay1", "CC_ChamCongNgayNghi", value);
    					On_CC_ChamCongNgayNghi1_Changed(this.CC_ChamCongNgayNghi1);//\\//
    				}
    			}
            }
        }
    	public static String CC_ChamCongNgayNghi1_EntityCollectionPropertyName { get { return "CC_ChamCongNgayNghi1"; } }
    	partial void On_CC_ChamCongNgayNghi1_Changing(ref EntityCollection<CC_ChamCongNgayNghi> newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongNgayNghi1_Changed(EntityCollection<CC_ChamCongNgayNghi> currentValue);

        #endregion

    }
}
