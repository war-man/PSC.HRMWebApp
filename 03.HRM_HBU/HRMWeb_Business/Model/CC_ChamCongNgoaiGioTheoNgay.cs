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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_ChamCongNgoaiGioTheoNgay")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_ChamCongNgoaiGioTheoNgay : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_ChamCongNgoaiGioTheoNgay()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_ChamCongNgoaiGioTheoNgay()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_ChamCongNgoaiGioTheoNgay object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_ChamCongNgoaiGioTheoNgay CreateCC_ChamCongNgoaiGioTheoNgay(System.Guid oid)
        {
            CC_ChamCongNgoaiGioTheoNgay cC_ChamCongNgoaiGioTheoNgay = new CC_ChamCongNgoaiGioTheoNgay();
            cC_ChamCongNgoaiGioTheoNgay.Oid = oid;
            return cC_ChamCongNgoaiGioTheoNgay;
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
        public Nullable<System.Guid> IDNhanVien
        {
            get
            {
                return _iDNhanVien;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _iDNhanVien;
    			bool stopChanging = false;
                On_IDNhanVien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("IDNhanVien");
    			if(!stopChanging)
    			{
    				_iDNhanVien = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("IDNhanVien");
    				On_IDNhanVien_Changed(oldValue, _iDNhanVien);//\\
    			}
            }
        }
    	public static String IDNhanVien_PropertyName { get { return "IDNhanVien"; } }
        private Nullable<System.Guid> _iDNhanVien;
        partial void On_IDNhanVien_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_IDNhanVien_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> Ngay
        {
            get
            {
                return _ngay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngay;
    			bool stopChanging = false;
                On_Ngay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Ngay");
    			if(!stopChanging)
    			{
    				_ngay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Ngay");
    				On_Ngay_Changed(oldValue, _ngay);//\\
    			}
            }
        }
    	public static String Ngay_PropertyName { get { return "Ngay"; } }
        private Nullable<System.DateTime> _ngay;
        partial void On_Ngay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_Ngay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> IDBoPhan
        {
            get
            {
                return _iDBoPhan;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _iDBoPhan;
    			bool stopChanging = false;
                On_IDBoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("IDBoPhan");
    			if(!stopChanging)
    			{
    				_iDBoPhan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("IDBoPhan");
    				On_IDBoPhan_Changed(oldValue, _iDBoPhan);//\\
    			}
            }
        }
    	public static String IDBoPhan_PropertyName { get { return "IDBoPhan"; } }
        private Nullable<System.Guid> _iDBoPhan;
        partial void On_IDBoPhan_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_IDBoPhan_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoCongNgoaiGio
        {
            get
            {
                return _soCongNgoaiGio;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soCongNgoaiGio;
    			bool stopChanging = false;
                On_SoCongNgoaiGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoCongNgoaiGio");
    			if(!stopChanging)
    			{
    				_soCongNgoaiGio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoCongNgoaiGio");
    				On_SoCongNgoaiGio_Changed(oldValue, _soCongNgoaiGio);//\\
    			}
            }
        }
    	public static String SoCongNgoaiGio_PropertyName { get { return "SoCongNgoaiGio"; } }
        private Nullable<decimal> _soCongNgoaiGio;
        partial void On_SoCongNgoaiGio_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoCongNgoaiGio_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoCongNgoaiGioSau23Gio
        {
            get
            {
                return _soCongNgoaiGioSau23Gio;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soCongNgoaiGioSau23Gio;
    			bool stopChanging = false;
                On_SoCongNgoaiGioSau23Gio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoCongNgoaiGioSau23Gio");
    			if(!stopChanging)
    			{
    				_soCongNgoaiGioSau23Gio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoCongNgoaiGioSau23Gio");
    				On_SoCongNgoaiGioSau23Gio_Changed(oldValue, _soCongNgoaiGioSau23Gio);//\\
    			}
            }
        }
    	public static String SoCongNgoaiGioSau23Gio_PropertyName { get { return "SoCongNgoaiGioSau23Gio"; } }
        private Nullable<decimal> _soCongNgoaiGioSau23Gio;
        partial void On_SoCongNgoaiGioSau23Gio_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoCongNgoaiGioSau23Gio_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoCongNgoaiGioT7CN
        {
            get
            {
                return _soCongNgoaiGioT7CN;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soCongNgoaiGioT7CN;
    			bool stopChanging = false;
                On_SoCongNgoaiGioT7CN_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoCongNgoaiGioT7CN");
    			if(!stopChanging)
    			{
    				_soCongNgoaiGioT7CN = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoCongNgoaiGioT7CN");
    				On_SoCongNgoaiGioT7CN_Changed(oldValue, _soCongNgoaiGioT7CN);//\\
    			}
            }
        }
    	public static String SoCongNgoaiGioT7CN_PropertyName { get { return "SoCongNgoaiGioT7CN"; } }
        private Nullable<decimal> _soCongNgoaiGioT7CN;
        partial void On_SoCongNgoaiGioT7CN_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoCongNgoaiGioT7CN_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoCongNgoaiGioT7CNSau23Gio
        {
            get
            {
                return _soCongNgoaiGioT7CNSau23Gio;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soCongNgoaiGioT7CNSau23Gio;
    			bool stopChanging = false;
                On_SoCongNgoaiGioT7CNSau23Gio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoCongNgoaiGioT7CNSau23Gio");
    			if(!stopChanging)
    			{
    				_soCongNgoaiGioT7CNSau23Gio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoCongNgoaiGioT7CNSau23Gio");
    				On_SoCongNgoaiGioT7CNSau23Gio_Changed(oldValue, _soCongNgoaiGioT7CNSau23Gio);//\\
    			}
            }
        }
    	public static String SoCongNgoaiGioT7CNSau23Gio_PropertyName { get { return "SoCongNgoaiGioT7CNSau23Gio"; } }
        private Nullable<decimal> _soCongNgoaiGioT7CNSau23Gio;
        partial void On_SoCongNgoaiGioT7CNSau23Gio_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoCongNgoaiGioT7CNSau23Gio_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoCongNgoaiGioLe
        {
            get
            {
                return _soCongNgoaiGioLe;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soCongNgoaiGioLe;
    			bool stopChanging = false;
                On_SoCongNgoaiGioLe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoCongNgoaiGioLe");
    			if(!stopChanging)
    			{
    				_soCongNgoaiGioLe = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoCongNgoaiGioLe");
    				On_SoCongNgoaiGioLe_Changed(oldValue, _soCongNgoaiGioLe);//\\
    			}
            }
        }
    	public static String SoCongNgoaiGioLe_PropertyName { get { return "SoCongNgoaiGioLe"; } }
        private Nullable<decimal> _soCongNgoaiGioLe;
        partial void On_SoCongNgoaiGioLe_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoCongNgoaiGioLe_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoCongNgoaiGioLeSau23Gio
        {
            get
            {
                return _soCongNgoaiGioLeSau23Gio;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soCongNgoaiGioLeSau23Gio;
    			bool stopChanging = false;
                On_SoCongNgoaiGioLeSau23Gio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoCongNgoaiGioLeSau23Gio");
    			if(!stopChanging)
    			{
    				_soCongNgoaiGioLeSau23Gio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoCongNgoaiGioLeSau23Gio");
    				On_SoCongNgoaiGioLeSau23Gio_Changed(oldValue, _soCongNgoaiGioLeSau23Gio);//\\
    			}
            }
        }
    	public static String SoCongNgoaiGioLeSau23Gio_PropertyName { get { return "SoCongNgoaiGioLeSau23Gio"; } }
        private Nullable<decimal> _soCongNgoaiGioLeSau23Gio;
        partial void On_SoCongNgoaiGioLeSau23Gio_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoCongNgoaiGioLeSau23Gio_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> IDUser
        {
            get
            {
                return _iDUser;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _iDUser;
    			bool stopChanging = false;
                On_IDUser_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("IDUser");
    			if(!stopChanging)
    			{
    				_iDUser = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("IDUser");
    				On_IDUser_Changed(oldValue, _iDUser);//\\
    			}
            }
        }
    	public static String IDUser_PropertyName { get { return "IDUser"; } }
        private Nullable<System.Guid> _iDUser;
        partial void On_IDUser_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_IDUser_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TuGio
        {
            get
            {
                return _tuGio;
            }
            set
            {
    			string oldValue =  _tuGio;
    			bool stopChanging = false;
                On_TuGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuGio");
    			if(!stopChanging)
    			{
    				_tuGio = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TuGio");
    				On_TuGio_Changed(oldValue, _tuGio);//\\
    			}
            }
        }
    	public static String TuGio_PropertyName { get { return "TuGio"; } }
        private string _tuGio;
        partial void On_TuGio_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TuGio_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DenGio
        {
            get
            {
                return _denGio;
            }
            set
            {
    			string oldValue =  _denGio;
    			bool stopChanging = false;
                On_DenGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenGio");
    			if(!stopChanging)
    			{
    				_denGio = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DenGio");
    				On_DenGio_Changed(oldValue, _denGio);//\\
    			}
            }
        }
    	public static String DenGio_PropertyName { get { return "DenGio"; } }
        private string _denGio;
        partial void On_DenGio_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DenGio_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> DaSuaTrenWeb
        {
            get
            {
                return _daSuaTrenWeb;
            }
            set
            {
    			Nullable<bool> oldValue =  _daSuaTrenWeb;
    			bool stopChanging = false;
                On_DaSuaTrenWeb_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DaSuaTrenWeb");
    			if(!stopChanging)
    			{
    				_daSuaTrenWeb = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DaSuaTrenWeb");
    				On_DaSuaTrenWeb_Changed(oldValue, _daSuaTrenWeb);//\\
    			}
            }
        }
    	public static String DaSuaTrenWeb_PropertyName { get { return "DaSuaTrenWeb"; } }
        private Nullable<bool> _daSuaTrenWeb;
        partial void On_DaSuaTrenWeb_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_DaSuaTrenWeb_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongNgoaiGioTheoNgay_ThongTinNhanVien", "ThongTinNhanVien")]
        public ThongTinNhanVien ThongTinNhanVien
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_ThongTinNhanVien", "ThongTinNhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ThongTinNhanVien_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_ThongTinNhanVien", "ThongTinNhanVien").Value = value;
    				On_ThongTinNhanVien_Changed(this.ThongTinNhanVien);//\\//
    			}
    	    }
        }
    	public static String ThongTinNhanVien_ReferencePropertyName { get { return "ThongTinNhanVien"; } }
    	partial void On_ThongTinNhanVien_Changing(ref ThongTinNhanVien newValue, ref bool stopChanging);
    	partial void On_ThongTinNhanVien_Changed(ThongTinNhanVien currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ThongTinNhanVien> ThongTinNhanVienReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_ThongTinNhanVien", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_ThongTinNhanVien", "ThongTinNhanVien", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongNgoaiGioTheoNgayThayDoi_CC_ChamCongNgoaiGioTheoNgay", "CC_ChamCongNgoaiGioTheoNgayThayDoi")]
        public CC_ChamCongNgoaiGioTheoNgayThayDoi CC_ChamCongNgoaiGioTheoNgayThayDoi
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongNgoaiGioTheoNgayThayDoi>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgayThayDoi_CC_ChamCongNgoaiGioTheoNgay", "CC_ChamCongNgoaiGioTheoNgayThayDoi").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_ChamCongNgoaiGioTheoNgayThayDoi_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongNgoaiGioTheoNgayThayDoi>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgayThayDoi_CC_ChamCongNgoaiGioTheoNgay", "CC_ChamCongNgoaiGioTheoNgayThayDoi").Value = value;
    				On_CC_ChamCongNgoaiGioTheoNgayThayDoi_Changed(this.CC_ChamCongNgoaiGioTheoNgayThayDoi);//\\//
    			}
    	    }
        }
    	public static String CC_ChamCongNgoaiGioTheoNgayThayDoi_ReferencePropertyName { get { return "CC_ChamCongNgoaiGioTheoNgayThayDoi"; } }
    	partial void On_CC_ChamCongNgoaiGioTheoNgayThayDoi_Changing(ref CC_ChamCongNgoaiGioTheoNgayThayDoi newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongNgoaiGioTheoNgayThayDoi_Changed(CC_ChamCongNgoaiGioTheoNgayThayDoi currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_ChamCongNgoaiGioTheoNgayThayDoi> CC_ChamCongNgoaiGioTheoNgayThayDoiReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongNgoaiGioTheoNgayThayDoi>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgayThayDoi_CC_ChamCongNgoaiGioTheoNgay", "CC_ChamCongNgoaiGioTheoNgayThayDoi");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_ChamCongNgoaiGioTheoNgayThayDoi>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgayThayDoi_CC_ChamCongNgoaiGioTheoNgay", "CC_ChamCongNgoaiGioTheoNgayThayDoi", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongNgoaiGioTheoNgay_BoPhan", "BoPhan")]
        public BoPhan BoPhan
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_BoPhan", "BoPhan").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_BoPhan_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_BoPhan", "BoPhan").Value = value;
    				On_BoPhan_Changed(this.BoPhan);//\\//
    			}
    	    }
        }
    	public static String BoPhan_ReferencePropertyName { get { return "BoPhan"; } }
    	partial void On_BoPhan_Changing(ref BoPhan newValue, ref bool stopChanging);
    	partial void On_BoPhan_Changed(BoPhan currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BoPhan> BoPhanReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_BoPhan", "BoPhan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BoPhan>("ERPModel.FK_CC_ChamCongNgoaiGioTheoNgay_BoPhan", "BoPhan", value);
                }
            }
        }

        #endregion

    }
}