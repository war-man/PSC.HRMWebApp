//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 05:00:01 ngay 10/01/2020
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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="BangChotThongTinTinhLuong")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BangChotThongTinTinhLuong : ERP_Core.BaseEntityObject//EntityObject
    {
    	static BangChotThongTinTinhLuong()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public BangChotThongTinTinhLuong()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new BangChotThongTinTinhLuong object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static BangChotThongTinTinhLuong CreateBangChotThongTinTinhLuong(System.Guid oid)
        {
            BangChotThongTinTinhLuong bangChotThongTinTinhLuong = new BangChotThongTinTinhLuong();
            bangChotThongTinTinhLuong.Oid = oid;
            return bangChotThongTinTinhLuong;
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
        public Nullable<System.DateTime> Thang
        {
            get
            {
                return _thang;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _thang;
    			bool stopChanging = false;
                On_Thang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Thang");
    			if(!stopChanging)
    			{
    				_thang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Thang");
    				On_Thang_Changed(oldValue, _thang);//\\
    			}
            }
        }
    	public static String Thang_PropertyName { get { return "Thang"; } }
        private Nullable<System.DateTime> _thang;
        partial void On_Thang_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_Thang_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> KhoaSo
        {
            get
            {
                return _khoaSo;
            }
            set
            {
    			Nullable<bool> oldValue =  _khoaSo;
    			bool stopChanging = false;
                On_KhoaSo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KhoaSo");
    			if(!stopChanging)
    			{
    				_khoaSo = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KhoaSo");
    				On_KhoaSo_Changed(oldValue, _khoaSo);//\\
    			}
            }
        }
    	public static String KhoaSo_PropertyName { get { return "KhoaSo"; } }
        private Nullable<bool> _khoaSo;
        partial void On_KhoaSo_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_KhoaSo_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> DaCapNhatThamNienCuaThang
        {
            get
            {
                return _daCapNhatThamNienCuaThang;
            }
            set
            {
    			Nullable<bool> oldValue =  _daCapNhatThamNienCuaThang;
    			bool stopChanging = false;
                On_DaCapNhatThamNienCuaThang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DaCapNhatThamNienCuaThang");
    			if(!stopChanging)
    			{
    				_daCapNhatThamNienCuaThang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DaCapNhatThamNienCuaThang");
    				On_DaCapNhatThamNienCuaThang_Changed(oldValue, _daCapNhatThamNienCuaThang);//\\
    			}
            }
        }
    	public static String DaCapNhatThamNienCuaThang_PropertyName { get { return "DaCapNhatThamNienCuaThang"; } }
        private Nullable<bool> _daCapNhatThamNienCuaThang;
        partial void On_DaCapNhatThamNienCuaThang_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_DaCapNhatThamNienCuaThang_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<byte> LoaiLuong
        {
            get
            {
                return _loaiLuong;
            }
            set
            {
    			Nullable<byte> oldValue =  _loaiLuong;
    			bool stopChanging = false;
                On_LoaiLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LoaiLuong");
    			if(!stopChanging)
    			{
    				_loaiLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LoaiLuong");
    				On_LoaiLuong_Changed(oldValue, _loaiLuong);//\\
    			}
            }
        }
    	public static String LoaiLuong_PropertyName { get { return "LoaiLuong"; } }
        private Nullable<byte> _loaiLuong;
        partial void On_LoaiLuong_Changing(Nullable<byte> currentValue, ref Nullable<byte> newValue, ref bool stopChanging);
        partial void On_LoaiLuong_Changed(Nullable<byte> oldValue, Nullable<byte> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> ThongTinTruong
        {
            get
            {
                return _thongTinTruong;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _thongTinTruong;
    			bool stopChanging = false;
                On_ThongTinTruong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThongTinTruong");
    			if(!stopChanging)
    			{
    				_thongTinTruong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("ThongTinTruong");
    				On_ThongTinTruong_Changed(oldValue, _thongTinTruong);//\\
    			}
            }
        }
    	public static String ThongTinTruong_PropertyName { get { return "ThongTinTruong"; } }
        private Nullable<System.Guid> _thongTinTruong;
        partial void On_ThongTinTruong_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_ThongTinTruong_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> Nam
        {
            get
            {
                return _nam;
            }
            set
            {
    			Nullable<int> oldValue =  _nam;
    			bool stopChanging = false;
                On_Nam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Nam");
    			if(!stopChanging)
    			{
    				_nam = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Nam");
    				On_Nam_Changed(oldValue, _nam);//\\
    			}
            }
        }
    	public static String Nam_PropertyName { get { return "Nam"; } }
        private Nullable<int> _nam;
        partial void On_Nam_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_Nam_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
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
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_KyTinhLuong_BangChotThongTinTinhLuong", "KyTinhLuong")]
        public EntityCollection<KyTinhLuong> KyTinhLuongs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<KyTinhLuong>("ERPModel.FK_KyTinhLuong_BangChotThongTinTinhLuong", "KyTinhLuong");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_KyTinhLuongs_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<KyTinhLuong>("ERPModel.FK_KyTinhLuong_BangChotThongTinTinhLuong", "KyTinhLuong", value);
    					On_KyTinhLuongs_Changed(this.KyTinhLuongs);//\\//
    				}
    			}
            }
        }
    	public static String KyTinhLuongs_EntityCollectionPropertyName { get { return "KyTinhLuongs"; } }
    	partial void On_KyTinhLuongs_Changing(ref EntityCollection<KyTinhLuong> newValue, ref bool stopChanging);
    	partial void On_KyTinhLuongs_Changed(EntityCollection<KyTinhLuong> currentValue);

        #endregion

    }
}