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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Report_CacThongTinLamCoSoTinhTraLuong_Result6")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Report_CacThongTinLamCoSoTinhTraLuong_Result6 : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<long> STT
        {
            get
            {
                return _sTT;
            }
            set
            {
    			Nullable<long> oldValue =  _sTT;
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
        private Nullable<long> _sTT;
        partial void On_STT_Changing(Nullable<long> currentValue, ref Nullable<long> newValue, ref bool stopChanging);
        partial void On_STT_Changed(Nullable<long> oldValue, Nullable<long> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string HoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
    			string oldValue =  _hoTen;
    			bool stopChanging = false;
                On_HoTen_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HoTen");
    			if(!stopChanging)
    			{
    				_hoTen = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HoTen");
    				On_HoTen_Changed(oldValue, _hoTen);//\\
    			}
            }
        }
    	public static String HoTen_PropertyName { get { return "HoTen"; } }
        private string _hoTen;
        partial void On_HoTen_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HoTen_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenBoPhan
        {
            get
            {
                return _tenBoPhan;
            }
            set
            {
    			string oldValue =  _tenBoPhan;
    			bool stopChanging = false;
                On_TenBoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenBoPhan");
    			if(!stopChanging)
    			{
    				_tenBoPhan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenBoPhan");
    				On_TenBoPhan_Changed(oldValue, _tenBoPhan);//\\
    			}
            }
        }
    	public static String TenBoPhan_PropertyName { get { return "TenBoPhan"; } }
        private string _tenBoPhan;
        partial void On_TenBoPhan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenBoPhan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongNghiPhep
        {
            get
            {
                return _tongNghiPhep;
            }
            set
            {
    			Nullable<int> oldValue =  _tongNghiPhep;
    			bool stopChanging = false;
                On_TongNghiPhep_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNghiPhep");
    			if(!stopChanging)
    			{
    				_tongNghiPhep = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNghiPhep");
    				On_TongNghiPhep_Changed(oldValue, _tongNghiPhep);//\\
    			}
            }
        }
    	public static String TongNghiPhep_PropertyName { get { return "TongNghiPhep"; } }
        private Nullable<int> _tongNghiPhep;
        partial void On_TongNghiPhep_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongNghiPhep_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongNghiDamTang
        {
            get
            {
                return _tongNghiDamTang;
            }
            set
            {
    			Nullable<int> oldValue =  _tongNghiDamTang;
    			bool stopChanging = false;
                On_TongNghiDamTang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNghiDamTang");
    			if(!stopChanging)
    			{
    				_tongNghiDamTang = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNghiDamTang");
    				On_TongNghiDamTang_Changed(oldValue, _tongNghiDamTang);//\\
    			}
            }
        }
    	public static String TongNghiDamTang_PropertyName { get { return "TongNghiDamTang"; } }
        private Nullable<int> _tongNghiDamTang;
        partial void On_TongNghiDamTang_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongNghiDamTang_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongNghiOm
        {
            get
            {
                return _tongNghiOm;
            }
            set
            {
    			Nullable<int> oldValue =  _tongNghiOm;
    			bool stopChanging = false;
                On_TongNghiOm_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNghiOm");
    			if(!stopChanging)
    			{
    				_tongNghiOm = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNghiOm");
    				On_TongNghiOm_Changed(oldValue, _tongNghiOm);//\\
    			}
            }
        }
    	public static String TongNghiOm_PropertyName { get { return "TongNghiOm"; } }
        private Nullable<int> _tongNghiOm;
        partial void On_TongNghiOm_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongNghiOm_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongNghiDamCuoi
        {
            get
            {
                return _tongNghiDamCuoi;
            }
            set
            {
    			Nullable<int> oldValue =  _tongNghiDamCuoi;
    			bool stopChanging = false;
                On_TongNghiDamCuoi_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNghiDamCuoi");
    			if(!stopChanging)
    			{
    				_tongNghiDamCuoi = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNghiDamCuoi");
    				On_TongNghiDamCuoi_Changed(oldValue, _tongNghiDamCuoi);//\\
    			}
            }
        }
    	public static String TongNghiDamCuoi_PropertyName { get { return "TongNghiDamCuoi"; } }
        private Nullable<int> _tongNghiDamCuoi;
        partial void On_TongNghiDamCuoi_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongNghiDamCuoi_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongNghiThaiSan
        {
            get
            {
                return _tongNghiThaiSan;
            }
            set
            {
    			Nullable<int> oldValue =  _tongNghiThaiSan;
    			bool stopChanging = false;
                On_TongNghiThaiSan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNghiThaiSan");
    			if(!stopChanging)
    			{
    				_tongNghiThaiSan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNghiThaiSan");
    				On_TongNghiThaiSan_Changed(oldValue, _tongNghiThaiSan);//\\
    			}
            }
        }
    	public static String TongNghiThaiSan_PropertyName { get { return "TongNghiThaiSan"; } }
        private Nullable<int> _tongNghiThaiSan;
        partial void On_TongNghiThaiSan_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongNghiThaiSan_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongNghiViecRieng
        {
            get
            {
                return _tongNghiViecRieng;
            }
            set
            {
    			Nullable<int> oldValue =  _tongNghiViecRieng;
    			bool stopChanging = false;
                On_TongNghiViecRieng_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNghiViecRieng");
    			if(!stopChanging)
    			{
    				_tongNghiViecRieng = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNghiViecRieng");
    				On_TongNghiViecRieng_Changed(oldValue, _tongNghiViecRieng);//\\
    			}
            }
        }
    	public static String TongNghiViecRieng_PropertyName { get { return "TongNghiViecRieng"; } }
        private Nullable<int> _tongNghiViecRieng;
        partial void On_TongNghiViecRieng_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongNghiViecRieng_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TongNghiKhac
        {
            get
            {
                return _tongNghiKhac;
            }
            set
            {
    			Nullable<int> oldValue =  _tongNghiKhac;
    			bool stopChanging = false;
                On_TongNghiKhac_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNghiKhac");
    			if(!stopChanging)
    			{
    				_tongNghiKhac = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNghiKhac");
    				On_TongNghiKhac_Changed(oldValue, _tongNghiKhac);//\\
    			}
            }
        }
    	public static String TongNghiKhac_PropertyName { get { return "TongNghiKhac"; } }
        private Nullable<int> _tongNghiKhac;
        partial void On_TongNghiKhac_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TongNghiKhac_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongNgayCongLamViec
        {
            get
            {
                return _tongNgayCongLamViec;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongNgayCongLamViec;
    			bool stopChanging = false;
                On_TongNgayCongLamViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNgayCongLamViec");
    			if(!stopChanging)
    			{
    				_tongNgayCongLamViec = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNgayCongLamViec");
    				On_TongNgayCongLamViec_Changed(oldValue, _tongNgayCongLamViec);//\\
    			}
            }
        }
    	public static String TongNgayCongLamViec_PropertyName { get { return "TongNgayCongLamViec"; } }
        private Nullable<decimal> _tongNgayCongLamViec;
        partial void On_TongNgayCongLamViec_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongNgayCongLamViec_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongNgayCongHuongLuong
        {
            get
            {
                return _tongNgayCongHuongLuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongNgayCongHuongLuong;
    			bool stopChanging = false;
                On_TongNgayCongHuongLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongNgayCongHuongLuong");
    			if(!stopChanging)
    			{
    				_tongNgayCongHuongLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongNgayCongHuongLuong");
    				On_TongNgayCongHuongLuong_Changed(oldValue, _tongNgayCongHuongLuong);//\\
    			}
            }
        }
    	public static String TongNgayCongHuongLuong_PropertyName { get { return "TongNgayCongHuongLuong"; } }
        private Nullable<decimal> _tongNgayCongHuongLuong;
        partial void On_TongNgayCongHuongLuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongNgayCongHuongLuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongKhongLuong
        {
            get
            {
                return _tongKhongLuong;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongKhongLuong;
    			bool stopChanging = false;
                On_TongKhongLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongKhongLuong");
    			if(!stopChanging)
    			{
    				_tongKhongLuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongKhongLuong");
    				On_TongKhongLuong_Changed(oldValue, _tongKhongLuong);//\\
    			}
            }
        }
    	public static String TongKhongLuong_PropertyName { get { return "TongKhongLuong"; } }
        private Nullable<decimal> _tongKhongLuong;
        partial void On_TongKhongLuong_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongKhongLuong_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongDiHoc
        {
            get
            {
                return _tongDiHoc;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongDiHoc;
    			bool stopChanging = false;
                On_TongDiHoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongDiHoc");
    			if(!stopChanging)
    			{
    				_tongDiHoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongDiHoc");
    				On_TongDiHoc_Changed(oldValue, _tongDiHoc);//\\
    			}
            }
        }
    	public static String TongDiHoc_PropertyName { get { return "TongDiHoc"; } }
        private Nullable<decimal> _tongDiHoc;
        partial void On_TongDiHoc_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongDiHoc_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> TongBHXH
        {
            get
            {
                return _tongBHXH;
            }
            set
            {
    			Nullable<decimal> oldValue =  _tongBHXH;
    			bool stopChanging = false;
                On_TongBHXH_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongBHXH");
    			if(!stopChanging)
    			{
    				_tongBHXH = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongBHXH");
    				On_TongBHXH_Changed(oldValue, _tongBHXH);//\\
    			}
            }
        }
    	public static String TongBHXH_PropertyName { get { return "TongBHXH"; } }
        private Nullable<decimal> _tongBHXH;
        partial void On_TongBHXH_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_TongBHXH_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string XepLoai
        {
            get
            {
                return _xepLoai;
            }
            set
            {
    			string oldValue =  _xepLoai;
    			bool stopChanging = false;
                On_XepLoai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("XepLoai");
    			if(!stopChanging)
    			{
    				_xepLoai = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("XepLoai");
    				On_XepLoai_Changed(oldValue, _xepLoai);//\\
    			}
            }
        }
    	public static String XepLoai_PropertyName { get { return "XepLoai"; } }
        private string _xepLoai;
        partial void On_XepLoai_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_XepLoai_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DienGiai
        {
            get
            {
                return _dienGiai;
            }
            set
            {
    			string oldValue =  _dienGiai;
    			bool stopChanging = false;
                On_DienGiai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DienGiai");
    			if(!stopChanging)
    			{
    				_dienGiai = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DienGiai");
    				On_DienGiai_Changed(oldValue, _dienGiai);//\\
    			}
            }
        }
    	public static String DienGiai_PropertyName { get { return "DienGiai"; } }
        private string _dienGiai;
        partial void On_DienGiai_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DienGiai_Changed(string oldValue, string currentValue);

    #endregion

    }
}
