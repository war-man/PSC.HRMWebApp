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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_QuanLyViPham")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_QuanLyViPham : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_QuanLyViPham()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_QuanLyViPham()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_QuanLyViPham object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_QuanLyViPham CreateCC_QuanLyViPham(System.Guid oid)
        {
            CC_QuanLyViPham cC_QuanLyViPham = new CC_QuanLyViPham();
            cC_QuanLyViPham.Oid = oid;
            return cC_QuanLyViPham;
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
        public Nullable<System.Guid> cc_HinhThucViPham
        {
            get
            {
                return _cc_HinhThucViPham;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _cc_HinhThucViPham;
    			bool stopChanging = false;
                On_cc_HinhThucViPham_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("cc_HinhThucViPham");
    			if(!stopChanging)
    			{
    				_cc_HinhThucViPham = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("cc_HinhThucViPham");
    				On_cc_HinhThucViPham_Changed(oldValue, _cc_HinhThucViPham);//\\
    			}
            }
        }
    	public static String cc_HinhThucViPham_PropertyName { get { return "cc_HinhThucViPham"; } }
        private Nullable<System.Guid> _cc_HinhThucViPham;
        partial void On_cc_HinhThucViPham_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_cc_HinhThucViPham_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> ThoiGianTre
        {
            get
            {
                return _thoiGianTre;
            }
            set
            {
    			Nullable<int> oldValue =  _thoiGianTre;
    			bool stopChanging = false;
                On_ThoiGianTre_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianTre");
    			if(!stopChanging)
    			{
    				_thoiGianTre = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThoiGianTre");
    				On_ThoiGianTre_Changed(oldValue, _thoiGianTre);//\\
    			}
            }
        }
    	public static String ThoiGianTre_PropertyName { get { return "ThoiGianTre"; } }
        private Nullable<int> _thoiGianTre;
        partial void On_ThoiGianTre_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_ThoiGianTre_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> ThoiGianSom
        {
            get
            {
                return _thoiGianSom;
            }
            set
            {
    			Nullable<int> oldValue =  _thoiGianSom;
    			bool stopChanging = false;
                On_ThoiGianSom_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianSom");
    			if(!stopChanging)
    			{
    				_thoiGianSom = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThoiGianSom");
    				On_ThoiGianSom_Changed(oldValue, _thoiGianSom);//\\
    			}
            }
        }
    	public static String ThoiGianSom_PropertyName { get { return "ThoiGianSom"; } }
        private Nullable<int> _thoiGianSom;
        partial void On_ThoiGianSom_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_ThoiGianSom_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ChamCongTheoNgay
        {
            get
            {
                return _chamCongTheoNgay;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _chamCongTheoNgay;
    			bool stopChanging = false;
                On_ChamCongTheoNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChamCongTheoNgay");
    			if(!stopChanging)
    			{
    				_chamCongTheoNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ChamCongTheoNgay");
    				On_ChamCongTheoNgay_Changed(oldValue, _chamCongTheoNgay);//\\
    			}
            }
        }
    	public static String ChamCongTheoNgay_PropertyName { get { return "ChamCongTheoNgay"; } }
        private Nullable<System.Guid> _chamCongTheoNgay;
        partial void On_ChamCongTheoNgay_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ChamCongTheoNgay_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_cc_QuanLyViPham_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay")]
        public CC_ChamCongTheoNgay CC_ChamCongTheoNgay
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_ChamCongTheoNgay_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay").Value = value;
    				On_CC_ChamCongTheoNgay_Changed(this.CC_ChamCongTheoNgay);//\\//
    			}
    	    }
        }
    	public static String CC_ChamCongTheoNgay_ReferencePropertyName { get { return "CC_ChamCongTheoNgay"; } }
    	partial void On_CC_ChamCongTheoNgay_Changing(ref CC_ChamCongTheoNgay newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongTheoNgay_Changed(CC_ChamCongTheoNgay currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_ChamCongTheoNgay> CC_ChamCongTheoNgayReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_cc_QuanLyViPham_cc_HinhThucViPham", "CC_HinhThucViPham")]
        public CC_HinhThucViPham CC_HinhThucViPham1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_HinhThucViPham>("ERPModel.FK_cc_QuanLyViPham_cc_HinhThucViPham", "CC_HinhThucViPham").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_HinhThucViPham1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_HinhThucViPham>("ERPModel.FK_cc_QuanLyViPham_cc_HinhThucViPham", "CC_HinhThucViPham").Value = value;
    				On_CC_HinhThucViPham1_Changed(this.CC_HinhThucViPham1);//\\//
    			}
    	    }
        }
    	public static String CC_HinhThucViPham1_ReferencePropertyName { get { return "CC_HinhThucViPham1"; } }
    	partial void On_CC_HinhThucViPham1_Changing(ref CC_HinhThucViPham newValue, ref bool stopChanging);
    	partial void On_CC_HinhThucViPham1_Changed(CC_HinhThucViPham currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_HinhThucViPham> CC_HinhThucViPham1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_HinhThucViPham>("ERPModel.FK_cc_QuanLyViPham_cc_HinhThucViPham", "CC_HinhThucViPham");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_HinhThucViPham>("ERPModel.FK_cc_QuanLyViPham_cc_HinhThucViPham", "CC_HinhThucViPham", value);
                }
            }
        }

        #endregion

    }
}
