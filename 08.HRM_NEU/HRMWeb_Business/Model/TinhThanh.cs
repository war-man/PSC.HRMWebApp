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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="TinhThanh")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TinhThanh : ERP_Core.BaseEntityObject//EntityObject
    {
    	static TinhThanh()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public TinhThanh()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new TinhThanh object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static TinhThanh CreateTinhThanh(System.Guid oid)
        {
            TinhThanh tinhThanh = new TinhThanh();
            tinhThanh.Oid = oid;
            return tinhThanh;
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
        public string MaQuanLy
        {
            get
            {
                return _maQuanLy;
            }
            set
            {
    			string oldValue =  _maQuanLy;
    			bool stopChanging = false;
                On_MaQuanLy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MaQuanLy");
    			if(!stopChanging)
    			{
    				_maQuanLy = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("MaQuanLy");
    				On_MaQuanLy_Changed(oldValue, _maQuanLy);//\\
    			}
            }
        }
    	public static String MaQuanLy_PropertyName { get { return "MaQuanLy"; } }
        private string _maQuanLy;
        partial void On_MaQuanLy_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_MaQuanLy_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenTinhThanh
        {
            get
            {
                return _tenTinhThanh;
            }
            set
            {
    			string oldValue =  _tenTinhThanh;
    			bool stopChanging = false;
                On_TenTinhThanh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenTinhThanh");
    			if(!stopChanging)
    			{
    				_tenTinhThanh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenTinhThanh");
    				On_TenTinhThanh_Changed(oldValue, _tenTinhThanh);//\\
    			}
            }
        }
    	public static String TenTinhThanh_PropertyName { get { return "TenTinhThanh"; } }
        private string _tenTinhThanh;
        partial void On_TenTinhThanh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenTinhThanh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> QuocGia
        {
            get
            {
                return _quocGia;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _quocGia;
    			bool stopChanging = false;
                On_QuocGia_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuocGia");
    			if(!stopChanging)
    			{
    				_quocGia = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("QuocGia");
    				On_QuocGia_Changed(oldValue, _quocGia);//\\
    			}
            }
        }
    	public static String QuocGia_PropertyName { get { return "QuocGia"; } }
        private Nullable<System.Guid> _quocGia;
        partial void On_QuocGia_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_QuocGia_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayDiDuong
        {
            get
            {
                return _soNgayDiDuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayDiDuong;
    			bool stopChanging = false;
                On_SoNgayDiDuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayDiDuong");
    			if(!stopChanging)
    			{
    				_soNgayDiDuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayDiDuong");
    				On_SoNgayDiDuong_Changed(oldValue, _soNgayDiDuong);//\\
    			}
            }
        }
    	public static String SoNgayDiDuong_PropertyName { get { return "SoNgayDiDuong"; } }
        private Nullable<decimal> _soNgayDiDuong;
        partial void On_SoNgayDiDuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayDiDuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_TinhThanh", "CC_ChamCongNgayNghi")]
        public EntityCollection<CC_ChamCongNgayNghi> CC_ChamCongNgayNghi
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_TinhThanh", "CC_ChamCongNgayNghi");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_ChamCongNgayNghi_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_TinhThanh", "CC_ChamCongNgayNghi", value);
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HoSo_NoiCap", "HoSo")]
        public EntityCollection<HoSo> HoSoes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HoSo>("ERPModel.FK_HoSo_NoiCap", "HoSo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HoSoes_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HoSo>("ERPModel.FK_HoSo_NoiCap", "HoSo", value);
    					On_HoSoes_Changed(this.HoSoes);//\\//
    				}
    			}
            }
        }
    	public static String HoSoes_EntityCollectionPropertyName { get { return "HoSoes"; } }
    	partial void On_HoSoes_Changing(ref EntityCollection<HoSo> newValue, ref bool stopChanging);
    	partial void On_HoSoes_Changed(EntityCollection<HoSo> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_TinhThanh_QuocGia", "QuocGia")]
        public QuocGia QuocGia1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_TinhThanh_QuocGia", "QuocGia").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_QuocGia1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_TinhThanh_QuocGia", "QuocGia").Value = value;
    				On_QuocGia1_Changed(this.QuocGia1);//\\//
    			}
    	    }
        }
    	public static String QuocGia1_ReferencePropertyName { get { return "QuocGia1"; } }
    	partial void On_QuocGia1_Changing(ref QuocGia newValue, ref bool stopChanging);
    	partial void On_QuocGia1_Changed(QuocGia currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<QuocGia> QuocGia1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_TinhThanh_QuocGia", "QuocGia");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuocGia>("ERPModel.FK_TinhThanh_QuocGia", "QuocGia", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuanHuyen_TinhThanh", "QuanHuyen")]
        public EntityCollection<QuanHuyen> QuanHuyens
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<QuanHuyen>("ERPModel.FK_QuanHuyen_TinhThanh", "QuanHuyen");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_QuanHuyens_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<QuanHuyen>("ERPModel.FK_QuanHuyen_TinhThanh", "QuanHuyen", value);
    					On_QuanHuyens_Changed(this.QuanHuyens);//\\//
    				}
    			}
            }
        }
    	public static String QuanHuyens_EntityCollectionPropertyName { get { return "QuanHuyens"; } }
    	partial void On_QuanHuyens_Changing(ref EntityCollection<QuanHuyen> newValue, ref bool stopChanging);
    	partial void On_QuanHuyens_Changed(EntityCollection<QuanHuyen> currentValue);

        #endregion

    }
}
