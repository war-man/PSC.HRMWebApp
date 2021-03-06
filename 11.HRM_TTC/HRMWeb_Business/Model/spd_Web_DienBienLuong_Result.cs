//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 09:24:55 ngay 29/02/2020
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web_DienBienLuong_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web_DienBienLuong_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web_DienBienLuong_Result object.
        /// </summary>
        /// <param name="tongPhuCap">Initial value of the TongPhuCap property.</param>
        public static spd_Web_DienBienLuong_Result Createspd_Web_DienBienLuong_Result(int tongPhuCap)
        {
            spd_Web_DienBienLuong_Result spd_Web_DienBienLuong_Result = new spd_Web_DienBienLuong_Result();
            spd_Web_DienBienLuong_Result.TongPhuCap = tongPhuCap;
            return spd_Web_DienBienLuong_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayQuyetDinh
        {
            get
            {
                return _ngayQuyetDinh;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayQuyetDinh;
    			bool stopChanging = false;
                On_NgayQuyetDinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayQuyetDinh");
    			if(!stopChanging)
    			{
    				_ngayQuyetDinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayQuyetDinh");
    				On_NgayQuyetDinh_Changed(oldValue, _ngayQuyetDinh);//\\
    			}
            }
        }
    	public static String NgayQuyetDinh_PropertyName { get { return "NgayQuyetDinh"; } }
        private Nullable<System.DateTime> _ngayQuyetDinh;
        partial void On_NgayQuyetDinh_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayQuyetDinh_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoQuyetDinh
        {
            get
            {
                return _soQuyetDinh;
            }
            set
            {
    			string oldValue =  _soQuyetDinh;
    			bool stopChanging = false;
                On_SoQuyetDinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoQuyetDinh");
    			if(!stopChanging)
    			{
    				_soQuyetDinh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoQuyetDinh");
    				On_SoQuyetDinh_Changed(oldValue, _soQuyetDinh);//\\
    			}
            }
        }
    	public static String SoQuyetDinh_PropertyName { get { return "SoQuyetDinh"; } }
        private string _soQuyetDinh;
        partial void On_SoQuyetDinh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoQuyetDinh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiDung
        {
            get
            {
                return _noiDung;
            }
            set
            {
    			string oldValue =  _noiDung;
    			bool stopChanging = false;
                On_NoiDung_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiDung");
    			if(!stopChanging)
    			{
    				_noiDung = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiDung");
    				On_NoiDung_Changed(oldValue, _noiDung);//\\
    			}
            }
        }
    	public static String NoiDung_PropertyName { get { return "NoiDung"; } }
        private string _noiDung;
        partial void On_NoiDung_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiDung_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> TuNgay
        {
            get
            {
                return _tuNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _tuNgay;
    			bool stopChanging = false;
                On_TuNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNgay");
    			if(!stopChanging)
    			{
    				_tuNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TuNgay");
    				On_TuNgay_Changed(oldValue, _tuNgay);//\\
    			}
            }
        }
    	public static String TuNgay_PropertyName { get { return "TuNgay"; } }
        private Nullable<System.DateTime> _tuNgay;
        partial void On_TuNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_TuNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> DenNgay
        {
            get
            {
                return _denNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _denNgay;
    			bool stopChanging = false;
                On_DenNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNgay");
    			if(!stopChanging)
    			{
    				_denNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DenNgay");
    				On_DenNgay_Changed(oldValue, _denNgay);//\\
    			}
            }
        }
    	public static String DenNgay_PropertyName { get { return "DenNgay"; } }
        private Nullable<System.DateTime> _denNgay;
        partial void On_DenNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_DenNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgachLuong
        {
            get
            {
                return _ngachLuong;
            }
            set
            {
    			string oldValue =  _ngachLuong;
    			bool stopChanging = false;
                On_NgachLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgachLuong");
    			if(!stopChanging)
    			{
    				_ngachLuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgachLuong");
    				On_NgachLuong_Changed(oldValue, _ngachLuong);//\\
    			}
            }
        }
    	public static String NgachLuong_PropertyName { get { return "NgachLuong"; } }
        private string _ngachLuong;
        partial void On_NgachLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgachLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string BacLuong
        {
            get
            {
                return _bacLuong;
            }
            set
            {
    			string oldValue =  _bacLuong;
    			bool stopChanging = false;
                On_BacLuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("BacLuong");
    			if(!stopChanging)
    			{
    				_bacLuong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("BacLuong");
    				On_BacLuong_Changed(oldValue, _bacLuong);//\\
    			}
            }
        }
    	public static String BacLuong_PropertyName { get { return "BacLuong"; } }
        private string _bacLuong;
        partial void On_BacLuong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_BacLuong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string LuongCoBan
        {
            get
            {
                return _luongCoBan;
            }
            set
            {
    			string oldValue =  _luongCoBan;
    			bool stopChanging = false;
                On_LuongCoBan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LuongCoBan");
    			if(!stopChanging)
    			{
    				_luongCoBan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LuongCoBan");
    				On_LuongCoBan_Changed(oldValue, _luongCoBan);//\\
    			}
            }
        }
    	public static String LuongCoBan_PropertyName { get { return "LuongCoBan"; } }
        private string _luongCoBan;
        partial void On_LuongCoBan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LuongCoBan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string LuongKinhDoanh
        {
            get
            {
                return _luongKinhDoanh;
            }
            set
            {
    			string oldValue =  _luongKinhDoanh;
    			bool stopChanging = false;
                On_LuongKinhDoanh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LuongKinhDoanh");
    			if(!stopChanging)
    			{
    				_luongKinhDoanh = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LuongKinhDoanh");
    				On_LuongKinhDoanh_Changed(oldValue, _luongKinhDoanh);//\\
    			}
            }
        }
    	public static String LuongKinhDoanh_PropertyName { get { return "LuongKinhDoanh"; } }
        private string _luongKinhDoanh;
        partial void On_LuongKinhDoanh_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LuongKinhDoanh_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public int TongPhuCap
        {
            get
            {
                return _tongPhuCap;
            }
            set
            {
    			int oldValue =  _tongPhuCap;
    			bool stopChanging = false;
                On_TongPhuCap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TongPhuCap");
    			if(!stopChanging)
    			{
    				_tongPhuCap = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TongPhuCap");
    				On_TongPhuCap_Changed(oldValue, _tongPhuCap);//\\
    			}
            }
        }
    	public static String TongPhuCap_PropertyName { get { return "TongPhuCap"; } }
        private int _tongPhuCap;
        partial void On_TongPhuCap_Changing(int currentValue, ref int newValue, ref bool stopChanging);
        partial void On_TongPhuCap_Changed(int oldValue, int currentValue);

    #endregion

    }
}
