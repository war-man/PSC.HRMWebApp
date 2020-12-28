//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 01:49:02 ngay 20/01/2017
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="TruongDaoTao")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TruongDaoTao : ERP_Core.BaseEntityObject//EntityObject
    {
    	static TruongDaoTao()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public TruongDaoTao()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new TruongDaoTao object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static TruongDaoTao CreateTruongDaoTao(System.Guid oid)
        {
            TruongDaoTao truongDaoTao = new TruongDaoTao();
            truongDaoTao.Oid = oid;
            return truongDaoTao;
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
        public string TenTruongDaoTao
        {
            get
            {
                return _tenTruongDaoTao;
            }
            set
            {
    			string oldValue =  _tenTruongDaoTao;
    			bool stopChanging = false;
                On_TenTruongDaoTao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenTruongDaoTao");
    			if(!stopChanging)
    			{
    				_tenTruongDaoTao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenTruongDaoTao");
    				On_TenTruongDaoTao_Changed(oldValue, _tenTruongDaoTao);//\\
    			}
            }
        }
    	public static String TenTruongDaoTao_PropertyName { get { return "TenTruongDaoTao"; } }
        private string _tenTruongDaoTao;
        partial void On_TenTruongDaoTao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenTruongDaoTao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> QuocGia
        {
            get
            {
                return _quocGia;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _quocGia;
    			bool stopChanging = false;
                On_QuocGia_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuocGia");
    			if(!stopChanging)
    			{
    				_quocGia = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("QuocGia");
    				On_QuocGia_Changed(oldValue, _quocGia);//\\
    			}
            }
        }
    	public static String QuocGia_PropertyName { get { return "QuocGia"; } }
        private Nullable<System.Guid> _quocGia;
        partial void On_QuocGia_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_QuocGia_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_TruongDaoTao_QuocGia", "QuocGia")]
        public QuocGia QuocGia1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_TruongDaoTao_QuocGia", "QuocGia").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_QuocGia1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_TruongDaoTao_QuocGia", "QuocGia").Value = value;
    				On_QuocGia1_Changed(this.QuocGia1);//\\//
    			}
    	    }
        }
    	public static String QuocGia1_ReferencePropertyName { get { return "QuocGia1"; } }
    	partial void On_QuocGia1_Changing(ref QuocGia newValue, ref bool stopChanging);
    	partial void On_QuocGia1_Changed(QuocGia currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<QuocGia> QuocGia1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuocGia>("ERPModel.FK_TruongDaoTao_QuocGia", "QuocGia");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuocGia>("ERPModel.FK_TruongDaoTao_QuocGia", "QuocGia", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_NhanVienTrinhDo_TruongDaoTao", "NhanVienTrinhDo")]
        public EntityCollection<NhanVienTrinhDo> NhanVienTrinhDoes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<NhanVienTrinhDo>("ERPModel.FK_NhanVienTrinhDo_TruongDaoTao", "NhanVienTrinhDo");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_NhanVienTrinhDoes_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<NhanVienTrinhDo>("ERPModel.FK_NhanVienTrinhDo_TruongDaoTao", "NhanVienTrinhDo", value);
    					On_NhanVienTrinhDoes_Changed(this.NhanVienTrinhDoes);//\\//
    				}
    			}
            }
        }
    	public static String NhanVienTrinhDoes_EntityCollectionPropertyName { get { return "NhanVienTrinhDoes"; } }
    	partial void On_NhanVienTrinhDoes_Changing(ref EntityCollection<NhanVienTrinhDo> newValue, ref bool stopChanging);
    	partial void On_NhanVienTrinhDoes_Changed(EntityCollection<NhanVienTrinhDo> currentValue);

        #endregion

    }
}
