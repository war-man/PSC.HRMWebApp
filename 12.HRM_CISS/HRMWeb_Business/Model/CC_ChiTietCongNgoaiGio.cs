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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_ChiTietCongNgoaiGio")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_ChiTietCongNgoaiGio : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_ChiTietCongNgoaiGio()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_ChiTietCongNgoaiGio()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_ChiTietCongNgoaiGio object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_ChiTietCongNgoaiGio CreateCC_ChiTietCongNgoaiGio(System.Guid oid)
        {
            CC_ChiTietCongNgoaiGio cC_ChiTietCongNgoaiGio = new CC_ChiTietCongNgoaiGio();
            cC_ChiTietCongNgoaiGio.Oid = oid;
            return cC_ChiTietCongNgoaiGio;
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
        public Nullable<System.Guid> QuanLyCongNgoaiGio
        {
            get
            {
                return _quanLyCongNgoaiGio;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _quanLyCongNgoaiGio;
    			bool stopChanging = false;
                On_QuanLyCongNgoaiGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanLyCongNgoaiGio");
    			if(!stopChanging)
    			{
    				_quanLyCongNgoaiGio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("QuanLyCongNgoaiGio");
    				On_QuanLyCongNgoaiGio_Changed(oldValue, _quanLyCongNgoaiGio);//\\
    			}
            }
        }
    	public static String QuanLyCongNgoaiGio_PropertyName { get { return "QuanLyCongNgoaiGio"; } }
        private Nullable<System.Guid> _quanLyCongNgoaiGio;
        partial void On_QuanLyCongNgoaiGio_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_QuanLyCongNgoaiGio_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> BoPhan
        {
            get
            {
                return _boPhan;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _boPhan;
    			bool stopChanging = false;
                On_BoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BoPhan");
    			if(!stopChanging)
    			{
    				_boPhan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("BoPhan");
    				On_BoPhan_Changed(oldValue, _boPhan);//\\
    			}
            }
        }
    	public static String BoPhan_PropertyName { get { return "BoPhan"; } }
        private Nullable<System.Guid> _boPhan;
        partial void On_BoPhan_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_BoPhan_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ThongTinNhanVien
        {
            get
            {
                return _thongTinNhanVien;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _thongTinNhanVien;
    			bool stopChanging = false;
                On_ThongTinNhanVien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThongTinNhanVien");
    			if(!stopChanging)
    			{
    				_thongTinNhanVien = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThongTinNhanVien");
    				On_ThongTinNhanVien_Changed(oldValue, _thongTinNhanVien);//\\
    			}
            }
        }
    	public static String ThongTinNhanVien_PropertyName { get { return "ThongTinNhanVien"; } }
        private Nullable<System.Guid> _thongTinNhanVien;
        partial void On_ThongTinNhanVien_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ThongTinNhanVien_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DienGiai
        {
            get
            {
                return _dienGiai;
            }
            set
            {
    			string oldValue =  _dienGiai;
    			bool stopChanging = false;
                On_DienGiai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DienGiai");
    			if(!stopChanging)
    			{
    				_dienGiai = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DienGiai");
    				On_DienGiai_Changed(oldValue, _dienGiai);//\\
    			}
            }
        }
    	public static String DienGiai_PropertyName { get { return "DienGiai"; } }
        private string _dienGiai;
        partial void On_DienGiai_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DienGiai_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> GCRecord
        {
            get
            {
                return _gCRecord;
            }
            set
            {
    			Nullable<decimal> oldValue =  _gCRecord;
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
        private Nullable<decimal> _gCRecord;
        partial void On_GCRecord_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_GCRecord_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
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
        public Nullable<decimal> TongSoGio_CT
        {
            get
            {
                return _tongSoGio_CT;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoGio_CT;
    			bool stopChanging = false;
                On_TongSoGio_CT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoGio_CT");
    			if(!stopChanging)
    			{
    				_tongSoGio_CT = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoGio_CT");
    				On_TongSoGio_CT_Changed(oldValue, _tongSoGio_CT);//\\
    			}
            }
        }
    	public static String TongSoGio_CT_PropertyName { get { return "TongSoGio_CT"; } }
        private Nullable<decimal> _tongSoGio_CT;
        partial void On_TongSoGio_CT_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoGio_CT_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongSoGio_KCT
        {
            get
            {
                return _tongSoGio_KCT;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoGio_KCT;
    			bool stopChanging = false;
                On_TongSoGio_KCT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoGio_KCT");
    			if(!stopChanging)
    			{
    				_tongSoGio_KCT = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoGio_KCT");
    				On_TongSoGio_KCT_Changed(oldValue, _tongSoGio_KCT);//\\
    			}
            }
        }
    	public static String TongSoGio_KCT_PropertyName { get { return "TongSoGio_KCT"; } }
        private Nullable<decimal> _tongSoGio_KCT;
        partial void On_TongSoGio_KCT_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoGio_KCT_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> CongChuanTheoLoaiGioLamViec
        {
            get
            {
                return _congChuanTheoLoaiGioLamViec;
            }
            set
            {
    			Nullable<decimal> oldValue =  _congChuanTheoLoaiGioLamViec;
    			bool stopChanging = false;
                On_CongChuanTheoLoaiGioLamViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CongChuanTheoLoaiGioLamViec");
    			if(!stopChanging)
    			{
    				_congChuanTheoLoaiGioLamViec = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CongChuanTheoLoaiGioLamViec");
    				On_CongChuanTheoLoaiGioLamViec_Changed(oldValue, _congChuanTheoLoaiGioLamViec);//\\
    			}
            }
        }
    	public static String CongChuanTheoLoaiGioLamViec_PropertyName { get { return "CongChuanTheoLoaiGioLamViec"; } }
        private Nullable<decimal> _congChuanTheoLoaiGioLamViec;
        partial void On_CongChuanTheoLoaiGioLamViec_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_CongChuanTheoLoaiGioLamViec_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> NgayPhepBuTrongThang
        {
            get
            {
                return _ngayPhepBuTrongThang;
            }
            set
            {
    			Nullable<decimal> oldValue =  _ngayPhepBuTrongThang;
    			bool stopChanging = false;
                On_NgayPhepBuTrongThang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayPhepBuTrongThang");
    			if(!stopChanging)
    			{
    				_ngayPhepBuTrongThang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayPhepBuTrongThang");
    				On_NgayPhepBuTrongThang_Changed(oldValue, _ngayPhepBuTrongThang);//\\
    			}
            }
        }
    	public static String NgayPhepBuTrongThang_PropertyName { get { return "NgayPhepBuTrongThang"; } }
        private Nullable<decimal> _ngayPhepBuTrongThang;
        partial void On_NgayPhepBuTrongThang_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_NgayPhepBuTrongThang_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongNgayPhepBu
        {
            get
            {
                return _tongNgayPhepBu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongNgayPhepBu;
    			bool stopChanging = false;
                On_TongNgayPhepBu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNgayPhepBu");
    			if(!stopChanging)
    			{
    				_tongNgayPhepBu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNgayPhepBu");
    				On_TongNgayPhepBu_Changed(oldValue, _tongNgayPhepBu);//\\
    			}
            }
        }
    	public static String TongNgayPhepBu_PropertyName { get { return "TongNgayPhepBu"; } }
        private Nullable<decimal> _tongNgayPhepBu;
        partial void On_TongNgayPhepBu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongNgayPhepBu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoNgayBuConLai
        {
            get
            {
                return _soNgayBuConLai;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soNgayBuConLai;
    			bool stopChanging = false;
                On_SoNgayBuConLai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoNgayBuConLai");
    			if(!stopChanging)
    			{
    				_soNgayBuConLai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoNgayBuConLai");
    				On_SoNgayBuConLai_Changed(oldValue, _soNgayBuConLai);//\\
    			}
            }
        }
    	public static String SoNgayBuConLai_PropertyName { get { return "SoNgayBuConLai"; } }
        private Nullable<decimal> _soNgayBuConLai;
        partial void On_SoNgayBuConLai_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoNgayBuConLai_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoGioNgayThuong
        {
            get
            {
                return _soGioNgayThuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soGioNgayThuong;
    			bool stopChanging = false;
                On_SoGioNgayThuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoGioNgayThuong");
    			if(!stopChanging)
    			{
    				_soGioNgayThuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoGioNgayThuong");
    				On_SoGioNgayThuong_Changed(oldValue, _soGioNgayThuong);//\\
    			}
            }
        }
    	public static String SoGioNgayThuong_PropertyName { get { return "SoGioNgayThuong"; } }
        private Nullable<decimal> _soGioNgayThuong;
        partial void On_SoGioNgayThuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoGioNgayThuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoGioNgayNghi
        {
            get
            {
                return _soGioNgayNghi;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soGioNgayNghi;
    			bool stopChanging = false;
                On_SoGioNgayNghi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoGioNgayNghi");
    			if(!stopChanging)
    			{
    				_soGioNgayNghi = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoGioNgayNghi");
    				On_SoGioNgayNghi_Changed(oldValue, _soGioNgayNghi);//\\
    			}
            }
        }
    	public static String SoGioNgayNghi_PropertyName { get { return "SoGioNgayNghi"; } }
        private Nullable<decimal> _soGioNgayNghi;
        partial void On_SoGioNgayNghi_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoGioNgayNghi_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoGioNgayLe
        {
            get
            {
                return _soGioNgayLe;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soGioNgayLe;
    			bool stopChanging = false;
                On_SoGioNgayLe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoGioNgayLe");
    			if(!stopChanging)
    			{
    				_soGioNgayLe = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoGioNgayLe");
    				On_SoGioNgayLe_Changed(oldValue, _soGioNgayLe);//\\
    			}
            }
        }
    	public static String SoGioNgayLe_PropertyName { get { return "SoGioNgayLe"; } }
        private Nullable<decimal> _soGioNgayLe;
        partial void On_SoGioNgayLe_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoGioNgayLe_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChiTietCongNgoaiGio_QuanLyCongNgoaiGio", "CC_QuanLyCongNgoaiGio")]
        public CC_QuanLyCongNgoaiGio CC_QuanLyCongNgoaiGio
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_QuanLyCongNgoaiGio>("ERPModel.FK_CC_ChiTietCongNgoaiGio_QuanLyCongNgoaiGio", "CC_QuanLyCongNgoaiGio").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_QuanLyCongNgoaiGio_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_QuanLyCongNgoaiGio>("ERPModel.FK_CC_ChiTietCongNgoaiGio_QuanLyCongNgoaiGio", "CC_QuanLyCongNgoaiGio").Value = value;
    				On_CC_QuanLyCongNgoaiGio_Changed(this.CC_QuanLyCongNgoaiGio);//\\//
    			}
    	    }
        }
    	public static String CC_QuanLyCongNgoaiGio_ReferencePropertyName { get { return "CC_QuanLyCongNgoaiGio"; } }
    	partial void On_CC_QuanLyCongNgoaiGio_Changing(ref CC_QuanLyCongNgoaiGio newValue, ref bool stopChanging);
    	partial void On_CC_QuanLyCongNgoaiGio_Changed(CC_QuanLyCongNgoaiGio currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_QuanLyCongNgoaiGio> CC_QuanLyCongNgoaiGioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_QuanLyCongNgoaiGio>("ERPModel.FK_CC_ChiTietCongNgoaiGio_QuanLyCongNgoaiGio", "CC_QuanLyCongNgoaiGio");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_QuanLyCongNgoaiGio>("ERPModel.FK_CC_ChiTietCongNgoaiGio_QuanLyCongNgoaiGio", "CC_QuanLyCongNgoaiGio", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChiTietCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien")]
        public ThongTinNhanVien ThongTinNhanVien1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ThongTinNhanVien1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien").Value = value;
    				On_ThongTinNhanVien1_Changed(this.ThongTinNhanVien1);//\\//
    			}
    	    }
        }
    	public static String ThongTinNhanVien1_ReferencePropertyName { get { return "ThongTinNhanVien1"; } }
    	partial void On_ThongTinNhanVien1_Changing(ref ThongTinNhanVien newValue, ref bool stopChanging);
    	partial void On_ThongTinNhanVien1_Changed(ThongTinNhanVien currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ThongTinNhanVien> ThongTinNhanVien1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChiTietCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChiTietCongNgoaiGio_BoPhan", "BoPhan")]
        public BoPhan BoPhan1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietCongNgoaiGio_BoPhan", "BoPhan").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_BoPhan1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietCongNgoaiGio_BoPhan", "BoPhan").Value = value;
    				On_BoPhan1_Changed(this.BoPhan1);//\\//
    			}
    	    }
        }
    	public static String BoPhan1_ReferencePropertyName { get { return "BoPhan1"; } }
    	partial void On_BoPhan1_Changing(ref BoPhan newValue, ref bool stopChanging);
    	partial void On_BoPhan1_Changed(BoPhan currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BoPhan> BoPhan1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietCongNgoaiGio_BoPhan", "BoPhan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BoPhan>("ERPModel.FK_CC_ChiTietCongNgoaiGio_BoPhan", "BoPhan", value);
                }
            }
        }

        #endregion

    }
}
