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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web_QuanHeGiaDinh_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web_QuanHeGiaDinh_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web_QuanHeGiaDinh_Result object.
        /// </summary>
        /// <param name="tinhTrang">Initial value of the TinhTrang property.</param>
        public static spd_Web_QuanHeGiaDinh_Result Createspd_Web_QuanHeGiaDinh_Result(string tinhTrang)
        {
            spd_Web_QuanHeGiaDinh_Result spd_Web_QuanHeGiaDinh_Result = new spd_Web_QuanHeGiaDinh_Result();
            spd_Web_QuanHeGiaDinh_Result.TinhTrang = tinhTrang;
            return spd_Web_QuanHeGiaDinh_Result;
        }

        #endregion

    #region Primitive Properties
    
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
        public Nullable<int> NamSinh
        {
            get
            {
                return _namSinh;
            }
            set
            {
    			Nullable<int> oldValue =  _namSinh;
    			bool stopChanging = false;
                On_NamSinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NamSinh");
    			if(!stopChanging)
    			{
    				_namSinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NamSinh");
    				On_NamSinh_Changed(oldValue, _namSinh);//\\
    			}
            }
        }
    	public static String NamSinh_PropertyName { get { return "NamSinh"; } }
        private Nullable<int> _namSinh;
        partial void On_NamSinh_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_NamSinh_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuanHe
        {
            get
            {
                return _quanHe;
            }
            set
            {
    			string oldValue =  _quanHe;
    			bool stopChanging = false;
                On_QuanHe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanHe");
    			if(!stopChanging)
    			{
    				_quanHe = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuanHe");
    				On_QuanHe_Changed(oldValue, _quanHe);//\\
    			}
            }
        }
    	public static String QuanHe_PropertyName { get { return "QuanHe"; } }
        private string _quanHe;
        partial void On_QuanHe_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuanHe_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiOHienNay
        {
            get
            {
                return _noiOHienNay;
            }
            set
            {
    			string oldValue =  _noiOHienNay;
    			bool stopChanging = false;
                On_NoiOHienNay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiOHienNay");
    			if(!stopChanging)
    			{
    				_noiOHienNay = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiOHienNay");
    				On_NoiOHienNay_Changed(oldValue, _noiOHienNay);//\\
    			}
            }
        }
    	public static String NoiOHienNay_PropertyName { get { return "NoiOHienNay"; } }
        private string _noiOHienNay;
        partial void On_NoiOHienNay_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiOHienNay_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgheNghiep
        {
            get
            {
                return _ngheNghiep;
            }
            set
            {
    			string oldValue =  _ngheNghiep;
    			bool stopChanging = false;
                On_NgheNghiep_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgheNghiep");
    			if(!stopChanging)
    			{
    				_ngheNghiep = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgheNghiep");
    				On_NgheNghiep_Changed(oldValue, _ngheNghiep);//\\
    			}
            }
        }
    	public static String NgheNghiep_PropertyName { get { return "NgheNghiep"; } }
        private string _ngheNghiep;
        partial void On_NgheNghiep_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgheNghiep_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiLamViec
        {
            get
            {
                return _noiLamViec;
            }
            set
            {
    			string oldValue =  _noiLamViec;
    			bool stopChanging = false;
                On_NoiLamViec_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiLamViec");
    			if(!stopChanging)
    			{
    				_noiLamViec = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiLamViec");
    				On_NoiLamViec_Changed(oldValue, _noiLamViec);//\\
    			}
            }
        }
    	public static String NoiLamViec_PropertyName { get { return "NoiLamViec"; } }
        private string _noiLamViec;
        partial void On_NoiLamViec_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiLamViec_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string TinhTrang
        {
            get
            {
                return _tinhTrang;
            }
            set
            {
    			string oldValue =  _tinhTrang;
    			bool stopChanging = false;
                On_TinhTrang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TinhTrang");
    			if(!stopChanging)
    			{
    				_tinhTrang = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("TinhTrang");
    				On_TinhTrang_Changed(oldValue, _tinhTrang);//\\
    			}
            }
        }
    	public static String TinhTrang_PropertyName { get { return "TinhTrang"; } }
        private string _tinhTrang;
        partial void On_TinhTrang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TinhTrang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DienThoaiDiDong
        {
            get
            {
                return _dienThoaiDiDong;
            }
            set
            {
    			string oldValue =  _dienThoaiDiDong;
    			bool stopChanging = false;
                On_DienThoaiDiDong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DienThoaiDiDong");
    			if(!stopChanging)
    			{
    				_dienThoaiDiDong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DienThoaiDiDong");
    				On_DienThoaiDiDong_Changed(oldValue, _dienThoaiDiDong);//\\
    			}
            }
        }
    	public static String DienThoaiDiDong_PropertyName { get { return "DienThoaiDiDong"; } }
        private string _dienThoaiDiDong;
        partial void On_DienThoaiDiDong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DienThoaiDiDong_Changed(string oldValue, string currentValue);

    #endregion

    }
}