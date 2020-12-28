//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 04:17:16 ngay 30/08/2016
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="QuanLyChamCongNhanVien")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class QuanLyChamCongNhanVien : ERP_Core.BaseEntityObject//EntityObject
    {
    	static QuanLyChamCongNhanVien()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public QuanLyChamCongNhanVien()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new QuanLyChamCongNhanVien object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static QuanLyChamCongNhanVien CreateQuanLyChamCongNhanVien(System.Guid oid)
        {
            QuanLyChamCongNhanVien quanLyChamCongNhanVien = new QuanLyChamCongNhanVien();
            quanLyChamCongNhanVien.Oid = oid;
            return quanLyChamCongNhanVien;
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
        public Nullable<System.Guid> ThongTinTruong
        {
            get
            {
                return _thongTinTruong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _thongTinTruong;
    			bool stopChanging = false;
                On_ThongTinTruong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThongTinTruong");
    			if(!stopChanging)
    			{
    				_thongTinTruong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThongTinTruong");
    				On_ThongTinTruong_Changed(oldValue, _thongTinTruong);//\\
    			}
            }
        }
    	public static String ThongTinTruong_PropertyName { get { return "ThongTinTruong"; } }
        private Nullable<System.Guid> _thongTinTruong;
        partial void On_ThongTinTruong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ThongTinTruong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> KyTinhLuong
        {
            get
            {
                return _kyTinhLuong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _kyTinhLuong;
    			bool stopChanging = false;
                On_KyTinhLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KyTinhLuong");
    			if(!stopChanging)
    			{
    				_kyTinhLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KyTinhLuong");
    				On_KyTinhLuong_Changed(oldValue, _kyTinhLuong);//\\
    			}
            }
        }
    	public static String KyTinhLuong_PropertyName { get { return "KyTinhLuong"; } }
        private Nullable<System.Guid> _kyTinhLuong;
        partial void On_KyTinhLuong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_KyTinhLuong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayLap
        {
            get
            {
                return _ngayLap;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayLap;
    			bool stopChanging = false;
                On_NgayLap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayLap");
    			if(!stopChanging)
    			{
    				_ngayLap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayLap");
    				On_NgayLap_Changed(oldValue, _ngayLap);//\\
    			}
            }
        }
    	public static String NgayLap_PropertyName { get { return "NgayLap"; } }
        private Nullable<System.DateTime> _ngayLap;
        partial void On_NgayLap_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayLap_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
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
        public Nullable<System.Guid> CreatedUser
        {
            get
            {
                return _createdUser;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _createdUser;
    			bool stopChanging = false;
                On_CreatedUser_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CreatedUser");
    			if(!stopChanging)
    			{
    				_createdUser = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CreatedUser");
    				On_CreatedUser_Changed(oldValue, _createdUser);//\\
    			}
            }
        }
    	public static String CreatedUser_PropertyName { get { return "CreatedUser"; } }
        private Nullable<System.Guid> _createdUser;
        partial void On_CreatedUser_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_CreatedUser_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> KyChamCong
        {
            get
            {
                return _kyChamCong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _kyChamCong;
    			bool stopChanging = false;
                On_KyChamCong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KyChamCong");
    			if(!stopChanging)
    			{
    				_kyChamCong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KyChamCong");
    				On_KyChamCong_Changed(oldValue, _kyChamCong);//\\
    			}
            }
        }
    	public static String KyChamCong_PropertyName { get { return "KyChamCong"; } }
        private Nullable<System.Guid> _kyChamCong;
        partial void On_KyChamCong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_KyChamCong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuanLyChamCongNhanVien_KyTinhLuong", "KyTinhLuong")]
        public KyTinhLuong KyTinhLuong1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<KyTinhLuong>("ERPModel.FK_QuanLyChamCongNhanVien_KyTinhLuong", "KyTinhLuong").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_KyTinhLuong1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<KyTinhLuong>("ERPModel.FK_QuanLyChamCongNhanVien_KyTinhLuong", "KyTinhLuong").Value = value;
    				On_KyTinhLuong1_Changed(this.KyTinhLuong1);//\\//
    			}
    	    }
        }
    	public static String KyTinhLuong1_ReferencePropertyName { get { return "KyTinhLuong1"; } }
    	partial void On_KyTinhLuong1_Changing(ref KyTinhLuong newValue, ref bool stopChanging);
    	partial void On_KyTinhLuong1_Changed(KyTinhLuong currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<KyTinhLuong> KyTinhLuong1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<KyTinhLuong>("ERPModel.FK_QuanLyChamCongNhanVien_KyTinhLuong", "KyTinhLuong");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<KyTinhLuong>("ERPModel.FK_QuanLyChamCongNhanVien_KyTinhLuong", "KyTinhLuong", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_ChiTietChamCongNhanVien_QuanLyChamCongNhanVien", "ChiTietChamCongNhanVien")]
        public EntityCollection<ChiTietChamCongNhanVien> ChiTietChamCongNhanViens
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ChiTietChamCongNhanVien>("ERPModel.FK_ChiTietChamCongNhanVien_QuanLyChamCongNhanVien", "ChiTietChamCongNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_ChiTietChamCongNhanViens_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ChiTietChamCongNhanVien>("ERPModel.FK_ChiTietChamCongNhanVien_QuanLyChamCongNhanVien", "ChiTietChamCongNhanVien", value);
    					On_ChiTietChamCongNhanViens_Changed(this.ChiTietChamCongNhanViens);//\\//
    				}
    			}
            }
        }
    	public static String ChiTietChamCongNhanViens_EntityCollectionPropertyName { get { return "ChiTietChamCongNhanViens"; } }
    	partial void On_ChiTietChamCongNhanViens_Changing(ref EntityCollection<ChiTietChamCongNhanVien> newValue, ref bool stopChanging);
    	partial void On_ChiTietChamCongNhanViens_Changed(EntityCollection<ChiTietChamCongNhanVien> currentValue);

        #endregion

    }
}