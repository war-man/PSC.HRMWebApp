//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 01:49:02 ngay 20/01/2017
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="DiaChi")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DiaChi : ERP_Core.BaseEntityObject//EntityObject
    {
    	static DiaChi()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public DiaChi()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new DiaChi object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static DiaChi CreateDiaChi(System.Guid oid)
        {
            DiaChi diaChi = new DiaChi();
            diaChi.Oid = oid;
            return diaChi;
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
        public Nullable<System.Guid> TinhThanh
        {
            get
            {
                return _tinhThanh;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _tinhThanh;
    			bool stopChanging = false;
                On_TinhThanh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TinhThanh");
    			if(!stopChanging)
    			{
    				_tinhThanh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TinhThanh");
    				On_TinhThanh_Changed(oldValue, _tinhThanh);//\\
    			}
            }
        }
    	public static String TinhThanh_PropertyName { get { return "TinhThanh"; } }
        private Nullable<System.Guid> _tinhThanh;
        partial void On_TinhThanh_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_TinhThanh_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> QuanHuyen
        {
            get
            {
                return _quanHuyen;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _quanHuyen;
    			bool stopChanging = false;
                On_QuanHuyen_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanHuyen");
    			if(!stopChanging)
    			{
    				_quanHuyen = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("QuanHuyen");
    				On_QuanHuyen_Changed(oldValue, _quanHuyen);//\\
    			}
            }
        }
    	public static String QuanHuyen_PropertyName { get { return "QuanHuyen"; } }
        private Nullable<System.Guid> _quanHuyen;
        partial void On_QuanHuyen_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_QuanHuyen_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> XaPhuong
        {
            get
            {
                return _xaPhuong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _xaPhuong;
    			bool stopChanging = false;
                On_XaPhuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("XaPhuong");
    			if(!stopChanging)
    			{
    				_xaPhuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("XaPhuong");
    				On_XaPhuong_Changed(oldValue, _xaPhuong);//\\
    			}
            }
        }
    	public static String XaPhuong_PropertyName { get { return "XaPhuong"; } }
        private Nullable<System.Guid> _xaPhuong;
        partial void On_XaPhuong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_XaPhuong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoNha
        {
            get
            {
                return _soNha;
            }
            set
            {
    			string oldValue =  _soNha;
    			bool stopChanging = false;
                On_SoNha_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNha");
    			if(!stopChanging)
    			{
    				_soNha = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoNha");
    				On_SoNha_Changed(oldValue, _soNha);//\\
    			}
            }
        }
    	public static String SoNha_PropertyName { get { return "SoNha"; } }
        private string _soNha;
        partial void On_SoNha_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoNha_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string FullDiaChi
        {
            get
            {
                return _fullDiaChi;
            }
            set
            {
    			string oldValue =  _fullDiaChi;
    			bool stopChanging = false;
                On_FullDiaChi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("FullDiaChi");
    			if(!stopChanging)
    			{
    				_fullDiaChi = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("FullDiaChi");
    				On_FullDiaChi_Changed(oldValue, _fullDiaChi);//\\
    			}
            }
        }
    	public static String FullDiaChi_PropertyName { get { return "FullDiaChi"; } }
        private string _fullDiaChi;
        partial void On_FullDiaChi_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_FullDiaChi_Changed(string oldValue, string currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_DiaChi_QuanHuyen", "QuanHuyen")]
        public QuanHuyen QuanHuyen1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuanHuyen>("ERPModel.FK_DiaChi_QuanHuyen", "QuanHuyen").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_QuanHuyen1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuanHuyen>("ERPModel.FK_DiaChi_QuanHuyen", "QuanHuyen").Value = value;
    				On_QuanHuyen1_Changed(this.QuanHuyen1);//\\//
    			}
    	    }
        }
    	public static String QuanHuyen1_ReferencePropertyName { get { return "QuanHuyen1"; } }
    	partial void On_QuanHuyen1_Changing(ref QuanHuyen newValue, ref bool stopChanging);
    	partial void On_QuanHuyen1_Changed(QuanHuyen currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<QuanHuyen> QuanHuyen1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuanHuyen>("ERPModel.FK_DiaChi_QuanHuyen", "QuanHuyen");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuanHuyen>("ERPModel.FK_DiaChi_QuanHuyen", "QuanHuyen", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_DiaChi_QuocGia", "QuocGia")]
        public QuocGia QuocGia1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_DiaChi_QuocGia", "QuocGia").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_QuocGia1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_DiaChi_QuocGia", "QuocGia").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_DiaChi_QuocGia", "QuocGia");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuocGia>("ERPModel.FK_DiaChi_QuocGia", "QuocGia", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_DiaChi_TinhThanh", "TinhThanh")]
        public TinhThanh TinhThanh1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TinhThanh>("ERPModel.FK_DiaChi_TinhThanh", "TinhThanh").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_TinhThanh1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TinhThanh>("ERPModel.FK_DiaChi_TinhThanh", "TinhThanh").Value = value;
    				On_TinhThanh1_Changed(this.TinhThanh1);//\\//
    			}
    	    }
        }
    	public static String TinhThanh1_ReferencePropertyName { get { return "TinhThanh1"; } }
    	partial void On_TinhThanh1_Changing(ref TinhThanh newValue, ref bool stopChanging);
    	partial void On_TinhThanh1_Changed(TinhThanh currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TinhThanh> TinhThanh1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TinhThanh>("ERPModel.FK_DiaChi_TinhThanh", "TinhThanh");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TinhThanh>("ERPModel.FK_DiaChi_TinhThanh", "TinhThanh", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_DiaChi_XaPhuong", "XaPhuong")]
        public XaPhuong XaPhuong1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<XaPhuong>("ERPModel.FK_DiaChi_XaPhuong", "XaPhuong").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_XaPhuong1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<XaPhuong>("ERPModel.FK_DiaChi_XaPhuong", "XaPhuong").Value = value;
    				On_XaPhuong1_Changed(this.XaPhuong1);//\\//
    			}
    	    }
        }
    	public static String XaPhuong1_ReferencePropertyName { get { return "XaPhuong1"; } }
    	partial void On_XaPhuong1_Changing(ref XaPhuong newValue, ref bool stopChanging);
    	partial void On_XaPhuong1_Changed(XaPhuong currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<XaPhuong> XaPhuong1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<XaPhuong>("ERPModel.FK_DiaChi_XaPhuong", "XaPhuong");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<XaPhuong>("ERPModel.FK_DiaChi_XaPhuong", "XaPhuong", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HoSo_DiaChiThuongTru", "HoSo")]
        public EntityCollection<HoSo> HoSoes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HoSo>("ERPModel.FK_HoSo_DiaChiThuongTru", "HoSo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HoSoes_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HoSo>("ERPModel.FK_HoSo_DiaChiThuongTru", "HoSo", value);
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HoSo_NoiOHienNay", "HoSo")]
        public EntityCollection<HoSo> HoSoes1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HoSo>("ERPModel.FK_HoSo_NoiOHienNay", "HoSo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HoSoes1_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HoSo>("ERPModel.FK_HoSo_NoiOHienNay", "HoSo", value);
    					On_HoSoes1_Changed(this.HoSoes1);//\\//
    				}
    			}
            }
        }
    	public static String HoSoes1_EntityCollectionPropertyName { get { return "HoSoes1"; } }
    	partial void On_HoSoes1_Changing(ref EntityCollection<HoSo> newValue, ref bool stopChanging);
    	partial void On_HoSoes1_Changed(EntityCollection<HoSo> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HoSo_NoiSinh", "HoSo")]
        public EntityCollection<HoSo> HoSoes2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HoSo>("ERPModel.FK_HoSo_NoiSinh", "HoSo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HoSoes2_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HoSo>("ERPModel.FK_HoSo_NoiSinh", "HoSo", value);
    					On_HoSoes2_Changed(this.HoSoes2);//\\//
    				}
    			}
            }
        }
    	public static String HoSoes2_EntityCollectionPropertyName { get { return "HoSoes2"; } }
    	partial void On_HoSoes2_Changing(ref EntityCollection<HoSo> newValue, ref bool stopChanging);
    	partial void On_HoSoes2_Changed(EntityCollection<HoSo> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HoSo_QueQuan", "HoSo")]
        public EntityCollection<HoSo> HoSoes3
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HoSo>("ERPModel.FK_HoSo_QueQuan", "HoSo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HoSoes3_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HoSo>("ERPModel.FK_HoSo_QueQuan", "HoSo", value);
    					On_HoSoes3_Changed(this.HoSoes3);//\\//
    				}
    			}
            }
        }
    	public static String HoSoes3_EntityCollectionPropertyName { get { return "HoSoes3"; } }
    	partial void On_HoSoes3_Changing(ref EntityCollection<HoSo> newValue, ref bool stopChanging);
    	partial void On_HoSoes3_Changed(EntityCollection<HoSo> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "QuyetDinhNghiHuu")]
        public EntityCollection<QuyetDinhNghiHuu> QuyetDinhNghiHuus
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<QuyetDinhNghiHuu>("ERPModel.FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "QuyetDinhNghiHuu");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_QuyetDinhNghiHuus_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<QuyetDinhNghiHuu>("ERPModel.FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "QuyetDinhNghiHuu", value);
    					On_QuyetDinhNghiHuus_Changed(this.QuyetDinhNghiHuus);//\\//
    				}
    			}
            }
        }
    	public static String QuyetDinhNghiHuus_EntityCollectionPropertyName { get { return "QuyetDinhNghiHuus"; } }
    	partial void On_QuyetDinhNghiHuus_Changing(ref EntityCollection<QuyetDinhNghiHuu> newValue, ref bool stopChanging);
    	partial void On_QuyetDinhNghiHuus_Changed(EntityCollection<QuyetDinhNghiHuu> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinhThoiViec_NoiCuTruSauKhiThoiViec", "QuyetDinhThoiViec")]
        public EntityCollection<QuyetDinhThoiViec> QuyetDinhThoiViecs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<QuyetDinhThoiViec>("ERPModel.FK_QuyetDinhThoiViec_NoiCuTruSauKhiThoiViec", "QuyetDinhThoiViec");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_QuyetDinhThoiViecs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<QuyetDinhThoiViec>("ERPModel.FK_QuyetDinhThoiViec_NoiCuTruSauKhiThoiViec", "QuyetDinhThoiViec", value);
    					On_QuyetDinhThoiViecs_Changed(this.QuyetDinhThoiViecs);//\\//
    				}
    			}
            }
        }
    	public static String QuyetDinhThoiViecs_EntityCollectionPropertyName { get { return "QuyetDinhThoiViecs"; } }
    	partial void On_QuyetDinhThoiViecs_Changing(ref EntityCollection<QuyetDinhThoiViec> newValue, ref bool stopChanging);
    	partial void On_QuyetDinhThoiViecs_Changed(EntityCollection<QuyetDinhThoiViec> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HopDong_NoiSinh", "HopDong")]
        public EntityCollection<HopDong> HopDongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HopDong>("ERPModel.FK_HopDong_NoiSinh", "HopDong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HopDongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HopDong>("ERPModel.FK_HopDong_NoiSinh", "HopDong", value);
    					On_HopDongs_Changed(this.HopDongs);//\\//
    				}
    			}
            }
        }
    	public static String HopDongs_EntityCollectionPropertyName { get { return "HopDongs"; } }
    	partial void On_HopDongs_Changing(ref EntityCollection<HopDong> newValue, ref bool stopChanging);
    	partial void On_HopDongs_Changed(EntityCollection<HopDong> currentValue);

        #endregion

    }
}