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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_HinhThucNghi")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_HinhThucNghi : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_HinhThucNghi()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_HinhThucNghi()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_HinhThucNghi object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static CC_HinhThucNghi CreateCC_HinhThucNghi(System.Guid oid)
        {
            CC_HinhThucNghi cC_HinhThucNghi = new CC_HinhThucNghi();
            cC_HinhThucNghi.Oid = oid;
            return cC_HinhThucNghi;
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
        public string MaQuanLy
        {
            get
            {
                return _maQuanLy;
            }
            set
            {
    			string oldValue =  _maQuanLy;
    			bool stopChanging = false;
                On_MaQuanLy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("MaQuanLy");
    			if(!stopChanging)
    			{
    				_maQuanLy = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("MaQuanLy");
    				On_MaQuanLy_Changed(oldValue, _maQuanLy);//\\
    			}
            }
        }
    	public static String MaQuanLy_PropertyName { get { return "MaQuanLy"; } }
        private string _maQuanLy;
        partial void On_MaQuanLy_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_MaQuanLy_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenHinhThucNghi
        {
            get
            {
                return _tenHinhThucNghi;
            }
            set
            {
    			string oldValue =  _tenHinhThucNghi;
    			bool stopChanging = false;
                On_TenHinhThucNghi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenHinhThucNghi");
    			if(!stopChanging)
    			{
    				_tenHinhThucNghi = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenHinhThucNghi");
    				On_TenHinhThucNghi_Changed(oldValue, _tenHinhThucNghi);//\\
    			}
            }
        }
    	public static String TenHinhThucNghi_PropertyName { get { return "TenHinhThucNghi"; } }
        private string _tenHinhThucNghi;
        partial void On_TenHinhThucNghi_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenHinhThucNghi_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string KyHieu
        {
            get
            {
                return _kyHieu;
            }
            set
            {
    			string oldValue =  _kyHieu;
    			bool stopChanging = false;
                On_KyHieu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KyHieu");
    			if(!stopChanging)
    			{
    				_kyHieu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("KyHieu");
    				On_KyHieu_Changed(oldValue, _kyHieu);//\\
    			}
            }
        }
    	public static String KyHieu_PropertyName { get { return "KyHieu"; } }
        private string _kyHieu;
        partial void On_KyHieu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_KyHieu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<byte> PhanLoai
        {
            get
            {
                return _phanLoai;
            }
            set
            {
    			Nullable<byte> oldValue =  _phanLoai;
    			bool stopChanging = false;
                On_PhanLoai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhanLoai");
    			if(!stopChanging)
    			{
    				_phanLoai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhanLoai");
    				On_PhanLoai_Changed(oldValue, _phanLoai);//\\
    			}
            }
        }
    	public static String PhanLoai_PropertyName { get { return "PhanLoai"; } }
        private Nullable<byte> _phanLoai;
        partial void On_PhanLoai_Changing(Nullable<byte> currentValue, ref Nullable<byte> newValue, ref bool stopChanging);
        partial void On_PhanLoai_Changed(Nullable<byte> oldValue, Nullable<byte> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> GiaTri
        {
            get
            {
                return _giaTri;
            }
            set
            {
    			Nullable<decimal> oldValue =  _giaTri;
    			bool stopChanging = false;
                On_GiaTri_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GiaTri");
    			if(!stopChanging)
    			{
    				_giaTri = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("GiaTri");
    				On_GiaTri_Changed(oldValue, _giaTri);//\\
    			}
            }
        }
    	public static String GiaTri_PropertyName { get { return "GiaTri"; } }
        private Nullable<decimal> _giaTri;
        partial void On_GiaTri_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_GiaTri_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
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
        public Nullable<int> GCRecord
        {
            get
            {
                return _gCRecord;
            }
            set
            {
    			Nullable<int> oldValue =  _gCRecord;
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
        private Nullable<int> _gCRecord;
        partial void On_GCRecord_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_GCRecord_Changed(Nullable<int> oldValue, Nullable<int> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongTheoNgay_HinhThucNghi", "CC_ChamCongTheoNgay")]
        public EntityCollection<CC_ChamCongTheoNgay> CC_ChamCongTheoNgay
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_ChamCongTheoNgay>("ERPModel.FK_CC_ChamCongTheoNgay_HinhThucNghi", "CC_ChamCongTheoNgay");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_ChamCongTheoNgay_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_ChamCongTheoNgay>("ERPModel.FK_CC_ChamCongTheoNgay_HinhThucNghi", "CC_ChamCongTheoNgay", value);
    					On_CC_ChamCongTheoNgay_Changed(this.CC_ChamCongTheoNgay);//\\//
    				}
    			}
            }
        }
    	public static String CC_ChamCongTheoNgay_EntityCollectionPropertyName { get { return "CC_ChamCongTheoNgay"; } }
    	partial void On_CC_ChamCongTheoNgay_Changing(ref EntityCollection<CC_ChamCongTheoNgay> newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongTheoNgay_Changed(EntityCollection<CC_ChamCongTheoNgay> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_CC_HinhThucNghi", "CC_ChamCongNgayNghi")]
        public EntityCollection<CC_ChamCongNgayNghi> CC_ChamCongNgayNghi
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_CC_HinhThucNghi", "CC_ChamCongNgayNghi");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_ChamCongNgayNghi_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_ChamCongNgayNghi>("ERPModel.FK_CC_ChamCongNgayNghi_CC_HinhThucNghi", "CC_ChamCongNgayNghi", value);
    					On_CC_ChamCongNgayNghi_Changed(this.CC_ChamCongNgayNghi);//\\//
    				}
    			}
            }
        }
    	public static String CC_ChamCongNgayNghi_EntityCollectionPropertyName { get { return "CC_ChamCongNgayNghi"; } }
    	partial void On_CC_ChamCongNgayNghi_Changing(ref EntityCollection<CC_ChamCongNgayNghi> newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongNgayNghi_Changed(EntityCollection<CC_ChamCongNgayNghi> currentValue);

        #endregion

    }
}
