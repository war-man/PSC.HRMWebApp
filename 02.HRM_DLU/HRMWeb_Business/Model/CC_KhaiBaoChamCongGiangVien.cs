//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi SERVERERP\tai luc 05:27:29 ngay 19/04/2017
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_KhaiBaoChamCongGiangVien")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_KhaiBaoChamCongGiangVien : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_KhaiBaoChamCongGiangVien()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_KhaiBaoChamCongGiangVien()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_KhaiBaoChamCongGiangVien object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_KhaiBaoChamCongGiangVien CreateCC_KhaiBaoChamCongGiangVien(System.Guid oid)
        {
            CC_KhaiBaoChamCongGiangVien cC_KhaiBaoChamCongGiangVien = new CC_KhaiBaoChamCongGiangVien();
            cC_KhaiBaoChamCongGiangVien.Oid = oid;
            return cC_KhaiBaoChamCongGiangVien;
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
        public Nullable<byte> Buoi
        {
            get
            {
                return _buoi;
            }
            set
            {
    			Nullable<byte> oldValue =  _buoi;
    			bool stopChanging = false;
                On_Buoi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Buoi");
    			if(!stopChanging)
    			{
    				_buoi = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Buoi");
    				On_Buoi_Changed(oldValue, _buoi);//\\
    			}
            }
        }
    	public static String Buoi_PropertyName { get { return "Buoi"; } }
        private Nullable<byte> _buoi;
        partial void On_Buoi_Changing(Nullable<byte> currentValue, ref Nullable<byte> newValue, ref bool stopChanging);
        partial void On_Buoi_Changed(Nullable<byte> oldValue, Nullable<byte> currentValue);
    
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

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_KhaiBaoChamCongGiangVien_ThongTinNhanVien", "ThongTinNhanVien")]
        public ThongTinNhanVien ThongTinNhanVien
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_KhaiBaoChamCongGiangVien_ThongTinNhanVien", "ThongTinNhanVien").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_ThongTinNhanVien_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_KhaiBaoChamCongGiangVien_ThongTinNhanVien", "ThongTinNhanVien").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_KhaiBaoChamCongGiangVien_ThongTinNhanVien", "ThongTinNhanVien");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ThongTinNhanVien>("ERPModel.FK_CC_KhaiBaoChamCongGiangVien_ThongTinNhanVien", "ThongTinNhanVien", value);
                }
            }
        }

        #endregion

    }
}
