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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="GiangVienThinhGiang")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class GiangVienThinhGiang : ERP_Core.BaseEntityObject//EntityObject
    {
    	static GiangVienThinhGiang()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public GiangVienThinhGiang()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new GiangVienThinhGiang object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static GiangVienThinhGiang CreateGiangVienThinhGiang(System.Guid oid)
        {
            GiangVienThinhGiang giangVienThinhGiang = new GiangVienThinhGiang();
            giangVienThinhGiang.Oid = oid;
            return giangVienThinhGiang;
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
        public Nullable<System.Guid> TaiBoMon
        {
            get
            {
                return _taiBoMon;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _taiBoMon;
    			bool stopChanging = false;
                On_TaiBoMon_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TaiBoMon");
    			if(!stopChanging)
    			{
    				_taiBoMon = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TaiBoMon");
    				On_TaiBoMon_Changed(oldValue, _taiBoMon);//\\
    			}
            }
        }
    	public static String TaiBoMon_PropertyName { get { return "TaiBoMon"; } }
        private Nullable<System.Guid> _taiBoMon;
        partial void On_TaiBoMon_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_TaiBoMon_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> HocVi
        {
            get
            {
                return _hocVi;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _hocVi;
    			bool stopChanging = false;
                On_HocVi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HocVi");
    			if(!stopChanging)
    			{
    				_hocVi = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HocVi");
    				On_HocVi_Changed(oldValue, _hocVi);//\\
    			}
            }
        }
    	public static String HocVi_PropertyName { get { return "HocVi"; } }
        private Nullable<System.Guid> _hocVi;
        partial void On_HocVi_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_HocVi_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DonViCongTac
        {
            get
            {
                return _donViCongTac;
            }
            set
            {
    			string oldValue =  _donViCongTac;
    			bool stopChanging = false;
                On_DonViCongTac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DonViCongTac");
    			if(!stopChanging)
    			{
    				_donViCongTac = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DonViCongTac");
    				On_DonViCongTac_Changed(oldValue, _donViCongTac);//\\
    			}
            }
        }
    	public static String DonViCongTac_PropertyName { get { return "DonViCongTac"; } }
        private string _donViCongTac;
        partial void On_DonViCongTac_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DonViCongTac_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TaiLieuGiangDay
        {
            get
            {
                return _taiLieuGiangDay;
            }
            set
            {
    			string oldValue =  _taiLieuGiangDay;
    			bool stopChanging = false;
                On_TaiLieuGiangDay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TaiLieuGiangDay");
    			if(!stopChanging)
    			{
    				_taiLieuGiangDay = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TaiLieuGiangDay");
    				On_TaiLieuGiangDay_Changed(oldValue, _taiLieuGiangDay);//\\
    			}
            }
        }
    	public static String TaiLieuGiangDay_PropertyName { get { return "TaiLieuGiangDay"; } }
        private string _taiLieuGiangDay;
        partial void On_TaiLieuGiangDay_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TaiLieuGiangDay_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string CMND_ThinhGiang
        {
            get
            {
                return _cMND_ThinhGiang;
            }
            set
            {
    			string oldValue =  _cMND_ThinhGiang;
    			bool stopChanging = false;
                On_CMND_ThinhGiang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CMND_ThinhGiang");
    			if(!stopChanging)
    			{
    				_cMND_ThinhGiang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("CMND_ThinhGiang");
    				On_CMND_ThinhGiang_Changed(oldValue, _cMND_ThinhGiang);//\\
    			}
            }
        }
    	public static String CMND_ThinhGiang_PropertyName { get { return "CMND_ThinhGiang"; } }
        private string _cMND_ThinhGiang;
        partial void On_CMND_ThinhGiang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_CMND_ThinhGiang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> KhongTinhThuLao
        {
            get
            {
                return _khongTinhThuLao;
            }
            set
            {
    			Nullable<bool> oldValue =  _khongTinhThuLao;
    			bool stopChanging = false;
                On_KhongTinhThuLao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KhongTinhThuLao");
    			if(!stopChanging)
    			{
    				_khongTinhThuLao = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KhongTinhThuLao");
    				On_KhongTinhThuLao_Changed(oldValue, _khongTinhThuLao);//\\
    			}
            }
        }
    	public static String KhongTinhThuLao_PropertyName { get { return "KhongTinhThuLao"; } }
        private Nullable<bool> _khongTinhThuLao;
        partial void On_KhongTinhThuLao_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_KhongTinhThuLao_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string MaThinhGiang
        {
            get
            {
                return _maThinhGiang;
            }
            set
            {
    			string oldValue =  _maThinhGiang;
    			bool stopChanging = false;
                On_MaThinhGiang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MaThinhGiang");
    			if(!stopChanging)
    			{
    				_maThinhGiang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("MaThinhGiang");
    				On_MaThinhGiang_Changed(oldValue, _maThinhGiang);//\\
    			}
            }
        }
    	public static String MaThinhGiang_PropertyName { get { return "MaThinhGiang"; } }
        private string _maThinhGiang;
        partial void On_MaThinhGiang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_MaThinhGiang_Changed(string oldValue, string currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_GiangVienThinhGiang_TaiBoMon", "BoPhan")]
        public BoPhan BoPhan
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_GiangVienThinhGiang_TaiBoMon", "BoPhan").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_BoPhan_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_GiangVienThinhGiang_TaiBoMon", "BoPhan").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BoPhan>("ERPModel.FK_GiangVienThinhGiang_TaiBoMon", "BoPhan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BoPhan>("ERPModel.FK_GiangVienThinhGiang_TaiBoMon", "BoPhan", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_GiangVienThinhGiang_Oid", "NhanVien")]
        public NhanVien NhanVien
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NhanVien>("ERPModel.FK_GiangVienThinhGiang_Oid", "NhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_NhanVien_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NhanVien>("ERPModel.FK_GiangVienThinhGiang_Oid", "NhanVien").Value = value;
    				On_NhanVien_Changed(this.NhanVien);//\\//
    			}
    	    }
        }
    	public static String NhanVien_ReferencePropertyName { get { return "NhanVien"; } }
    	partial void On_NhanVien_Changing(ref NhanVien newValue, ref bool stopChanging);
    	partial void On_NhanVien_Changed(NhanVien currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<NhanVien> NhanVienReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NhanVien>("ERPModel.FK_GiangVienThinhGiang_Oid", "NhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<NhanVien>("ERPModel.FK_GiangVienThinhGiang_Oid", "NhanVien", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_WebUsers_GiangVienThinhGiang", "WebUser")]
        public EntityCollection<WebUser> WebUsers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<WebUser>("ERPModel.FK_WebUsers_GiangVienThinhGiang", "WebUser");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_WebUsers_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<WebUser>("ERPModel.FK_WebUsers_GiangVienThinhGiang", "WebUser", value);
    					On_WebUsers_Changed(this.WebUsers);//\\//
    				}
    			}
            }
        }
    	public static String WebUsers_EntityCollectionPropertyName { get { return "WebUsers"; } }
    	partial void On_WebUsers_Changing(ref EntityCollection<WebUser> newValue, ref bool stopChanging);
    	partial void On_WebUsers_Changed(EntityCollection<WebUser> currentValue);

        #endregion

    }
}
