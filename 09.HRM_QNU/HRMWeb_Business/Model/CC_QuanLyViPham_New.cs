//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 04:34:42 ngay 13/09/2018
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_QuanLyViPham_New")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_QuanLyViPham_New : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_QuanLyViPham_New()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_QuanLyViPham_New()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_QuanLyViPham_New object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_QuanLyViPham_New CreateCC_QuanLyViPham_New(System.Guid oid)
        {
            CC_QuanLyViPham_New cC_QuanLyViPham_New = new CC_QuanLyViPham_New();
            cC_QuanLyViPham_New.Oid = oid;
            return cC_QuanLyViPham_New;
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
        public string ChuoiHinhThucViPham
        {
            get
            {
                return _chuoiHinhThucViPham;
            }
            set
            {
    			string oldValue =  _chuoiHinhThucViPham;
    			bool stopChanging = false;
                On_ChuoiHinhThucViPham_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChuoiHinhThucViPham");
    			if(!stopChanging)
    			{
    				_chuoiHinhThucViPham = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChuoiHinhThucViPham");
    				On_ChuoiHinhThucViPham_Changed(oldValue, _chuoiHinhThucViPham);//\\
    			}
            }
        }
    	public static String ChuoiHinhThucViPham_PropertyName { get { return "ChuoiHinhThucViPham"; } }
        private string _chuoiHinhThucViPham;
        partial void On_ChuoiHinhThucViPham_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChuoiHinhThucViPham_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChuoiGioQuet
        {
            get
            {
                return _chuoiGioQuet;
            }
            set
            {
    			string oldValue =  _chuoiGioQuet;
    			bool stopChanging = false;
                On_ChuoiGioQuet_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChuoiGioQuet");
    			if(!stopChanging)
    			{
    				_chuoiGioQuet = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChuoiGioQuet");
    				On_ChuoiGioQuet_Changed(oldValue, _chuoiGioQuet);//\\
    			}
            }
        }
    	public static String ChuoiGioQuet_PropertyName { get { return "ChuoiGioQuet"; } }
        private string _chuoiGioQuet;
        partial void On_ChuoiGioQuet_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChuoiGioQuet_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> CC_ChamCongTheoNgay
        {
            get
            {
                return _cC_ChamCongTheoNgay;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _cC_ChamCongTheoNgay;
    			bool stopChanging = false;
                On_CC_ChamCongTheoNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CC_ChamCongTheoNgay");
    			if(!stopChanging)
    			{
    				_cC_ChamCongTheoNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CC_ChamCongTheoNgay");
    				On_CC_ChamCongTheoNgay_Changed(oldValue, _cC_ChamCongTheoNgay);//\\
    			}
            }
        }
    	public static String CC_ChamCongTheoNgay_PropertyName { get { return "CC_ChamCongTheoNgay"; } }
        private Nullable<System.Guid> _cC_ChamCongTheoNgay;
        partial void On_CC_ChamCongTheoNgay_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_CC_ChamCongTheoNgay_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_cc_QuanLyViPham_New_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay")]
        public CC_ChamCongTheoNgay CC_ChamCongTheoNgay1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_New_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_CC_ChamCongTheoNgay1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_New_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay").Value = value;
    				On_CC_ChamCongTheoNgay1_Changed(this.CC_ChamCongTheoNgay1);//\\//
    			}
    	    }
        }
    	public static String CC_ChamCongTheoNgay1_ReferencePropertyName { get { return "CC_ChamCongTheoNgay1"; } }
    	partial void On_CC_ChamCongTheoNgay1_Changing(ref CC_ChamCongTheoNgay newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongTheoNgay1_Changed(CC_ChamCongTheoNgay currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CC_ChamCongTheoNgay> CC_ChamCongTheoNgay1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_New_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CC_ChamCongTheoNgay>("ERPModel.FK_cc_QuanLyViPham_New_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay", value);
                }
            }
        }

        #endregion

    }
}
