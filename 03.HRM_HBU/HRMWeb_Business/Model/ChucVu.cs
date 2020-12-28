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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="ChucVu")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ChucVu : ERP_Core.BaseEntityObject//EntityObject
    {
    	static ChucVu()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public ChucVu()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new ChucVu object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static ChucVu CreateChucVu(System.Guid oid)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.Oid = oid;
            return chucVu;
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
        public Nullable<int> ThuTu
        {
            get
            {
                return _thuTu;
            }
            set
            {
    			Nullable<int> oldValue =  _thuTu;
    			bool stopChanging = false;
                On_ThuTu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThuTu");
    			if(!stopChanging)
    			{
    				_thuTu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThuTu");
    				On_ThuTu_Changed(oldValue, _thuTu);//\\
    			}
            }
        }
    	public static String ThuTu_PropertyName { get { return "ThuTu"; } }
        private Nullable<int> _thuTu;
        partial void On_ThuTu_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_ThuTu_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
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
        public string TenChucVu
        {
            get
            {
                return _tenChucVu;
            }
            set
            {
    			string oldValue =  _tenChucVu;
    			bool stopChanging = false;
                On_TenChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenChucVu");
    			if(!stopChanging)
    			{
    				_tenChucVu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenChucVu");
    				On_TenChucVu_Changed(oldValue, _tenChucVu);//\\
    			}
            }
        }
    	public static String TenChucVu_PropertyName { get { return "TenChucVu"; } }
        private string _tenChucVu;
        partial void On_TenChucVu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenChucVu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<byte> PhanLoai
        {
            get
            {
                return _phanLoai;
            }
            set
            {
    			Nullable<byte> oldValue =  _phanLoai;
    			bool stopChanging = false;
                On_PhanLoai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhanLoai");
    			if(!stopChanging)
    			{
    				_phanLoai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhanLoai");
    				On_PhanLoai_Changed(oldValue, _phanLoai);//\\
    			}
            }
        }
    	public static String PhanLoai_PropertyName { get { return "PhanLoai"; } }
        private Nullable<byte> _phanLoai;
        partial void On_PhanLoai_Changing(Nullable<byte> currentValue, ref Nullable<byte> newValue, ref bool stopChanging);
        partial void On_PhanLoai_Changed(Nullable<byte> oldValue, Nullable<byte> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCChucVu
        {
            get
            {
                return _hSPCChucVu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCChucVu;
    			bool stopChanging = false;
                On_HSPCChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCChucVu");
    			if(!stopChanging)
    			{
    				_hSPCChucVu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCChucVu");
    				On_HSPCChucVu_Changed(oldValue, _hSPCChucVu);//\\
    			}
            }
        }
    	public static String HSPCChucVu_PropertyName { get { return "HSPCChucVu"; } }
        private Nullable<decimal> _hSPCChucVu;
        partial void On_HSPCChucVu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCChucVu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCQuanLy
        {
            get
            {
                return _hSPCQuanLy;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCQuanLy;
    			bool stopChanging = false;
                On_HSPCQuanLy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCQuanLy");
    			if(!stopChanging)
    			{
    				_hSPCQuanLy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCQuanLy");
    				On_HSPCQuanLy_Changed(oldValue, _hSPCQuanLy);//\\
    			}
            }
        }
    	public static String HSPCQuanLy_PropertyName { get { return "HSPCQuanLy"; } }
        private Nullable<decimal> _hSPCQuanLy;
        partial void On_HSPCQuanLy_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCQuanLy_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> PhuCapDienThoai
        {
            get
            {
                return _phuCapDienThoai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _phuCapDienThoai;
    			bool stopChanging = false;
                On_PhuCapDienThoai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhuCapDienThoai");
    			if(!stopChanging)
    			{
    				_phuCapDienThoai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhuCapDienThoai");
    				On_PhuCapDienThoai_Changed(oldValue, _phuCapDienThoai);//\\
    			}
            }
        }
    	public static String PhuCapDienThoai_PropertyName { get { return "PhuCapDienThoai"; } }
        private Nullable<decimal> _phuCapDienThoai;
        partial void On_PhuCapDienThoai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_PhuCapDienThoai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoLitXang
        {
            get
            {
                return _soLitXang;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soLitXang;
    			bool stopChanging = false;
                On_SoLitXang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoLitXang");
    			if(!stopChanging)
    			{
    				_soLitXang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoLitXang");
    				On_SoLitXang_Changed(oldValue, _soLitXang);//\\
    			}
            }
        }
    	public static String SoLitXang_PropertyName { get { return "SoLitXang"; } }
        private Nullable<decimal> _soLitXang;
        partial void On_SoLitXang_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoLitXang_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
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
        public Nullable<decimal> TyTrongDiemDanhGia
        {
            get
            {
                return _tyTrongDiemDanhGia;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tyTrongDiemDanhGia;
    			bool stopChanging = false;
                On_TyTrongDiemDanhGia_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TyTrongDiemDanhGia");
    			if(!stopChanging)
    			{
    				_tyTrongDiemDanhGia = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TyTrongDiemDanhGia");
    				On_TyTrongDiemDanhGia_Changed(oldValue, _tyTrongDiemDanhGia);//\\
    			}
            }
        }
    	public static String TyTrongDiemDanhGia_PropertyName { get { return "TyTrongDiemDanhGia"; } }
        private Nullable<decimal> _tyTrongDiemDanhGia;
        partial void On_TyTrongDiemDanhGia_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TyTrongDiemDanhGia_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> LaQuanLy
        {
            get
            {
                return _laQuanLy;
            }
            set
            {
    			Nullable<bool> oldValue =  _laQuanLy;
    			bool stopChanging = false;
                On_LaQuanLy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LaQuanLy");
    			if(!stopChanging)
    			{
    				_laQuanLy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LaQuanLy");
    				On_LaQuanLy_Changed(oldValue, _laQuanLy);//\\
    			}
            }
        }
    	public static String LaQuanLy_PropertyName { get { return "LaQuanLy"; } }
        private Nullable<bool> _laQuanLy;
        partial void On_LaQuanLy_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_LaQuanLy_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HeSoTCDLD
        {
            get
            {
                return _heSoTCDLD;
            }
            set
            {
    			Nullable<decimal> oldValue =  _heSoTCDLD;
    			bool stopChanging = false;
                On_HeSoTCDLD_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HeSoTCDLD");
    			if(!stopChanging)
    			{
    				_heSoTCDLD = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HeSoTCDLD");
    				On_HeSoTCDLD_Changed(oldValue, _heSoTCDLD);//\\
    			}
            }
        }
    	public static String HeSoTCDLD_PropertyName { get { return "HeSoTCDLD"; } }
        private Nullable<decimal> _heSoTCDLD;
        partial void On_HeSoTCDLD_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HeSoTCDLD_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HeSoTNTT
        {
            get
            {
                return _heSoTNTT;
            }
            set
            {
    			Nullable<decimal> oldValue =  _heSoTNTT;
    			bool stopChanging = false;
                On_HeSoTNTT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HeSoTNTT");
    			if(!stopChanging)
    			{
    				_heSoTNTT = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HeSoTNTT");
    				On_HeSoTNTT_Changed(oldValue, _heSoTNTT);//\\
    			}
            }
        }
    	public static String HeSoTNTT_PropertyName { get { return "HeSoTNTT"; } }
        private Nullable<decimal> _heSoTNTT;
        partial void On_HeSoTNTT_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HeSoTNTT_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }
            set
            {
    			string oldValue =  _ghiChu;
    			bool stopChanging = false;
                On_GhiChu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GhiChu");
    			if(!stopChanging)
    			{
    				_ghiChu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("GhiChu");
    				On_GhiChu_Changed(oldValue, _ghiChu);//\\
    			}
            }
        }
    	public static String GhiChu_PropertyName { get { return "GhiChu"; } }
        private string _ghiChu;
        partial void On_GhiChu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_GhiChu_Changed(string oldValue, string currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_ThongTinNhanVien_ChucVu", "ThongTinNhanVien")]
        public EntityCollection<ThongTinNhanVien> ThongTinNhanViens
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ThongTinNhanVien>("ERPModel.FK_ThongTinNhanVien_ChucVu", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_ThongTinNhanViens_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ThongTinNhanVien>("ERPModel.FK_ThongTinNhanVien_ChucVu", "ThongTinNhanVien", value);
    					On_ThongTinNhanViens_Changed(this.ThongTinNhanViens);//\\//
    				}
    			}
            }
        }
    	public static String ThongTinNhanViens_EntityCollectionPropertyName { get { return "ThongTinNhanViens"; } }
    	partial void On_ThongTinNhanViens_Changing(ref EntityCollection<ThongTinNhanVien> newValue, ref bool stopChanging);
    	partial void On_ThongTinNhanViens_Changed(EntityCollection<ThongTinNhanVien> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_ThongTinNhanVien_ChucVuCoQuanCaoNhat", "ThongTinNhanVien")]
        public EntityCollection<ThongTinNhanVien> ThongTinNhanViens1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ThongTinNhanVien>("ERPModel.FK_ThongTinNhanVien_ChucVuCoQuanCaoNhat", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_ThongTinNhanViens1_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ThongTinNhanVien>("ERPModel.FK_ThongTinNhanVien_ChucVuCoQuanCaoNhat", "ThongTinNhanVien", value);
    					On_ThongTinNhanViens1_Changed(this.ThongTinNhanViens1);//\\//
    				}
    			}
            }
        }
    	public static String ThongTinNhanViens1_EntityCollectionPropertyName { get { return "ThongTinNhanViens1"; } }
    	partial void On_ThongTinNhanViens1_Changing(ref EntityCollection<ThongTinNhanVien> newValue, ref bool stopChanging);
    	partial void On_ThongTinNhanViens1_Changed(EntityCollection<ThongTinNhanVien> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_ThongTinNhanVien_ChucVuKiemNhiem", "ThongTinNhanVien")]
        public EntityCollection<ThongTinNhanVien> ThongTinNhanViens2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ThongTinNhanVien>("ERPModel.FK_ThongTinNhanVien_ChucVuKiemNhiem", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_ThongTinNhanViens2_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ThongTinNhanVien>("ERPModel.FK_ThongTinNhanVien_ChucVuKiemNhiem", "ThongTinNhanVien", value);
    					On_ThongTinNhanViens2_Changed(this.ThongTinNhanViens2);//\\//
    				}
    			}
            }
        }
    	public static String ThongTinNhanViens2_EntityCollectionPropertyName { get { return "ThongTinNhanViens2"; } }
    	partial void On_ThongTinNhanViens2_Changing(ref EntityCollection<ThongTinNhanVien> newValue, ref bool stopChanging);
    	partial void On_ThongTinNhanViens2_Changed(EntityCollection<ThongTinNhanVien> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_ThongTinTinhLuong_ChucVu", "ThongTinTinhLuong")]
        public EntityCollection<ThongTinTinhLuong> ThongTinTinhLuongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ThongTinTinhLuong>("ERPModel.FK_ThongTinTinhLuong_ChucVu", "ThongTinTinhLuong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_ThongTinTinhLuongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ThongTinTinhLuong>("ERPModel.FK_ThongTinTinhLuong_ChucVu", "ThongTinTinhLuong", value);
    					On_ThongTinTinhLuongs_Changed(this.ThongTinTinhLuongs);//\\//
    				}
    			}
            }
        }
    	public static String ThongTinTinhLuongs_EntityCollectionPropertyName { get { return "ThongTinTinhLuongs"; } }
    	partial void On_ThongTinTinhLuongs_Changing(ref EntityCollection<ThongTinTinhLuong> newValue, ref bool stopChanging);
    	partial void On_ThongTinTinhLuongs_Changed(EntityCollection<ThongTinTinhLuong> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_ThongTinTinhLuong_ChucVuKiemNhiem", "ThongTinTinhLuong")]
        public EntityCollection<ThongTinTinhLuong> ThongTinTinhLuongs1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ThongTinTinhLuong>("ERPModel.FK_ThongTinTinhLuong_ChucVuKiemNhiem", "ThongTinTinhLuong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_ThongTinTinhLuongs1_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ThongTinTinhLuong>("ERPModel.FK_ThongTinTinhLuong_ChucVuKiemNhiem", "ThongTinTinhLuong", value);
    					On_ThongTinTinhLuongs1_Changed(this.ThongTinTinhLuongs1);//\\//
    				}
    			}
            }
        }
    	public static String ThongTinTinhLuongs1_EntityCollectionPropertyName { get { return "ThongTinTinhLuongs1"; } }
    	partial void On_ThongTinTinhLuongs1_Changing(ref EntityCollection<ThongTinTinhLuong> newValue, ref bool stopChanging);
    	partial void On_ThongTinTinhLuongs1_Changed(EntityCollection<ThongTinTinhLuong> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinh_ChucVuNguoiKy", "QuyetDinh")]
        public EntityCollection<QuyetDinh> QuyetDinhs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<QuyetDinh>("ERPModel.FK_QuyetDinh_ChucVuNguoiKy", "QuyetDinh");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_QuyetDinhs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<QuyetDinh>("ERPModel.FK_QuyetDinh_ChucVuNguoiKy", "QuyetDinh", value);
    					On_QuyetDinhs_Changed(this.QuyetDinhs);//\\//
    				}
    			}
            }
        }
    	public static String QuyetDinhs_EntityCollectionPropertyName { get { return "QuyetDinhs"; } }
    	partial void On_QuyetDinhs_Changing(ref EntityCollection<QuyetDinh> newValue, ref bool stopChanging);
    	partial void On_QuyetDinhs_Changed(EntityCollection<QuyetDinh> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HopDong_ChucVuNguoiKy", "HopDong")]
        public EntityCollection<HopDong> HopDongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HopDong>("ERPModel.FK_HopDong_ChucVuNguoiKy", "HopDong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HopDongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HopDong>("ERPModel.FK_HopDong_ChucVuNguoiKy", "HopDong", value);
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
