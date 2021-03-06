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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="QuyetDinhNghiHuu")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class QuyetDinhNghiHuu : ERP_Core.BaseEntityObject//EntityObject
    {
    	static QuyetDinhNghiHuu()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public QuyetDinhNghiHuu()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new QuyetDinhNghiHuu object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        public static QuyetDinhNghiHuu CreateQuyetDinhNghiHuu(System.Guid oid)
        {
            QuyetDinhNghiHuu quyetDinhNghiHuu = new QuyetDinhNghiHuu();
            quyetDinhNghiHuu.Oid = oid;
            return quyetDinhNghiHuu;
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
        public Nullable<System.DateTime> NgayPhatSinhBienDong
        {
            get
            {
                return _ngayPhatSinhBienDong;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayPhatSinhBienDong;
    			bool stopChanging = false;
                On_NgayPhatSinhBienDong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayPhatSinhBienDong");
    			if(!stopChanging)
    			{
    				_ngayPhatSinhBienDong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayPhatSinhBienDong");
    				On_NgayPhatSinhBienDong_Changed(oldValue, _ngayPhatSinhBienDong);//\\
    			}
            }
        }
    	public static String NgayPhatSinhBienDong_PropertyName { get { return "NgayPhatSinhBienDong"; } }
        private Nullable<System.DateTime> _ngayPhatSinhBienDong;
        partial void On_NgayPhatSinhBienDong_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayPhatSinhBienDong_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NghiViecTuNgay
        {
            get
            {
                return _nghiViecTuNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _nghiViecTuNgay;
    			bool stopChanging = false;
                On_NghiViecTuNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NghiViecTuNgay");
    			if(!stopChanging)
    			{
    				_nghiViecTuNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NghiViecTuNgay");
    				On_NghiViecTuNgay_Changed(oldValue, _nghiViecTuNgay);//\\
    			}
            }
        }
    	public static String NghiViecTuNgay_PropertyName { get { return "NghiViecTuNgay"; } }
        private Nullable<System.DateTime> _nghiViecTuNgay;
        partial void On_NghiViecTuNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NghiViecTuNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> NoiCuTruSauKhiThoiViec
        {
            get
            {
                return _noiCuTruSauKhiThoiViec;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _noiCuTruSauKhiThoiViec;
    			bool stopChanging = false;
                On_NoiCuTruSauKhiThoiViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiCuTruSauKhiThoiViec");
    			if(!stopChanging)
    			{
    				_noiCuTruSauKhiThoiViec = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NoiCuTruSauKhiThoiViec");
    				On_NoiCuTruSauKhiThoiViec_Changed(oldValue, _noiCuTruSauKhiThoiViec);//\\
    			}
            }
        }
    	public static String NoiCuTruSauKhiThoiViec_PropertyName { get { return "NoiCuTruSauKhiThoiViec"; } }
        private Nullable<System.Guid> _noiCuTruSauKhiThoiViec;
        partial void On_NoiCuTruSauKhiThoiViec_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_NoiCuTruSauKhiThoiViec_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> TinhTrang
        {
            get
            {
                return _tinhTrang;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _tinhTrang;
    			bool stopChanging = false;
                On_TinhTrang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TinhTrang");
    			if(!stopChanging)
    			{
    				_tinhTrang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TinhTrang");
    				On_TinhTrang_Changed(oldValue, _tinhTrang);//\\
    			}
            }
        }
    	public static String TinhTrang_PropertyName { get { return "TinhTrang"; } }
        private Nullable<System.Guid> _tinhTrang;
        partial void On_TinhTrang_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_TinhTrang_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinhNghiHuu_Oid", "QuyetDinhCaNhan")]
        public QuyetDinhCaNhan QuyetDinhCaNhan
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhNghiHuu_Oid", "QuyetDinhCaNhan").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_QuyetDinhCaNhan_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhNghiHuu_Oid", "QuyetDinhCaNhan").Value = value;
    				On_QuyetDinhCaNhan_Changed(this.QuyetDinhCaNhan);//\\//
    			}
    	    }
        }
    	public static String QuyetDinhCaNhan_ReferencePropertyName { get { return "QuyetDinhCaNhan"; } }
    	partial void On_QuyetDinhCaNhan_Changing(ref QuyetDinhCaNhan newValue, ref bool stopChanging);
    	partial void On_QuyetDinhCaNhan_Changed(QuyetDinhCaNhan currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<QuyetDinhCaNhan> QuyetDinhCaNhanReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhNghiHuu_Oid", "QuyetDinhCaNhan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<QuyetDinhCaNhan>("ERPModel.FK_QuyetDinhNghiHuu_Oid", "QuyetDinhCaNhan", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinhNghiHuu_TinhTrang", "TinhTrang")]
        public TinhTrang TinhTrang1
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TinhTrang>("ERPModel.FK_QuyetDinhNghiHuu_TinhTrang", "TinhTrang").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_TinhTrang1_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TinhTrang>("ERPModel.FK_QuyetDinhNghiHuu_TinhTrang", "TinhTrang").Value = value;
    				On_TinhTrang1_Changed(this.TinhTrang1);//\\//
    			}
    	    }
        }
    	public static String TinhTrang1_ReferencePropertyName { get { return "TinhTrang1"; } }
    	partial void On_TinhTrang1_Changing(ref TinhTrang newValue, ref bool stopChanging);
    	partial void On_TinhTrang1_Changed(TinhTrang currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TinhTrang> TinhTrang1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TinhTrang>("ERPModel.FK_QuyetDinhNghiHuu_TinhTrang", "TinhTrang");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TinhTrang>("ERPModel.FK_QuyetDinhNghiHuu_TinhTrang", "TinhTrang", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "DiaChi")]
        public DiaChi DiaChi
        {//test
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<DiaChi>("ERPModel.FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "DiaChi").Value;
            }
            set
            {
    			bool stopChanging = false;
    			On_DiaChi_Changing(ref value, ref stopChanging);//\\//
    			if(!stopChanging)
    			{
    				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<DiaChi>("ERPModel.FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "DiaChi").Value = value;
    				On_DiaChi_Changed(this.DiaChi);//\\//
    			}
    	    }
        }
    	public static String DiaChi_ReferencePropertyName { get { return "DiaChi"; } }
    	partial void On_DiaChi_Changing(ref DiaChi newValue, ref bool stopChanging);
    	partial void On_DiaChi_Changed(DiaChi currentValue);
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<DiaChi> DiaChiReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<DiaChi>("ERPModel.FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "DiaChi");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<DiaChi>("ERPModel.FK_QuyetDinhNghiHuu_NoiCuTruSauKhiThoiViec", "DiaChi", value);
                }
            }
        }

        #endregion

    }
}
