//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi SERVERERP\tai luc 09:33:22 ngay 03/10/2017
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="DanToc")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DanToc : ERP_Core.BaseEntityObject//EntityObject
    {
    	static DanToc()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public DanToc()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new DanToc object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static DanToc CreateDanToc(System.Guid oid)
        {
            DanToc danToc = new DanToc();
            danToc.Oid = oid;
            return danToc;
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
        public string TenDanToc
        {
            get
            {
                return _tenDanToc;
            }
            set
            {
    			string oldValue =  _tenDanToc;
    			bool stopChanging = false;
                On_TenDanToc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenDanToc");
    			if(!stopChanging)
    			{
    				_tenDanToc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenDanToc");
    				On_TenDanToc_Changed(oldValue, _tenDanToc);//\\
    			}
            }
        }
    	public static String TenDanToc_PropertyName { get { return "TenDanToc"; } }
        private string _tenDanToc;
        partial void On_TenDanToc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenDanToc_Changed(string oldValue, string currentValue);
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> CapDo
        {
            get
            {
                return _capDo;
            }
            set
            {
    			Nullable<int> oldValue =  _capDo;
    			bool stopChanging = false;
                On_CapDo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CapDo");
    			if(!stopChanging)
    			{
    				_capDo = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("CapDo");
    				On_CapDo_Changed(oldValue, _capDo);//\\
    			}
            }
        }
    	public static String CapDo_PropertyName { get { return "CapDo"; } }
        private Nullable<int> _capDo;
        partial void On_CapDo_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_CapDo_Changed(Nullable<int> oldValue, Nullable<int> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_HoSo_DanToc", "HoSo")]
        public EntityCollection<HoSo> HoSoes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HoSo>("ERPModel.FK_HoSo_DanToc", "HoSo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_HoSoes_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HoSo>("ERPModel.FK_HoSo_DanToc", "HoSo", value);
    					On_HoSoes_Changed(this.HoSoes);//\\//
    				}
    			}
            }
        }
    	public static String HoSoes_EntityCollectionPropertyName { get { return "HoSoes"; } }
    	partial void On_HoSoes_Changing(ref EntityCollection<HoSo> newValue, ref bool stopChanging);
    	partial void On_HoSoes_Changed(EntityCollection<HoSo> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_Web_UpdateHoSoNhanVien_DanToc", "Web_UpdateHoSoNhanVien")]
        public EntityCollection<Web_UpdateHoSoNhanVien> Web_UpdateHoSoNhanVien
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Web_UpdateHoSoNhanVien>("ERPModel.FK_Web_UpdateHoSoNhanVien_DanToc", "Web_UpdateHoSoNhanVien");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_Web_UpdateHoSoNhanVien_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Web_UpdateHoSoNhanVien>("ERPModel.FK_Web_UpdateHoSoNhanVien_DanToc", "Web_UpdateHoSoNhanVien", value);
    					On_Web_UpdateHoSoNhanVien_Changed(this.Web_UpdateHoSoNhanVien);//\\//
    				}
    			}
            }
        }
    	public static String Web_UpdateHoSoNhanVien_EntityCollectionPropertyName { get { return "Web_UpdateHoSoNhanVien"; } }
    	partial void On_Web_UpdateHoSoNhanVien_Changing(ref EntityCollection<Web_UpdateHoSoNhanVien> newValue, ref bool stopChanging);
    	partial void On_Web_UpdateHoSoNhanVien_Changed(EntityCollection<Web_UpdateHoSoNhanVien> currentValue);

        #endregion

    }
}
