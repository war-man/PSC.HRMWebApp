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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="NgachLuong")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class NgachLuong : ERP_Core.BaseEntityObject//EntityObject
    {
    	static NgachLuong()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public NgachLuong()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new NgachLuong object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static NgachLuong CreateNgachLuong(System.Guid oid)
        {
            NgachLuong ngachLuong = new NgachLuong();
            ngachLuong.Oid = oid;
            return ngachLuong;
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
        public Nullable<System.Guid> NhomNgachLuong
        {
            get
            {
                return _nhomNgachLuong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _nhomNgachLuong;
    			bool stopChanging = false;
                On_NhomNgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NhomNgachLuong");
    			if(!stopChanging)
    			{
    				_nhomNgachLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NhomNgachLuong");
    				On_NhomNgachLuong_Changed(oldValue, _nhomNgachLuong);//\\
    			}
            }
        }
    	public static String NhomNgachLuong_PropertyName { get { return "NhomNgachLuong"; } }
        private Nullable<System.Guid> _nhomNgachLuong;
        partial void On_NhomNgachLuong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_NhomNgachLuong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
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
        public string TenNgachLuong
        {
            get
            {
                return _tenNgachLuong;
            }
            set
            {
    			string oldValue =  _tenNgachLuong;
    			bool stopChanging = false;
                On_TenNgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenNgachLuong");
    			if(!stopChanging)
    			{
    				_tenNgachLuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenNgachLuong");
    				On_TenNgachLuong_Changed(oldValue, _tenNgachLuong);//\\
    			}
            }
        }
    	public static String TenNgachLuong_PropertyName { get { return "TenNgachLuong"; } }
        private string _tenNgachLuong;
        partial void On_TenNgachLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenNgachLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> ThoiGianNangBac
        {
            get
            {
                return _thoiGianNangBac;
            }
            set
            {
    			Nullable<int> oldValue =  _thoiGianNangBac;
    			bool stopChanging = false;
                On_ThoiGianNangBac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianNangBac");
    			if(!stopChanging)
    			{
    				_thoiGianNangBac = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThoiGianNangBac");
    				On_ThoiGianNangBac_Changed(oldValue, _thoiGianNangBac);//\\
    			}
            }
        }
    	public static String ThoiGianNangBac_PropertyName { get { return "ThoiGianNangBac"; } }
        private Nullable<int> _thoiGianNangBac;
        partial void On_ThoiGianNangBac_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_ThoiGianNangBac_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> TotKhung
        {
            get
            {
                return _totKhung;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _totKhung;
    			bool stopChanging = false;
                On_TotKhung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TotKhung");
    			if(!stopChanging)
    			{
    				_totKhung = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TotKhung");
    				On_TotKhung_Changed(oldValue, _totKhung);//\\
    			}
            }
        }
    	public static String TotKhung_PropertyName { get { return "TotKhung"; } }
        private Nullable<System.Guid> _totKhung;
        partial void On_TotKhung_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_TotKhung_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_NhanVienThongTinLuong_NgachLuong", "NhanVienThongTinLuong")]
        public EntityCollection<NhanVienThongTinLuong> NhanVienThongTinLuongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<NhanVienThongTinLuong>("ERPModel.FK_NhanVienThongTinLuong_NgachLuong", "NhanVienThongTinLuong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_NhanVienThongTinLuongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<NhanVienThongTinLuong>("ERPModel.FK_NhanVienThongTinLuong_NgachLuong", "NhanVienThongTinLuong", value);
    					On_NhanVienThongTinLuongs_Changed(this.NhanVienThongTinLuongs);//\\//
    				}
    			}
            }
        }
    	public static String NhanVienThongTinLuongs_EntityCollectionPropertyName { get { return "NhanVienThongTinLuongs"; } }
    	partial void On_NhanVienThongTinLuongs_Changing(ref EntityCollection<NhanVienThongTinLuong> newValue, ref bool stopChanging);
    	partial void On_NhanVienThongTinLuongs_Changed(EntityCollection<NhanVienThongTinLuong> currentValue);

        #endregion

    }
}
