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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="GiayTo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class GiayTo : ERP_Core.BaseEntityObject//EntityObject
    {
    	static GiayTo()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public GiayTo()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new GiayTo object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static GiayTo CreateGiayTo(System.Guid oid)
        {
            GiayTo giayTo = new GiayTo();
            giayTo.Oid = oid;
            return giayTo;
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
        public Nullable<bool> BatBuoc
        {
            get
            {
                return _batBuoc;
            }
            set
            {
    			Nullable<bool> oldValue =  _batBuoc;
    			bool stopChanging = false;
                On_BatBuoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BatBuoc");
    			if(!stopChanging)
    			{
    				_batBuoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("BatBuoc");
    				On_BatBuoc_Changed(oldValue, _batBuoc);//\\
    			}
            }
        }
    	public static String BatBuoc_PropertyName { get { return "BatBuoc"; } }
        private Nullable<bool> _batBuoc;
        partial void On_BatBuoc_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_BatBuoc_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_GiayToHoSo_GiayTo", "GiayToHoSo")]
        public EntityCollection<GiayToHoSo> GiayToHoSoes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<GiayToHoSo>("ERPModel.FK_GiayToHoSo_GiayTo", "GiayToHoSo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_GiayToHoSoes_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<GiayToHoSo>("ERPModel.FK_GiayToHoSo_GiayTo", "GiayToHoSo", value);
    					On_GiayToHoSoes_Changed(this.GiayToHoSoes);//\\//
    				}
    			}
            }
        }
    	public static String GiayToHoSoes_EntityCollectionPropertyName { get { return "GiayToHoSoes"; } }
    	partial void On_GiayToHoSoes_Changing(ref EntityCollection<GiayToHoSo> newValue, ref bool stopChanging);
    	partial void On_GiayToHoSoes_Changed(EntityCollection<GiayToHoSo> currentValue);

        #endregion

    }
}
