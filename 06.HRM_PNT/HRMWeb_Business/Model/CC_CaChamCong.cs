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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_CaChamCong")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_CaChamCong : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_CaChamCong()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_CaChamCong()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_CaChamCong object.
        /// </summary>
        /// <param name="oid">Initial value of the Oid property.</param>
        /// <param name="loaiCa">Initial value of the LoaiCa property.</param>
        public static CC_CaChamCong CreateCC_CaChamCong(System.Guid oid, byte loaiCa)
        {
            CC_CaChamCong cC_CaChamCong = new CC_CaChamCong();
            cC_CaChamCong.Oid = oid;
            cC_CaChamCong.LoaiCa = loaiCa;
            return cC_CaChamCong;
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
        public string ThoiGianVaoSang
        {
            get
            {
                return _thoiGianVaoSang;
            }
            set
            {
    			string oldValue =  _thoiGianVaoSang;
    			bool stopChanging = false;
                On_ThoiGianVaoSang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianVaoSang");
    			if(!stopChanging)
    			{
    				_thoiGianVaoSang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianVaoSang");
    				On_ThoiGianVaoSang_Changed(oldValue, _thoiGianVaoSang);//\\
    			}
            }
        }
    	public static String ThoiGianVaoSang_PropertyName { get { return "ThoiGianVaoSang"; } }
        private string _thoiGianVaoSang;
        partial void On_ThoiGianVaoSang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianVaoSang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThoiGianRaSang
        {
            get
            {
                return _thoiGianRaSang;
            }
            set
            {
    			string oldValue =  _thoiGianRaSang;
    			bool stopChanging = false;
                On_ThoiGianRaSang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianRaSang");
    			if(!stopChanging)
    			{
    				_thoiGianRaSang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianRaSang");
    				On_ThoiGianRaSang_Changed(oldValue, _thoiGianRaSang);//\\
    			}
            }
        }
    	public static String ThoiGianRaSang_PropertyName { get { return "ThoiGianRaSang"; } }
        private string _thoiGianRaSang;
        partial void On_ThoiGianRaSang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianRaSang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThoiGianBatDauNghiGiuaCa
        {
            get
            {
                return _thoiGianBatDauNghiGiuaCa;
            }
            set
            {
    			string oldValue =  _thoiGianBatDauNghiGiuaCa;
    			bool stopChanging = false;
                On_ThoiGianBatDauNghiGiuaCa_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianBatDauNghiGiuaCa");
    			if(!stopChanging)
    			{
    				_thoiGianBatDauNghiGiuaCa = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianBatDauNghiGiuaCa");
    				On_ThoiGianBatDauNghiGiuaCa_Changed(oldValue, _thoiGianBatDauNghiGiuaCa);//\\
    			}
            }
        }
    	public static String ThoiGianBatDauNghiGiuaCa_PropertyName { get { return "ThoiGianBatDauNghiGiuaCa"; } }
        private string _thoiGianBatDauNghiGiuaCa;
        partial void On_ThoiGianBatDauNghiGiuaCa_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianBatDauNghiGiuaCa_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThoiGianKetThucNghiGiuaCa
        {
            get
            {
                return _thoiGianKetThucNghiGiuaCa;
            }
            set
            {
    			string oldValue =  _thoiGianKetThucNghiGiuaCa;
    			bool stopChanging = false;
                On_ThoiGianKetThucNghiGiuaCa_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianKetThucNghiGiuaCa");
    			if(!stopChanging)
    			{
    				_thoiGianKetThucNghiGiuaCa = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianKetThucNghiGiuaCa");
    				On_ThoiGianKetThucNghiGiuaCa_Changed(oldValue, _thoiGianKetThucNghiGiuaCa);//\\
    			}
            }
        }
    	public static String ThoiGianKetThucNghiGiuaCa_PropertyName { get { return "ThoiGianKetThucNghiGiuaCa"; } }
        private string _thoiGianKetThucNghiGiuaCa;
        partial void On_ThoiGianKetThucNghiGiuaCa_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianKetThucNghiGiuaCa_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThoiGianVaoChieu
        {
            get
            {
                return _thoiGianVaoChieu;
            }
            set
            {
    			string oldValue =  _thoiGianVaoChieu;
    			bool stopChanging = false;
                On_ThoiGianVaoChieu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianVaoChieu");
    			if(!stopChanging)
    			{
    				_thoiGianVaoChieu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianVaoChieu");
    				On_ThoiGianVaoChieu_Changed(oldValue, _thoiGianVaoChieu);//\\
    			}
            }
        }
    	public static String ThoiGianVaoChieu_PropertyName { get { return "ThoiGianVaoChieu"; } }
        private string _thoiGianVaoChieu;
        partial void On_ThoiGianVaoChieu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianVaoChieu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThoiGianRaChieu
        {
            get
            {
                return _thoiGianRaChieu;
            }
            set
            {
    			string oldValue =  _thoiGianRaChieu;
    			bool stopChanging = false;
                On_ThoiGianRaChieu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianRaChieu");
    			if(!stopChanging)
    			{
    				_thoiGianRaChieu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianRaChieu");
    				On_ThoiGianRaChieu_Changed(oldValue, _thoiGianRaChieu);//\\
    			}
            }
        }
    	public static String ThoiGianRaChieu_PropertyName { get { return "ThoiGianRaChieu"; } }
        private string _thoiGianRaChieu;
        partial void On_ThoiGianRaChieu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianRaChieu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> SoPhutCong
        {
            get
            {
                return _soPhutCong;
            }
            set
            {
    			Nullable<int> oldValue =  _soPhutCong;
    			bool stopChanging = false;
                On_SoPhutCong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoPhutCong");
    			if(!stopChanging)
    			{
    				_soPhutCong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoPhutCong");
    				On_SoPhutCong_Changed(oldValue, _soPhutCong);//\\
    			}
            }
        }
    	public static String SoPhutCong_PropertyName { get { return "SoPhutCong"; } }
        private Nullable<int> _soPhutCong;
        partial void On_SoPhutCong_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_SoPhutCong_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongSoGioLamViecBuoiSang
        {
            get
            {
                return _tongSoGioLamViecBuoiSang;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoGioLamViecBuoiSang;
    			bool stopChanging = false;
                On_TongSoGioLamViecBuoiSang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoGioLamViecBuoiSang");
    			if(!stopChanging)
    			{
    				_tongSoGioLamViecBuoiSang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoGioLamViecBuoiSang");
    				On_TongSoGioLamViecBuoiSang_Changed(oldValue, _tongSoGioLamViecBuoiSang);//\\
    			}
            }
        }
    	public static String TongSoGioLamViecBuoiSang_PropertyName { get { return "TongSoGioLamViecBuoiSang"; } }
        private Nullable<decimal> _tongSoGioLamViecBuoiSang;
        partial void On_TongSoGioLamViecBuoiSang_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoGioLamViecBuoiSang_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongSoGioLamViecBuoiChieu
        {
            get
            {
                return _tongSoGioLamViecBuoiChieu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoGioLamViecBuoiChieu;
    			bool stopChanging = false;
                On_TongSoGioLamViecBuoiChieu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoGioLamViecBuoiChieu");
    			if(!stopChanging)
    			{
    				_tongSoGioLamViecBuoiChieu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoGioLamViecBuoiChieu");
    				On_TongSoGioLamViecBuoiChieu_Changed(oldValue, _tongSoGioLamViecBuoiChieu);//\\
    			}
            }
        }
    	public static String TongSoGioLamViecBuoiChieu_PropertyName { get { return "TongSoGioLamViecBuoiChieu"; } }
        private Nullable<decimal> _tongSoGioLamViecBuoiChieu;
        partial void On_TongSoGioLamViecBuoiChieu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoGioLamViecBuoiChieu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongSoGioLamViecCaNgay
        {
            get
            {
                return _tongSoGioLamViecCaNgay;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoGioLamViecCaNgay;
    			bool stopChanging = false;
                On_TongSoGioLamViecCaNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoGioLamViecCaNgay");
    			if(!stopChanging)
    			{
    				_tongSoGioLamViecCaNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoGioLamViecCaNgay");
    				On_TongSoGioLamViecCaNgay_Changed(oldValue, _tongSoGioLamViecCaNgay);//\\
    			}
            }
        }
    	public static String TongSoGioLamViecCaNgay_PropertyName { get { return "TongSoGioLamViecCaNgay"; } }
        private Nullable<decimal> _tongSoGioLamViecCaNgay;
        partial void On_TongSoGioLamViecCaNgay_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoGioLamViecCaNgay_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> Active
        {
            get
            {
                return _active;
            }
            set
            {
    			Nullable<bool> oldValue =  _active;
    			bool stopChanging = false;
                On_Active_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("Active");
    			if(!stopChanging)
    			{
    				_active = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("Active");
    				On_Active_Changed(oldValue, _active);//\\
    			}
            }
        }
    	public static String Active_PropertyName { get { return "Active"; } }
        private Nullable<bool> _active;
        partial void On_Active_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_Active_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public byte LoaiCa
        {
            get
            {
                return _loaiCa;
            }
            set
            {
    			byte oldValue =  _loaiCa;
    			bool stopChanging = false;
                On_LoaiCa_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LoaiCa");
    			if(!stopChanging)
    			{
    				_loaiCa = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LoaiCa");
    				On_LoaiCa_Changed(oldValue, _loaiCa);//\\
    			}
            }
        }
    	public static String LoaiCa_PropertyName { get { return "LoaiCa"; } }
        private byte _loaiCa;
        partial void On_LoaiCa_Changing(byte currentValue, ref byte newValue, ref bool stopChanging);
        partial void On_LoaiCa_Changed(byte oldValue, byte currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> SoPhutTru
        {
            get
            {
                return _soPhutTru;
            }
            set
            {
    			Nullable<int> oldValue =  _soPhutTru;
    			bool stopChanging = false;
                On_SoPhutTru_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoPhutTru");
    			if(!stopChanging)
    			{
    				_soPhutTru = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoPhutTru");
    				On_SoPhutTru_Changed(oldValue, _soPhutTru);//\\
    			}
            }
        }
    	public static String SoPhutTru_PropertyName { get { return "SoPhutTru"; } }
        private Nullable<int> _soPhutTru;
        partial void On_SoPhutTru_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_SoPhutTru_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
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
        public string TenCa
        {
            get
            {
                return _tenCa;
            }
            set
            {
    			string oldValue =  _tenCa;
    			bool stopChanging = false;
                On_TenCa_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenCa");
    			if(!stopChanging)
    			{
    				_tenCa = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenCa");
    				On_TenCa_Changed(oldValue, _tenCa);//\\
    			}
            }
        }
    	public static String TenCa_PropertyName { get { return "TenCa"; } }
        private string _tenCa;
        partial void On_TenCa_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenCa_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongSoGioNghiGiuaCa
        {
            get
            {
                return _tongSoGioNghiGiuaCa;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongSoGioNghiGiuaCa;
    			bool stopChanging = false;
                On_TongSoGioNghiGiuaCa_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoGioNghiGiuaCa");
    			if(!stopChanging)
    			{
    				_tongSoGioNghiGiuaCa = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoGioNghiGiuaCa");
    				On_TongSoGioNghiGiuaCa_Changed(oldValue, _tongSoGioNghiGiuaCa);//\\
    			}
            }
        }
    	public static String TongSoGioNghiGiuaCa_PropertyName { get { return "TongSoGioNghiGiuaCa"; } }
        private Nullable<decimal> _tongSoGioNghiGiuaCa;
        partial void On_TongSoGioNghiGiuaCa_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongSoGioNghiGiuaCa_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThoiGianBDQuetBuoiSang
        {
            get
            {
                return _thoiGianBDQuetBuoiSang;
            }
            set
            {
    			string oldValue =  _thoiGianBDQuetBuoiSang;
    			bool stopChanging = false;
                On_ThoiGianBDQuetBuoiSang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianBDQuetBuoiSang");
    			if(!stopChanging)
    			{
    				_thoiGianBDQuetBuoiSang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianBDQuetBuoiSang");
    				On_ThoiGianBDQuetBuoiSang_Changed(oldValue, _thoiGianBDQuetBuoiSang);//\\
    			}
            }
        }
    	public static String ThoiGianBDQuetBuoiSang_PropertyName { get { return "ThoiGianBDQuetBuoiSang"; } }
        private string _thoiGianBDQuetBuoiSang;
        partial void On_ThoiGianBDQuetBuoiSang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianBDQuetBuoiSang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThoiGianKTQuetBuoiChieu
        {
            get
            {
                return _thoiGianKTQuetBuoiChieu;
            }
            set
            {
    			string oldValue =  _thoiGianKTQuetBuoiChieu;
    			bool stopChanging = false;
                On_ThoiGianKTQuetBuoiChieu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThoiGianKTQuetBuoiChieu");
    			if(!stopChanging)
    			{
    				_thoiGianKTQuetBuoiChieu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThoiGianKTQuetBuoiChieu");
    				On_ThoiGianKTQuetBuoiChieu_Changed(oldValue, _thoiGianKTQuetBuoiChieu);//\\
    			}
            }
        }
    	public static String ThoiGianKTQuetBuoiChieu_PropertyName { get { return "ThoiGianKTQuetBuoiChieu"; } }
        private string _thoiGianKTQuetBuoiChieu;
        partial void On_ThoiGianKTQuetBuoiChieu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThoiGianKTQuetBuoiChieu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongSoGioLamViec
        {
            get
            {
                return _tongSoGioLamViec;
            }
            set
            {
    			Nullable<int> oldValue =  _tongSoGioLamViec;
    			bool stopChanging = false;
                On_TongSoGioLamViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongSoGioLamViec");
    			if(!stopChanging)
    			{
    				_tongSoGioLamViec = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongSoGioLamViec");
    				On_TongSoGioLamViec_Changed(oldValue, _tongSoGioLamViec);//\\
    			}
            }
        }
    	public static String TongSoGioLamViec_PropertyName { get { return "TongSoGioLamViec"; } }
        private Nullable<int> _tongSoGioLamViec;
        partial void On_TongSoGioLamViec_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongSoGioLamViec_Changed(Nullable<int> oldValue, Nullable<int> currentValue);

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_DangKyKhungGioLamViec")]
        public EntityCollection<CC_DangKyKhungGioLamViec> CC_DangKyKhungGioLamViec
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_DangKyKhungGioLamViec>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_DangKyKhungGioLamViec");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_DangKyKhungGioLamViec_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_DangKyKhungGioLamViec>("ERPModel.FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_DangKyKhungGioLamViec", value);
    					On_CC_DangKyKhungGioLamViec_Changed(this.CC_DangKyKhungGioLamViec);//\\//
    				}
    			}
            }
        }
    	public static String CC_DangKyKhungGioLamViec_EntityCollectionPropertyName { get { return "CC_DangKyKhungGioLamViec"; } }
    	partial void On_CC_DangKyKhungGioLamViec_Changing(ref EntityCollection<CC_DangKyKhungGioLamViec> newValue, ref bool stopChanging);
    	partial void On_CC_DangKyKhungGioLamViec_Changed(EntityCollection<CC_DangKyKhungGioLamViec> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ERPModel", "FK_CC_ChamCongTheoNgay_CC_CaChamCong", "CC_ChamCongTheoNgay")]
        public EntityCollection<CC_ChamCongTheoNgay> CC_ChamCongTheoNgay
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CC_ChamCongTheoNgay>("ERPModel.FK_CC_ChamCongTheoNgay_CC_CaChamCong", "CC_ChamCongTheoNgay");
            }
            set
            {
                if ((value != null))
                {
    				bool stopChanging = false;
    				On_CC_ChamCongTheoNgay_Changing(ref value, ref stopChanging);//\\//
    				if(!stopChanging)
    				{
    					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CC_ChamCongTheoNgay>("ERPModel.FK_CC_ChamCongTheoNgay_CC_CaChamCong", "CC_ChamCongTheoNgay", value);
    					On_CC_ChamCongTheoNgay_Changed(this.CC_ChamCongTheoNgay);//\\//
    				}
    			}
            }
        }
    	public static String CC_ChamCongTheoNgay_EntityCollectionPropertyName { get { return "CC_ChamCongTheoNgay"; } }
    	partial void On_CC_ChamCongTheoNgay_Changing(ref EntityCollection<CC_ChamCongTheoNgay> newValue, ref bool stopChanging);
    	partial void On_CC_ChamCongTheoNgay_Changed(EntityCollection<CC_ChamCongTheoNgay> currentValue);

        #endregion

    }
}
