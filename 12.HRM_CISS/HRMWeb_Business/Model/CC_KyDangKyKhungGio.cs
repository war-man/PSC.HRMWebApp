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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_KyDangKyKhungGio")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_KyDangKyKhungGio : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_KyDangKyKhungGio()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_KyDangKyKhungGio()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_KyDangKyKhungGio object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_KyDangKyKhungGio CreateCC_KyDangKyKhungGio(System.Guid oid)
        {
            CC_KyDangKyKhungGio cC_KyDangKyKhungGio = new CC_KyDangKyKhungGio();
            cC_KyDangKyKhungGio.Oid = oid;
            return cC_KyDangKyKhungGio;
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
        public string TenKy
        {
            get
            {
                return _tenKy;
            }
            set
            {
    			string oldValue =  _tenKy;
    			bool stopChanging = false;
                On_TenKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenKy");
    			if(!stopChanging)
    			{
    				_tenKy = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenKy");
    				On_TenKy_Changed(oldValue, _tenKy);//\\
    			}
            }
        }
    	public static String TenKy_PropertyName { get { return "TenKy"; } }
        private string _tenKy;
        partial void On_TenKy_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenKy_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> TuNgay
        {
            get
            {
                return _tuNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _tuNgay;
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
        private Nullable<System.DateTime> _tuNgay;
        partial void On_TuNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_TuNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> DenNgay
        {
            get
            {
                return _denNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _denNgay;
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
        private Nullable<System.DateTime> _denNgay;
        partial void On_DenNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_DenNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_DangKyKhungGioLamViec")]
        public EntityCollection<CC_DangKyKhungGioLamViec> CC_DangKyKhungGioLamViec
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_DangKyKhungGioLamViec>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_DangKyKhungGioLamViec");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_DangKyKhungGioLamViec_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_DangKyKhungGioLamViec>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_DangKyKhungGioLamViec", value);
    					On_CC_DangKyKhungGioLamViec_Changed(this.CC_DangKyKhungGioLamViec);//\\//
    				}
    			}
            }
        }
    	public static String CC_DangKyKhungGioLamViec_EntityCollectionPropertyName { get { return "CC_DangKyKhungGioLamViec"; } }
    	partial void On_CC_DangKyKhungGioLamViec_Changing(ref EntityCollection<CC_DangKyKhungGioLamViec> newValue, ref bool stopChanging);
    	partial void On_CC_DangKyKhungGioLamViec_Changed(EntityCollection<CC_DangKyKhungGioLamViec> currentValue);

        #endregion

    }
}
