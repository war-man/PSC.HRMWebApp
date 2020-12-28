//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 05:00:01 ngay 10/01/2020
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="KyTinhLuong")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class KyTinhLuong : ERP_Core.BaseEntityObject//EntityObject
    {
    	static KyTinhLuong()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public KyTinhLuong()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new KyTinhLuong object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static KyTinhLuong CreateKyTinhLuong(System.Guid oid)
        {
            KyTinhLuong kyTinhLuong = new KyTinhLuong();
            kyTinhLuong.Oid = oid;
            return kyTinhLuong;
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
        public Nullable<System.Guid> BangChotThongTinTinhLuong
        {
            get
            {
                return _bangChotThongTinTinhLuong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _bangChotThongTinTinhLuong;
    			bool stopChanging = false;
                On_BangChotThongTinTinhLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BangChotThongTinTinhLuong");
    			if(!stopChanging)
    			{
    				_bangChotThongTinTinhLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("BangChotThongTinTinhLuong");
    				On_BangChotThongTinTinhLuong_Changed(oldValue, _bangChotThongTinTinhLuong);//\\
    			}
            }
        }
    	public static String BangChotThongTinTinhLuong_PropertyName { get { return "BangChotThongTinTinhLuong"; } }
        private Nullable<System.Guid> _bangChotThongTinTinhLuong;
        partial void On_BangChotThongTinTinhLuong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_BangChotThongTinTinhLuong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ThongTinChung
        {
            get
            {
                return _thongTinChung;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _thongTinChung;
    			bool stopChanging = false;
                On_ThongTinChung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThongTinChung");
    			if(!stopChanging)
    			{
    				_thongTinChung = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThongTinChung");
    				On_ThongTinChung_Changed(oldValue, _thongTinChung);//\\
    			}
            }
        }
    	public static String ThongTinChung_PropertyName { get { return "ThongTinChung"; } }
        private Nullable<System.Guid> _thongTinChung;
        partial void On_ThongTinChung_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ThongTinChung_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> MocTinhThueTNCN
        {
            get
            {
                return _mocTinhThueTNCN;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _mocTinhThueTNCN;
    			bool stopChanging = false;
                On_MocTinhThueTNCN_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MocTinhThueTNCN");
    			if(!stopChanging)
    			{
    				_mocTinhThueTNCN = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("MocTinhThueTNCN");
    				On_MocTinhThueTNCN_Changed(oldValue, _mocTinhThueTNCN);//\\
    			}
            }
        }
    	public static String MocTinhThueTNCN_PropertyName { get { return "MocTinhThueTNCN"; } }
        private Nullable<System.Guid> _mocTinhThueTNCN;
        partial void On_MocTinhThueTNCN_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_MocTinhThueTNCN_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_KyTinhLuong_BangChotThongTinTinhLuong", "BangChotThongTinTinhLuong")]
        public BangChotThongTinTinhLuong BangChotThongTinTinhLuong1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BangChotThongTinTinhLuong>("ERPModel.FK_KyTinhLuong_BangChotThongTinTinhLuong", "BangChotThongTinTinhLuong").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_BangChotThongTinTinhLuong1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BangChotThongTinTinhLuong>("ERPModel.FK_KyTinhLuong_BangChotThongTinTinhLuong", "BangChotThongTinTinhLuong").Value = value;
    				On_BangChotThongTinTinhLuong1_Changed(this.BangChotThongTinTinhLuong1);//\\//
    			}
    	    }
        }
    	public static String BangChotThongTinTinhLuong1_ReferencePropertyName { get { return "BangChotThongTinTinhLuong1"; } }
    	partial void On_BangChotThongTinTinhLuong1_Changing(ref BangChotThongTinTinhLuong newValue, ref bool stopChanging);
    	partial void On_BangChotThongTinTinhLuong1_Changed(BangChotThongTinTinhLuong currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BangChotThongTinTinhLuong> BangChotThongTinTinhLuong1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BangChotThongTinTinhLuong>("ERPModel.FK_KyTinhLuong_BangChotThongTinTinhLuong", "BangChotThongTinTinhLuong");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BangChotThongTinTinhLuong>("ERPModel.FK_KyTinhLuong_BangChotThongTinTinhLuong", "BangChotThongTinTinhLuong", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_BangLuongNhanVien_KyTinhLuong", "BangLuongNhanVien")]
        public EntityCollection<BangLuongNhanVien> BangLuongNhanViens
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BangLuongNhanVien>("ERPModel.FK_BangLuongNhanVien_KyTinhLuong", "BangLuongNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_BangLuongNhanViens_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BangLuongNhanVien>("ERPModel.FK_BangLuongNhanVien_KyTinhLuong", "BangLuongNhanVien", value);
    					On_BangLuongNhanViens_Changed(this.BangLuongNhanViens);//\\//
    				}
    			}
            }
        }
    	public static String BangLuongNhanViens_EntityCollectionPropertyName { get { return "BangLuongNhanViens"; } }
    	partial void On_BangLuongNhanViens_Changing(ref EntityCollection<BangLuongNhanVien> newValue, ref bool stopChanging);
    	partial void On_BangLuongNhanViens_Changed(EntityCollection<BangLuongNhanVien> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuanLyChamCongNhanVien_KyTinhLuong", "QuanLyChamCongNhanVien")]
        public EntityCollection<QuanLyChamCongNhanVien> QuanLyChamCongNhanViens
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<QuanLyChamCongNhanVien>("ERPModel.FK_QuanLyChamCongNhanVien_KyTinhLuong", "QuanLyChamCongNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_QuanLyChamCongNhanViens_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<QuanLyChamCongNhanVien>("ERPModel.FK_QuanLyChamCongNhanVien_KyTinhLuong", "QuanLyChamCongNhanVien", value);
    					On_QuanLyChamCongNhanViens_Changed(this.QuanLyChamCongNhanViens);//\\//
    				}
    			}
            }
        }
    	public static String QuanLyChamCongNhanViens_EntityCollectionPropertyName { get { return "QuanLyChamCongNhanViens"; } }
    	partial void On_QuanLyChamCongNhanViens_Changing(ref EntityCollection<QuanLyChamCongNhanVien> newValue, ref bool stopChanging);
    	partial void On_QuanLyChamCongNhanViens_Changed(EntityCollection<QuanLyChamCongNhanVien> currentValue);

        #endregion

    }
}
