//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 09:24:55 ngay 29/02/2020
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_DangKyKhungGioLamViec")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_DangKyKhungGioLamViec : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_DangKyKhungGioLamViec()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_DangKyKhungGioLamViec()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_DangKyKhungGioLamViec object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_DangKyKhungGioLamViec CreateCC_DangKyKhungGioLamViec(System.Guid oid)
        {
            CC_DangKyKhungGioLamViec cC_DangKyKhungGioLamViec = new CC_DangKyKhungGioLamViec();
            cC_DangKyKhungGioLamViec.Oid = oid;
            return cC_DangKyKhungGioLamViec;
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
        public Nullable<System.Guid> CaChamCong
        {
            get
            {
                return _caChamCong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _caChamCong;
    			bool stopChanging = false;
                On_CaChamCong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CaChamCong");
    			if(!stopChanging)
    			{
    				_caChamCong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CaChamCong");
    				On_CaChamCong_Changed(oldValue, _caChamCong);//\\
    			}
            }
        }
    	public static String CaChamCong_PropertyName { get { return "CaChamCong"; } }
        private Nullable<System.Guid> _caChamCong;
        partial void On_CaChamCong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_CaChamCong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> KyDangKy
        {
            get
            {
                return _kyDangKy;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _kyDangKy;
    			bool stopChanging = false;
                On_KyDangKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KyDangKy");
    			if(!stopChanging)
    			{
    				_kyDangKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KyDangKy");
    				On_KyDangKy_Changed(oldValue, _kyDangKy);//\\
    			}
            }
        }
    	public static String KyDangKy_PropertyName { get { return "KyDangKy"; } }
        private Nullable<System.Guid> _kyDangKy;
        partial void On_KyDangKy_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_KyDangKy_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_KyDangKyKhungGio")]
        public CC_KyDangKyKhungGio CC_KyDangKyKhungGio
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_KyDangKyKhungGio>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_KyDangKyKhungGio").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_KyDangKyKhungGio_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_KyDangKyKhungGio>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_KyDangKyKhungGio").Value = value;
    				On_CC_KyDangKyKhungGio_Changed(this.CC_KyDangKyKhungGio);//\\//
    			}
    	    }
        }
    	public static String CC_KyDangKyKhungGio_ReferencePropertyName { get { return "CC_KyDangKyKhungGio"; } }
    	partial void On_CC_KyDangKyKhungGio_Changing(ref CC_KyDangKyKhungGio newValue, ref bool stopChanging);
    	partial void On_CC_KyDangKyKhungGio_Changed(CC_KyDangKyKhungGio currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_KyDangKyKhungGio> CC_KyDangKyKhungGioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_KyDangKyKhungGio>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_KyDangKyKhungGio");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_KyDangKyKhungGio>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_KyDangKyKhungGio", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_ThongTinNhanVien", "ThongTinNhanVien")]
        public ThongTinNhanVien ThongTinNhanVien1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyKhungGioLamViec_ThongTinNhanVien", "ThongTinNhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ThongTinNhanVien1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyKhungGioLamViec_ThongTinNhanVien", "ThongTinNhanVien").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyKhungGioLamViec_ThongTinNhanVien", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_DangKyKhungGioLamViec_ThongTinNhanVien", "ThongTinNhanVien", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_CaChamCong")]
        public CC_CaChamCong CC_CaChamCong
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_CaChamCong>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_CaChamCong").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_CaChamCong_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_CaChamCong>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_CaChamCong").Value = value;
    				On_CC_CaChamCong_Changed(this.CC_CaChamCong);//\\//
    			}
    	    }
        }
    	public static String CC_CaChamCong_ReferencePropertyName { get { return "CC_CaChamCong"; } }
    	partial void On_CC_CaChamCong_Changing(ref CC_CaChamCong newValue, ref bool stopChanging);
    	partial void On_CC_CaChamCong_Changed(CC_CaChamCong currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_CaChamCong> CC_CaChamCongReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_CaChamCong>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_CaChamCong");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_CaChamCong>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_CaChamCong", value);
                }
            }
        }

        #endregion

    }
}
