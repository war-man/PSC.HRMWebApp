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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_KyChamCong")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_KyChamCong : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_KyChamCong()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_KyChamCong()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_KyChamCong object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        /// <param name="thang">Initial value of the Thang property.</param>
        /// <param name="tuNgay">Initial value of the TuNgay property.</param>
        /// <param name="denNgay">Initial value of the DenNgay property.</param>
        /// <param name="nam">Initial value of the Nam property.</param>
        public static CC_KyChamCong CreateCC_KyChamCong(System.Guid oid, int thang, System.DateTime tuNgay, System.DateTime denNgay, int nam)
        {
            CC_KyChamCong cC_KyChamCong = new CC_KyChamCong();
            cC_KyChamCong.Oid = oid;
            cC_KyChamCong.Thang = thang;
            cC_KyChamCong.TuNgay = tuNgay;
            cC_KyChamCong.DenNgay = denNgay;
            cC_KyChamCong.Nam = nam;
            return cC_KyChamCong;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public int Thang
        {
            get
            {
                return _thang;
            }
            set
            {
    			int oldValue =  _thang;
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
        private int _thang;
        partial void On_Thang_Changing(int currentValue, ref int newValue, ref bool stopChanging);
        partial void On_Thang_Changed(int oldValue, int currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public System.DateTime TuNgay
        {
            get
            {
                return _tuNgay;
            }
            set
            {
    			System.DateTime oldValue =  _tuNgay;
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
        private System.DateTime _tuNgay;
        partial void On_TuNgay_Changing(System.DateTime currentValue, ref System.DateTime newValue, ref bool stopChanging);
        partial void On_TuNgay_Changed(System.DateTime oldValue, System.DateTime currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public System.DateTime DenNgay
        {
            get
            {
                return _denNgay;
            }
            set
            {
    			System.DateTime oldValue =  _denNgay;
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
        private System.DateTime _denNgay;
        partial void On_DenNgay_Changing(System.DateTime currentValue, ref System.DateTime newValue, ref bool stopChanging);
        partial void On_DenNgay_Changed(System.DateTime oldValue, System.DateTime currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public int Nam
        {
            get
            {
                return _nam;
            }
            set
            {
    			int oldValue =  _nam;
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
        private int _nam;
        partial void On_Nam_Changing(int currentValue, ref int newValue, ref bool stopChanging);
        partial void On_Nam_Changed(int oldValue, int currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuanLyChamCongNhanVien_CC_KyChamCong", "QuanLyChamCongNhanVien")]
        public EntityCollection<QuanLyChamCongNhanVien> QuanLyChamCongNhanViens
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<QuanLyChamCongNhanVien>("ERPModel.FK_QuanLyChamCongNhanVien_CC_KyChamCong", "QuanLyChamCongNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_QuanLyChamCongNhanViens_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<QuanLyChamCongNhanVien>("ERPModel.FK_QuanLyChamCongNhanVien_CC_KyChamCong", "QuanLyChamCongNhanVien", value);
    					On_QuanLyChamCongNhanViens_Changed(this.QuanLyChamCongNhanViens);//\\//
    				}
    			}
            }
        }
    	public static String QuanLyChamCongNhanViens_EntityCollectionPropertyName { get { return "QuanLyChamCongNhanViens"; } }
    	partial void On_QuanLyChamCongNhanViens_Changing(ref EntityCollection<QuanLyChamCongNhanVien> newValue, ref bool stopChanging);
    	partial void On_QuanLyChamCongNhanViens_Changed(EntityCollection<QuanLyChamCongNhanVien> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_BangChamCongNgoaiGio_CC_KyChamCong", "BangChamCongNgoaiGio")]
        public EntityCollection<BangChamCongNgoaiGio> BangChamCongNgoaiGios
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BangChamCongNgoaiGio>("ERPModel.FK_BangChamCongNgoaiGio_CC_KyChamCong", "BangChamCongNgoaiGio");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_BangChamCongNgoaiGios_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BangChamCongNgoaiGio>("ERPModel.FK_BangChamCongNgoaiGio_CC_KyChamCong", "BangChamCongNgoaiGio", value);
    					On_BangChamCongNgoaiGios_Changed(this.BangChamCongNgoaiGios);//\\//
    				}
    			}
            }
        }
    	public static String BangChamCongNgoaiGios_EntityCollectionPropertyName { get { return "BangChamCongNgoaiGios"; } }
    	partial void On_BangChamCongNgoaiGios_Changing(ref EntityCollection<BangChamCongNgoaiGio> newValue, ref bool stopChanging);
    	partial void On_BangChamCongNgoaiGios_Changed(EntityCollection<BangChamCongNgoaiGio> currentValue);

        #endregion

    }
}
