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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_HopDongDaKy_LUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_HopDongDaKy_LUH_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoHopDong
        {
            get
            {
                return _soHopDong;
            }
            set
            {
    			string oldValue =  _soHopDong;
    			bool stopChanging = false;
                On_SoHopDong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoHopDong");
    			if(!stopChanging)
    			{
    				_soHopDong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoHopDong");
    				On_SoHopDong_Changed(oldValue, _soHopDong);//\\
    			}
            }
        }
    	public static String SoHopDong_PropertyName { get { return "SoHopDong"; } }
        private string _soHopDong;
        partial void On_SoHopDong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoHopDong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string LoaiHopDong
        {
            get
            {
                return _loaiHopDong;
            }
            set
            {
    			string oldValue =  _loaiHopDong;
    			bool stopChanging = false;
                On_LoaiHopDong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LoaiHopDong");
    			if(!stopChanging)
    			{
    				_loaiHopDong = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LoaiHopDong");
    				On_LoaiHopDong_Changed(oldValue, _loaiHopDong);//\\
    			}
            }
        }
    	public static String LoaiHopDong_PropertyName { get { return "LoaiHopDong"; } }
        private string _loaiHopDong;
        partial void On_LoaiHopDong_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LoaiHopDong_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayKy
        {
            get
            {
                return _ngayKy;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayKy;
    			bool stopChanging = false;
                On_NgayKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayKy");
    			if(!stopChanging)
    			{
    				_ngayKy = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayKy");
    				On_NgayKy_Changed(oldValue, _ngayKy);//\\
    			}
            }
        }
    	public static String NgayKy_PropertyName { get { return "NgayKy"; } }
        private Nullable<System.DateTime> _ngayKy;
        partial void On_NgayKy_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayKy_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NguoiKy
        {
            get
            {
                return _nguoiKy;
            }
            set
            {
    			string oldValue =  _nguoiKy;
    			bool stopChanging = false;
                On_NguoiKy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NguoiKy");
    			if(!stopChanging)
    			{
    				_nguoiKy = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NguoiKy");
    				On_NguoiKy_Changed(oldValue, _nguoiKy);//\\
    			}
            }
        }
    	public static String NguoiKy_PropertyName { get { return "NguoiKy"; } }
        private string _nguoiKy;
        partial void On_NguoiKy_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NguoiKy_Changed(string oldValue, string currentValue);
    
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

    #endregion

    }
}
