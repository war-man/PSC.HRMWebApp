//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 03:34:42 ngay 05/01/2017
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="NgayNghiTrongNam")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class NgayNghiTrongNam : ERP_Core.BaseEntityObject//EntityObject
    {
    	static NgayNghiTrongNam()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public NgayNghiTrongNam()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new NgayNghiTrongNam object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static NgayNghiTrongNam CreateNgayNghiTrongNam(System.Guid oid)
        {
            NgayNghiTrongNam ngayNghiTrongNam = new NgayNghiTrongNam();
            ngayNghiTrongNam.Oid = oid;
            return ngayNghiTrongNam;
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
        public Nullable<System.Guid> QuanLyNgayNghiTrongNam
        {
            get
            {
                return _quanLyNgayNghiTrongNam;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _quanLyNgayNghiTrongNam;
    			bool stopChanging = false;
                On_QuanLyNgayNghiTrongNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanLyNgayNghiTrongNam");
    			if(!stopChanging)
    			{
    				_quanLyNgayNghiTrongNam = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("QuanLyNgayNghiTrongNam");
    				On_QuanLyNgayNghiTrongNam_Changed(oldValue, _quanLyNgayNghiTrongNam);//\\
    			}
            }
        }
    	public static String QuanLyNgayNghiTrongNam_PropertyName { get { return "QuanLyNgayNghiTrongNam"; } }
        private Nullable<System.Guid> _quanLyNgayNghiTrongNam;
        partial void On_QuanLyNgayNghiTrongNam_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_QuanLyNgayNghiTrongNam_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenNgayNghi
        {
            get
            {
                return _tenNgayNghi;
            }
            set
            {
    			string oldValue =  _tenNgayNghi;
    			bool stopChanging = false;
                On_TenNgayNghi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenNgayNghi");
    			if(!stopChanging)
    			{
    				_tenNgayNghi = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenNgayNghi");
    				On_TenNgayNghi_Changed(oldValue, _tenNgayNghi);//\\
    			}
            }
        }
    	public static String TenNgayNghi_PropertyName { get { return "TenNgayNghi"; } }
        private string _tenNgayNghi;
        partial void On_TenNgayNghi_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenNgayNghi_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayNghi
        {
            get
            {
                return _ngayNghi;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayNghi;
    			bool stopChanging = false;
                On_NgayNghi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayNghi");
    			if(!stopChanging)
    			{
    				_ngayNghi = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayNghi");
    				On_NgayNghi_Changed(oldValue, _ngayNghi);//\\
    			}
            }
        }
    	public static String NgayNghi_PropertyName { get { return "NgayNghi"; } }
        private Nullable<System.DateTime> _ngayNghi;
        partial void On_NgayNghi_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayNghi_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayNghiBu
        {
            get
            {
                return _ngayNghiBu;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayNghiBu;
    			bool stopChanging = false;
                On_NgayNghiBu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayNghiBu");
    			if(!stopChanging)
    			{
    				_ngayNghiBu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayNghiBu");
    				On_NgayNghiBu_Changed(oldValue, _ngayNghiBu);//\\
    			}
            }
        }
    	public static String NgayNghiBu_PropertyName { get { return "NgayNghiBu"; } }
        private Nullable<System.DateTime> _ngayNghiBu;
        partial void On_NgayNghiBu_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayNghiBu_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_NgayNghiTrongNam_QuanLyNgayNghiTrongNam", "QuanLyNgayNghiTrongNam")]
        public QuanLyNgayNghiTrongNam QuanLyNgayNghiTrongNam1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuanLyNgayNghiTrongNam>("ERPModel.FK_NgayNghiTrongNam_QuanLyNgayNghiTrongNam", "QuanLyNgayNghiTrongNam").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_QuanLyNgayNghiTrongNam1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuanLyNgayNghiTrongNam>("ERPModel.FK_NgayNghiTrongNam_QuanLyNgayNghiTrongNam", "QuanLyNgayNghiTrongNam").Value = value;
    				On_QuanLyNgayNghiTrongNam1_Changed(this.QuanLyNgayNghiTrongNam1);//\\//
    			}
    	    }
        }
    	public static String QuanLyNgayNghiTrongNam1_ReferencePropertyName { get { return "QuanLyNgayNghiTrongNam1"; } }
    	partial void On_QuanLyNgayNghiTrongNam1_Changing(ref QuanLyNgayNghiTrongNam newValue, ref bool stopChanging);
    	partial void On_QuanLyNgayNghiTrongNam1_Changed(QuanLyNgayNghiTrongNam currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<QuanLyNgayNghiTrongNam> QuanLyNgayNghiTrongNam1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuanLyNgayNghiTrongNam>("ERPModel.FK_NgayNghiTrongNam_QuanLyNgayNghiTrongNam", "QuanLyNgayNghiTrongNam");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuanLyNgayNghiTrongNam>("ERPModel.FK_NgayNghiTrongNam_QuanLyNgayNghiTrongNam", "QuanLyNgayNghiTrongNam", value);
                }
            }
        }

        #endregion

    }
}
