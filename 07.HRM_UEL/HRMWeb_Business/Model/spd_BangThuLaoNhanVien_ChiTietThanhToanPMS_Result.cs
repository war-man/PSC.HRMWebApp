//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 04:40:14 ngay 10/09/2019
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_BangThuLaoNhanVien_ChiTietThanhToanPMS_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_BangThuLaoNhanVien_ChiTietThanhToanPMS_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string KhoanChi
        {
            get
            {
                return _khoanChi;
            }
            set
            {
    			string oldValue =  _khoanChi;
    			bool stopChanging = false;
                On_KhoanChi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KhoanChi");
    			if(!stopChanging)
    			{
    				_khoanChi = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("KhoanChi");
    				On_KhoanChi_Changed(oldValue, _khoanChi);//\\
    			}
            }
        }
    	public static String KhoanChi_PropertyName { get { return "KhoanChi"; } }
        private string _khoanChi;
        partial void On_KhoanChi_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_KhoanChi_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenMonHoc
        {
            get
            {
                return _tenMonHoc;
            }
            set
            {
    			string oldValue =  _tenMonHoc;
    			bool stopChanging = false;
                On_TenMonHoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenMonHoc");
    			if(!stopChanging)
    			{
    				_tenMonHoc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenMonHoc");
    				On_TenMonHoc_Changed(oldValue, _tenMonHoc);//\\
    			}
            }
        }
    	public static String TenMonHoc_PropertyName { get { return "TenMonHoc"; } }
        private string _tenMonHoc;
        partial void On_TenMonHoc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenMonHoc_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string LopHocPhan
        {
            get
            {
                return _lopHocPhan;
            }
            set
            {
    			string oldValue =  _lopHocPhan;
    			bool stopChanging = false;
                On_LopHocPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LopHocPhan");
    			if(!stopChanging)
    			{
    				_lopHocPhan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LopHocPhan");
    				On_LopHocPhan_Changed(oldValue, _lopHocPhan);//\\
    			}
            }
        }
    	public static String LopHocPhan_PropertyName { get { return "LopHocPhan"; } }
        private string _lopHocPhan;
        partial void On_LopHocPhan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LopHocPhan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> SoBaiQuaTrinh
        {
            get
            {
                return _soBaiQuaTrinh;
            }
            set
            {
    			Nullable<int> oldValue =  _soBaiQuaTrinh;
    			bool stopChanging = false;
                On_SoBaiQuaTrinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoBaiQuaTrinh");
    			if(!stopChanging)
    			{
    				_soBaiQuaTrinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoBaiQuaTrinh");
    				On_SoBaiQuaTrinh_Changed(oldValue, _soBaiQuaTrinh);//\\
    			}
            }
        }
    	public static String SoBaiQuaTrinh_PropertyName { get { return "SoBaiQuaTrinh"; } }
        private Nullable<int> _soBaiQuaTrinh;
        partial void On_SoBaiQuaTrinh_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_SoBaiQuaTrinh_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> SoBaiGiuaKy
        {
            get
            {
                return _soBaiGiuaKy;
            }
            set
            {
    			Nullable<int> oldValue =  _soBaiGiuaKy;
    			bool stopChanging = false;
                On_SoBaiGiuaKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoBaiGiuaKy");
    			if(!stopChanging)
    			{
    				_soBaiGiuaKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoBaiGiuaKy");
    				On_SoBaiGiuaKy_Changed(oldValue, _soBaiGiuaKy);//\\
    			}
            }
        }
    	public static String SoBaiGiuaKy_PropertyName { get { return "SoBaiGiuaKy"; } }
        private Nullable<int> _soBaiGiuaKy;
        partial void On_SoBaiGiuaKy_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_SoBaiGiuaKy_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> SoBaiCuoiKy
        {
            get
            {
                return _soBaiCuoiKy;
            }
            set
            {
    			Nullable<int> oldValue =  _soBaiCuoiKy;
    			bool stopChanging = false;
                On_SoBaiCuoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoBaiCuoiKy");
    			if(!stopChanging)
    			{
    				_soBaiCuoiKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoBaiCuoiKy");
    				On_SoBaiCuoiKy_Changed(oldValue, _soBaiCuoiKy);//\\
    			}
            }
        }
    	public static String SoBaiCuoiKy_PropertyName { get { return "SoBaiCuoiKy"; } }
        private Nullable<int> _soBaiCuoiKy;
        partial void On_SoBaiCuoiKy_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_SoBaiCuoiKy_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> DonGiaQuaTrinh
        {
            get
            {
                return _donGiaQuaTrinh;
            }
            set
            {
    			Nullable<decimal> oldValue =  _donGiaQuaTrinh;
    			bool stopChanging = false;
                On_DonGiaQuaTrinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DonGiaQuaTrinh");
    			if(!stopChanging)
    			{
    				_donGiaQuaTrinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DonGiaQuaTrinh");
    				On_DonGiaQuaTrinh_Changed(oldValue, _donGiaQuaTrinh);//\\
    			}
            }
        }
    	public static String DonGiaQuaTrinh_PropertyName { get { return "DonGiaQuaTrinh"; } }
        private Nullable<decimal> _donGiaQuaTrinh;
        partial void On_DonGiaQuaTrinh_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_DonGiaQuaTrinh_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> DonGiaGiuaKy
        {
            get
            {
                return _donGiaGiuaKy;
            }
            set
            {
    			Nullable<decimal> oldValue =  _donGiaGiuaKy;
    			bool stopChanging = false;
                On_DonGiaGiuaKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DonGiaGiuaKy");
    			if(!stopChanging)
    			{
    				_donGiaGiuaKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DonGiaGiuaKy");
    				On_DonGiaGiuaKy_Changed(oldValue, _donGiaGiuaKy);//\\
    			}
            }
        }
    	public static String DonGiaGiuaKy_PropertyName { get { return "DonGiaGiuaKy"; } }
        private Nullable<decimal> _donGiaGiuaKy;
        partial void On_DonGiaGiuaKy_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_DonGiaGiuaKy_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> DonGiaCuoiKy
        {
            get
            {
                return _donGiaCuoiKy;
            }
            set
            {
    			Nullable<decimal> oldValue =  _donGiaCuoiKy;
    			bool stopChanging = false;
                On_DonGiaCuoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DonGiaCuoiKy");
    			if(!stopChanging)
    			{
    				_donGiaCuoiKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DonGiaCuoiKy");
    				On_DonGiaCuoiKy_Changed(oldValue, _donGiaCuoiKy);//\\
    			}
            }
        }
    	public static String DonGiaCuoiKy_PropertyName { get { return "DonGiaCuoiKy"; } }
        private Nullable<decimal> _donGiaCuoiKy;
        partial void On_DonGiaCuoiKy_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_DonGiaCuoiKy_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongTien
        {
            get
            {
                return _tongTien;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongTien;
    			bool stopChanging = false;
                On_TongTien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongTien");
    			if(!stopChanging)
    			{
    				_tongTien = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongTien");
    				On_TongTien_Changed(oldValue, _tongTien);//\\
    			}
            }
        }
    	public static String TongTien_PropertyName { get { return "TongTien"; } }
        private Nullable<decimal> _tongTien;
        partial void On_TongTien_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongTien_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
