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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="NgachLuong")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class NgachLuong : ERP_Core.BaseEntityObject//EntityObject
    {
    	static NgachLuong()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public NgachLuong()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new NgachLuong object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static NgachLuong CreateNgachLuong(System.Guid oid)
        {
            NgachLuong ngachLuong = new NgachLuong();
            ngachLuong.Oid = oid;
            return ngachLuong;
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
        public Nullable<System.Guid> NhomNgachLuong
        {
            get
            {
                return _nhomNgachLuong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _nhomNgachLuong;
    			bool stopChanging = false;
                On_NhomNgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NhomNgachLuong");
    			if(!stopChanging)
    			{
    				_nhomNgachLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NhomNgachLuong");
    				On_NhomNgachLuong_Changed(oldValue, _nhomNgachLuong);//\\
    			}
            }
        }
    	public static String NhomNgachLuong_PropertyName { get { return "NhomNgachLuong"; } }
        private Nullable<System.Guid> _nhomNgachLuong;
        partial void On_NhomNgachLuong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_NhomNgachLuong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
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
        public string TenNgachLuong
        {
            get
            {
                return _tenNgachLuong;
            }
            set
            {
    			string oldValue =  _tenNgachLuong;
    			bool stopChanging = false;
                On_TenNgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenNgachLuong");
    			if(!stopChanging)
    			{
    				_tenNgachLuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenNgachLuong");
    				On_TenNgachLuong_Changed(oldValue, _tenNgachLuong);//\\
    			}
            }
        }
    	public static String TenNgachLuong_PropertyName { get { return "TenNgachLuong"; } }
        private string _tenNgachLuong;
        partial void On_TenNgachLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenNgachLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> ThoiGianNangBac
        {
            get
            {
                return _thoiGianNangBac;
            }
            set
            {
    			Nullable<int> oldValue =  _thoiGianNangBac;
    			bool stopChanging = false;
                On_ThoiGianNangBac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianNangBac");
    			if(!stopChanging)
    			{
    				_thoiGianNangBac = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThoiGianNangBac");
    				On_ThoiGianNangBac_Changed(oldValue, _thoiGianNangBac);//\\
    			}
            }
        }
    	public static String ThoiGianNangBac_PropertyName { get { return "ThoiGianNangBac"; } }
        private Nullable<int> _thoiGianNangBac;
        partial void On_ThoiGianNangBac_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_ThoiGianNangBac_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> TotKhung
        {
            get
            {
                return _totKhung;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _totKhung;
    			bool stopChanging = false;
                On_TotKhung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TotKhung");
    			if(!stopChanging)
    			{
    				_totKhung = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TotKhung");
    				On_TotKhung_Changed(oldValue, _totKhung);//\\
    			}
            }
        }
    	public static String TotKhung_PropertyName { get { return "TotKhung"; } }
        private Nullable<System.Guid> _totKhung;
        partial void On_TotKhung_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_TotKhung_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> CapBac
        {
            get
            {
                return _capBac;
            }
            set
            {
    			Nullable<decimal> oldValue =  _capBac;
    			bool stopChanging = false;
                On_CapBac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CapBac");
    			if(!stopChanging)
    			{
    				_capBac = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CapBac");
    				On_CapBac_Changed(oldValue, _capBac);//\\
    			}
            }
        }
    	public static String CapBac_PropertyName { get { return "CapBac"; } }
        private Nullable<decimal> _capBac;
        partial void On_CapBac_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_CapBac_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_BacLuong_NgachLuong", "BacLuong")]
        public EntityCollection<BacLuong> BacLuongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BacLuong>("ERPModel.FK_BacLuong_NgachLuong", "BacLuong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_BacLuongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BacLuong>("ERPModel.FK_BacLuong_NgachLuong", "BacLuong", value);
    					On_BacLuongs_Changed(this.BacLuongs);//\\//
    				}
    			}
            }
        }
    	public static String BacLuongs_EntityCollectionPropertyName { get { return "BacLuongs"; } }
    	partial void On_BacLuongs_Changing(ref EntityCollection<BacLuong> newValue, ref bool stopChanging);
    	partial void On_BacLuongs_Changed(EntityCollection<BacLuong> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_NgachLuong_TotKhung", "BacLuong")]
        public BacLuong BacLuong
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BacLuong>("ERPModel.FK_NgachLuong_TotKhung", "BacLuong").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_BacLuong_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BacLuong>("ERPModel.FK_NgachLuong_TotKhung", "BacLuong").Value = value;
    				On_BacLuong_Changed(this.BacLuong);//\\//
    			}
    	    }
        }
    	public static String BacLuong_ReferencePropertyName { get { return "BacLuong"; } }
    	partial void On_BacLuong_Changing(ref BacLuong newValue, ref bool stopChanging);
    	partial void On_BacLuong_Changed(BacLuong currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BacLuong> BacLuongReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BacLuong>("ERPModel.FK_NgachLuong_TotKhung", "BacLuong");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BacLuong>("ERPModel.FK_NgachLuong_TotKhung", "BacLuong", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_NgachLuong_CongTy", "CongTy")]
        public CongTy CongTy1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_NgachLuong_CongTy", "CongTy").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CongTy1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_NgachLuong_CongTy", "CongTy").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CongTy>("ERPModel.FK_NgachLuong_CongTy", "CongTy");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CongTy>("ERPModel.FK_NgachLuong_CongTy", "CongTy", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_NhanVienThongTinLuong_NgachLuong", "NhanVienThongTinLuong")]
        public EntityCollection<NhanVienThongTinLuong> NhanVienThongTinLuongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<NhanVienThongTinLuong>("ERPModel.FK_NhanVienThongTinLuong_NgachLuong", "NhanVienThongTinLuong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_NhanVienThongTinLuongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<NhanVienThongTinLuong>("ERPModel.FK_NhanVienThongTinLuong_NgachLuong", "NhanVienThongTinLuong", value);
    					On_NhanVienThongTinLuongs_Changed(this.NhanVienThongTinLuongs);//\\//
    				}
    			}
            }
        }
    	public static String NhanVienThongTinLuongs_EntityCollectionPropertyName { get { return "NhanVienThongTinLuongs"; } }
    	partial void On_NhanVienThongTinLuongs_Changing(ref EntityCollection<NhanVienThongTinLuong> newValue, ref bool stopChanging);
    	partial void On_NhanVienThongTinLuongs_Changed(EntityCollection<NhanVienThongTinLuong> currentValue);

        #endregion

    }
}
