//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 09:24:55 ngay 29/02/2020
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_KyChamCong")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_KyChamCong : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_KyChamCong()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_KyChamCong()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_KyChamCong object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_KyChamCong CreateCC_KyChamCong(System.Guid oid)
        {
            CC_KyChamCong cC_KyChamCong = new CC_KyChamCong();
            cC_KyChamCong.Oid = oid;
            return cC_KyChamCong;
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
        public Nullable<int> Thang
        {
            get
            {
                return _thang;
            }
            set
            {
    			Nullable<int> oldValue =  _thang;
    			bool stopChanging = false;
                On_Thang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Thang");
    			if(!stopChanging)
    			{
    				_thang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Thang");
    				On_Thang_Changed(oldValue, _thang);//\\
    			}
            }
        }
    	public static String Thang_PropertyName { get { return "Thang"; } }
        private Nullable<int> _thang;
        partial void On_Thang_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_Thang_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> Nam
        {
            get
            {
                return _nam;
            }
            set
            {
    			Nullable<int> oldValue =  _nam;
    			bool stopChanging = false;
                On_Nam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Nam");
    			if(!stopChanging)
    			{
    				_nam = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Nam");
    				On_Nam_Changed(oldValue, _nam);//\\
    			}
            }
        }
    	public static String Nam_PropertyName { get { return "Nam"; } }
        private Nullable<int> _nam;
        partial void On_Nam_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_Nam_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> TuNgay
        {
            get
            {
                return _tuNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _tuNgay;
    			bool stopChanging = false;
                On_TuNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNgay");
    			if(!stopChanging)
    			{
    				_tuNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TuNgay");
    				On_TuNgay_Changed(oldValue, _tuNgay);//\\
    			}
            }
        }
    	public static String TuNgay_PropertyName { get { return "TuNgay"; } }
        private Nullable<System.DateTime> _tuNgay;
        partial void On_TuNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_TuNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> DenNgay
        {
            get
            {
                return _denNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _denNgay;
    			bool stopChanging = false;
                On_DenNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNgay");
    			if(!stopChanging)
    			{
    				_denNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DenNgay");
    				On_DenNgay_Changed(oldValue, _denNgay);//\\
    			}
            }
        }
    	public static String DenNgay_PropertyName { get { return "DenNgay"; } }
        private Nullable<System.DateTime> _denNgay;
        partial void On_DenNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_DenNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgay
        {
            get
            {
                return _soNgay;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgay;
    			bool stopChanging = false;
                On_SoNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgay");
    			if(!stopChanging)
    			{
    				_soNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgay");
    				On_SoNgay_Changed(oldValue, _soNgay);//\\
    			}
            }
        }
    	public static String SoNgay_PropertyName { get { return "SoNgay"; } }
        private Nullable<decimal> _soNgay;
        partial void On_SoNgay_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgay_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> KhoaSo
        {
            get
            {
                return _khoaSo;
            }
            set
            {
    			Nullable<bool> oldValue =  _khoaSo;
    			bool stopChanging = false;
                On_KhoaSo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KhoaSo");
    			if(!stopChanging)
    			{
    				_khoaSo = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KhoaSo");
    				On_KhoaSo_Changed(oldValue, _khoaSo);//\\
    			}
            }
        }
    	public static String KhoaSo_PropertyName { get { return "KhoaSo"; } }
        private Nullable<bool> _khoaSo;
        partial void On_KhoaSo_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_KhoaSo_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);
    
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

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_QuanLyChamCong_KyChamCong", "CC_QuanLyChamCong")]
        public EntityCollection<CC_QuanLyChamCong> CC_QuanLyChamCong
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_QuanLyChamCong>("ERPModel.FK_CC_QuanLyChamCong_KyChamCong", "CC_QuanLyChamCong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_QuanLyChamCong_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_QuanLyChamCong>("ERPModel.FK_CC_QuanLyChamCong_KyChamCong", "CC_QuanLyChamCong", value);
    					On_CC_QuanLyChamCong_Changed(this.CC_QuanLyChamCong);//\\//
    				}
    			}
            }
        }
    	public static String CC_QuanLyChamCong_EntityCollectionPropertyName { get { return "CC_QuanLyChamCong"; } }
    	partial void On_CC_QuanLyChamCong_Changing(ref EntityCollection<CC_QuanLyChamCong> newValue, ref bool stopChanging);
    	partial void On_CC_QuanLyChamCong_Changed(EntityCollection<CC_QuanLyChamCong> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_KyChamCong_CongTy", "CongTy")]
        public CongTy CongTy1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_CC_KyChamCong_CongTy", "CongTy").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CongTy1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_CC_KyChamCong_CongTy", "CongTy").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_CC_KyChamCong_CongTy", "CongTy");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CongTy>("ERPModel.FK_CC_KyChamCong_CongTy", "CongTy", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_QuanLyCongNgoaiGio_CC_KyChamCong", "CC_QuanLyCongNgoaiGio")]
        public EntityCollection<CC_QuanLyCongNgoaiGio> CC_QuanLyCongNgoaiGio
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_QuanLyCongNgoaiGio>("ERPModel.FK_CC_QuanLyCongNgoaiGio_CC_KyChamCong", "CC_QuanLyCongNgoaiGio");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_QuanLyCongNgoaiGio_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_QuanLyCongNgoaiGio>("ERPModel.FK_CC_QuanLyCongNgoaiGio_CC_KyChamCong", "CC_QuanLyCongNgoaiGio", value);
    					On_CC_QuanLyCongNgoaiGio_Changed(this.CC_QuanLyCongNgoaiGio);//\\//
    				}
    			}
            }
        }
    	public static String CC_QuanLyCongNgoaiGio_EntityCollectionPropertyName { get { return "CC_QuanLyCongNgoaiGio"; } }
    	partial void On_CC_QuanLyCongNgoaiGio_Changing(ref EntityCollection<CC_QuanLyCongNgoaiGio> newValue, ref bool stopChanging);
    	partial void On_CC_QuanLyCongNgoaiGio_Changed(EntityCollection<CC_QuanLyCongNgoaiGio> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_KyTinhLuong_QuanLyCongKhac", "KyTinhLuong")]
        public EntityCollection<KyTinhLuong> KyTinhLuongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<KyTinhLuong>("ERPModel.FK_KyTinhLuong_QuanLyCongKhac", "KyTinhLuong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_KyTinhLuongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<KyTinhLuong>("ERPModel.FK_KyTinhLuong_QuanLyCongKhac", "KyTinhLuong", value);
    					On_KyTinhLuongs_Changed(this.KyTinhLuongs);//\\//
    				}
    			}
            }
        }
    	public static String KyTinhLuongs_EntityCollectionPropertyName { get { return "KyTinhLuongs"; } }
    	partial void On_KyTinhLuongs_Changing(ref EntityCollection<KyTinhLuong> newValue, ref bool stopChanging);
    	partial void On_KyTinhLuongs_Changed(EntityCollection<KyTinhLuong> currentValue);

        #endregion

    }
}
