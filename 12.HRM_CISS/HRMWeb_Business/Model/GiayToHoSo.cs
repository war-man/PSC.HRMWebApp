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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="GiayToHoSo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class GiayToHoSo : ERP_Core.BaseEntityObject//EntityObject
    {
    	static GiayToHoSo()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public GiayToHoSo()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new GiayToHoSo object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static GiayToHoSo CreateGiayToHoSo(System.Guid oid)
        {
            GiayToHoSo giayToHoSo = new GiayToHoSo();
            giayToHoSo.Oid = oid;
            return giayToHoSo;
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
        public Nullable<System.Guid> HoSo
        {
            get
            {
                return _hoSo;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _hoSo;
    			bool stopChanging = false;
                On_HoSo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HoSo");
    			if(!stopChanging)
    			{
    				_hoSo = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HoSo");
    				On_HoSo_Changed(oldValue, _hoSo);//\\
    			}
            }
        }
    	public static String HoSo_PropertyName { get { return "HoSo"; } }
        private Nullable<System.Guid> _hoSo;
        partial void On_HoSo_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_HoSo_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> STT
        {
            get
            {
                return _sTT;
            }
            set
            {
    			Nullable<decimal> oldValue =  _sTT;
    			bool stopChanging = false;
                On_STT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("STT");
    			if(!stopChanging)
    			{
    				_sTT = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("STT");
    				On_STT_Changed(oldValue, _sTT);//\\
    			}
            }
        }
    	public static String STT_PropertyName { get { return "STT"; } }
        private Nullable<decimal> _sTT;
        partial void On_STT_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_STT_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenGiayTo
        {
            get
            {
                return _tenGiayTo;
            }
            set
            {
    			string oldValue =  _tenGiayTo;
    			bool stopChanging = false;
                On_TenGiayTo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenGiayTo");
    			if(!stopChanging)
    			{
    				_tenGiayTo = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenGiayTo");
    				On_TenGiayTo_Changed(oldValue, _tenGiayTo);//\\
    			}
            }
        }
    	public static String TenGiayTo_PropertyName { get { return "TenGiayTo"; } }
        private string _tenGiayTo;
        partial void On_TenGiayTo_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenGiayTo_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayLap
        {
            get
            {
                return _ngayLap;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayLap;
    			bool stopChanging = false;
                On_NgayLap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayLap");
    			if(!stopChanging)
    			{
    				_ngayLap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayLap");
    				On_NgayLap_Changed(oldValue, _ngayLap);//\\
    			}
            }
        }
    	public static String NgayLap_PropertyName { get { return "NgayLap"; } }
        private Nullable<System.DateTime> _ngayLap;
        partial void On_NgayLap_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayLap_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> LoaiGiayTo
        {
            get
            {
                return _loaiGiayTo;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _loaiGiayTo;
    			bool stopChanging = false;
                On_LoaiGiayTo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LoaiGiayTo");
    			if(!stopChanging)
    			{
    				_loaiGiayTo = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LoaiGiayTo");
    				On_LoaiGiayTo_Changed(oldValue, _loaiGiayTo);//\\
    			}
            }
        }
    	public static String LoaiGiayTo_PropertyName { get { return "LoaiGiayTo"; } }
        private Nullable<System.Guid> _loaiGiayTo;
        partial void On_LoaiGiayTo_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_LoaiGiayTo_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }
            set
            {
    			string oldValue =  _ghiChu;
    			bool stopChanging = false;
                On_GhiChu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GhiChu");
    			if(!stopChanging)
    			{
    				_ghiChu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("GhiChu");
    				On_GhiChu_Changed(oldValue, _ghiChu);//\\
    			}
            }
        }
    	public static String GhiChu_PropertyName { get { return "GhiChu"; } }
        private string _ghiChu;
        partial void On_GhiChu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_GhiChu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DuongDanFile
        {
            get
            {
                return _duongDanFile;
            }
            set
            {
    			string oldValue =  _duongDanFile;
    			bool stopChanging = false;
                On_DuongDanFile_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DuongDanFile");
    			if(!stopChanging)
    			{
    				_duongDanFile = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DuongDanFile");
    				On_DuongDanFile_Changed(oldValue, _duongDanFile);//\\
    			}
            }
        }
    	public static String DuongDanFile_PropertyName { get { return "DuongDanFile"; } }
        private string _duongDanFile;
        partial void On_DuongDanFile_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DuongDanFile_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DuongDanFileWeb
        {
            get
            {
                return _duongDanFileWeb;
            }
            set
            {
    			string oldValue =  _duongDanFileWeb;
    			bool stopChanging = false;
                On_DuongDanFileWeb_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DuongDanFileWeb");
    			if(!stopChanging)
    			{
    				_duongDanFileWeb = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DuongDanFileWeb");
    				On_DuongDanFileWeb_Changed(oldValue, _duongDanFileWeb);//\\
    			}
            }
        }
    	public static String DuongDanFileWeb_PropertyName { get { return "DuongDanFileWeb"; } }
        private string _duongDanFileWeb;
        partial void On_DuongDanFileWeb_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DuongDanFileWeb_Changed(string oldValue, string currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo1")]
        public EntityCollection<GiayToHoSo> GiayToHoSo1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<GiayToHoSo>("ERPModel.FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo1");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_GiayToHoSo1_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<GiayToHoSo>("ERPModel.FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo1", value);
    					On_GiayToHoSo1_Changed(this.GiayToHoSo1);//\\//
    				}
    			}
            }
        }
    	public static String GiayToHoSo1_EntityCollectionPropertyName { get { return "GiayToHoSo1"; } }
    	partial void On_GiayToHoSo1_Changing(ref EntityCollection<GiayToHoSo> newValue, ref bool stopChanging);
    	partial void On_GiayToHoSo1_Changed(EntityCollection<GiayToHoSo> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo")]
        public GiayToHoSo GiayToHoSo2
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<GiayToHoSo>("ERPModel.FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_GiayToHoSo2_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<GiayToHoSo>("ERPModel.FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo").Value = value;
    				On_GiayToHoSo2_Changed(this.GiayToHoSo2);//\\//
    			}
    	    }
        }
    	public static String GiayToHoSo2_ReferencePropertyName { get { return "GiayToHoSo2"; } }
    	partial void On_GiayToHoSo2_Changing(ref GiayToHoSo newValue, ref bool stopChanging);
    	partial void On_GiayToHoSo2_Changed(GiayToHoSo currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<GiayToHoSo> GiayToHoSo2Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<GiayToHoSo>("ERPModel.FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<GiayToHoSo>("ERPModel.FK_GiayToHoSo_LoaiGiayTo", "GiayToHoSo", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_GiayToHoSo_HoSo", "HoSo")]
        public HoSo HoSo1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HoSo>("ERPModel.FK_GiayToHoSo_HoSo", "HoSo").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_HoSo1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HoSo>("ERPModel.FK_GiayToHoSo_HoSo", "HoSo").Value = value;
    				On_HoSo1_Changed(this.HoSo1);//\\//
    			}
    	    }
        }
    	public static String HoSo1_ReferencePropertyName { get { return "HoSo1"; } }
    	partial void On_HoSo1_Changing(ref HoSo newValue, ref bool stopChanging);
    	partial void On_HoSo1_Changed(HoSo currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<HoSo> HoSo1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HoSo>("ERPModel.FK_GiayToHoSo_HoSo", "HoSo");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<HoSo>("ERPModel.FK_GiayToHoSo_HoSo", "HoSo", value);
                }
            }
        }

        #endregion

    }
}
