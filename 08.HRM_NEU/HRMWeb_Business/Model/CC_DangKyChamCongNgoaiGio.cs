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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_DangKyChamCongNgoaiGio")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_DangKyChamCongNgoaiGio : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_DangKyChamCongNgoaiGio()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_DangKyChamCongNgoaiGio()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_DangKyChamCongNgoaiGio object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_DangKyChamCongNgoaiGio CreateCC_DangKyChamCongNgoaiGio(System.Guid oid)
        {
            CC_DangKyChamCongNgoaiGio cC_DangKyChamCongNgoaiGio = new CC_DangKyChamCongNgoaiGio();
            cC_DangKyChamCongNgoaiGio.Oid = oid;
            return cC_DangKyChamCongNgoaiGio;
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
        public Nullable<decimal> SoPhutThucTe
        {
            get
            {
                return _soPhutThucTe;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soPhutThucTe;
    			bool stopChanging = false;
                On_SoPhutThucTe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoPhutThucTe");
    			if(!stopChanging)
    			{
    				_soPhutThucTe = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoPhutThucTe");
    				On_SoPhutThucTe_Changed(oldValue, _soPhutThucTe);//\\
    			}
            }
        }
    	public static String SoPhutThucTe_PropertyName { get { return "SoPhutThucTe"; } }
        private Nullable<decimal> _soPhutThucTe;
        partial void On_SoPhutThucTe_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoPhutThucTe_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoPhutDangKy
        {
            get
            {
                return _soPhutDangKy;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soPhutDangKy;
    			bool stopChanging = false;
                On_SoPhutDangKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoPhutDangKy");
    			if(!stopChanging)
    			{
    				_soPhutDangKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoPhutDangKy");
    				On_SoPhutDangKy_Changed(oldValue, _soPhutDangKy);//\\
    			}
            }
        }
    	public static String SoPhutDangKy_PropertyName { get { return "SoPhutDangKy"; } }
        private Nullable<decimal> _soPhutDangKy;
        partial void On_SoPhutDangKy_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoPhutDangKy_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> LyDo
        {
            get
            {
                return _lyDo;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _lyDo;
    			bool stopChanging = false;
                On_LyDo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LyDo");
    			if(!stopChanging)
    			{
    				_lyDo = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LyDo");
    				On_LyDo_Changed(oldValue, _lyDo);//\\
    			}
            }
        }
    	public static String LyDo_PropertyName { get { return "LyDo"; } }
        private Nullable<System.Guid> _lyDo;
        partial void On_LyDo_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_LyDo_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<byte> Duyet
        {
            get
            {
                return _duyet;
            }
            set
            {
    			Nullable<byte> oldValue =  _duyet;
    			bool stopChanging = false;
                On_Duyet_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Duyet");
    			if(!stopChanging)
    			{
    				_duyet = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Duyet");
    				On_Duyet_Changed(oldValue, _duyet);//\\
    			}
            }
        }
    	public static String Duyet_PropertyName { get { return "Duyet"; } }
        private Nullable<byte> _duyet;
        partial void On_Duyet_Changing(Nullable<byte> currentValue, ref Nullable<byte> newValue, ref bool stopChanging);
        partial void On_Duyet_Changed(Nullable<byte> oldValue, Nullable<byte> currentValue);
    
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

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_LyDoDangKyChamCongNgoaiGio")]
        public CC_LyDoDangKyChamCongNgoaiGio CC_LyDoDangKyChamCongNgoaiGio
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_LyDoDangKyChamCongNgoaiGio>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_LyDoDangKyChamCongNgoaiGio").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_LyDoDangKyChamCongNgoaiGio_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_LyDoDangKyChamCongNgoaiGio>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_LyDoDangKyChamCongNgoaiGio").Value = value;
    				On_CC_LyDoDangKyChamCongNgoaiGio_Changed(this.CC_LyDoDangKyChamCongNgoaiGio);//\\//
    			}
    	    }
        }
    	public static String CC_LyDoDangKyChamCongNgoaiGio_ReferencePropertyName { get { return "CC_LyDoDangKyChamCongNgoaiGio"; } }
    	partial void On_CC_LyDoDangKyChamCongNgoaiGio_Changing(ref CC_LyDoDangKyChamCongNgoaiGio newValue, ref bool stopChanging);
    	partial void On_CC_LyDoDangKyChamCongNgoaiGio_Changed(CC_LyDoDangKyChamCongNgoaiGio currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_LyDoDangKyChamCongNgoaiGio> CC_LyDoDangKyChamCongNgoaiGioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_LyDoDangKyChamCongNgoaiGio>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_LyDoDangKyChamCongNgoaiGio");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_LyDoDangKyChamCongNgoaiGio>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_LyDoDangKyChamCongNgoaiGio", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyChamCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien")]
        public ThongTinNhanVien ThongTinNhanVien
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ThongTinNhanVien_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyChamCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien", value);
                }
            }
        }

        #endregion

    }
}
