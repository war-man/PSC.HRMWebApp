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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhBoNhiem_BUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhBoNhiem_BUH_Result : ComplexObject
    {
    #region Primitive Properties
    
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
        public string TuNam
        {
            get
            {
                return _tuNam;
            }
            set
            {
    			string oldValue =  _tuNam;
    			bool stopChanging = false;
                On_TuNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNam");
    			if(!stopChanging)
    			{
    				_tuNam = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TuNam");
    				On_TuNam_Changed(oldValue, _tuNam);//\\
    			}
            }
        }
    	public static String TuNam_PropertyName { get { return "TuNam"; } }
        private string _tuNam;
        partial void On_TuNam_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TuNam_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DenNam
        {
            get
            {
                return _denNam;
            }
            set
            {
    			string oldValue =  _denNam;
    			bool stopChanging = false;
                On_DenNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNam");
    			if(!stopChanging)
    			{
    				_denNam = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DenNam");
    				On_DenNam_Changed(oldValue, _denNam);//\\
    			}
            }
        }
    	public static String DenNam_PropertyName { get { return "DenNam"; } }
        private string _denNam;
        partial void On_DenNam_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DenNam_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChucVu
        {
            get
            {
                return _chucVu;
            }
            set
            {
    			string oldValue =  _chucVu;
    			bool stopChanging = false;
                On_ChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChucVu");
    			if(!stopChanging)
    			{
    				_chucVu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChucVu");
    				On_ChucVu_Changed(oldValue, _chucVu);//\\
    			}
            }
        }
    	public static String ChucVu_PropertyName { get { return "ChucVu"; } }
        private string _chucVu;
        partial void On_ChucVu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChucVu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> HSPCChucVu
        {
            get
            {
                return _hSPCChucVu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _hSPCChucVu;
    			bool stopChanging = false;
                On_HSPCChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HSPCChucVu");
    			if(!stopChanging)
    			{
    				_hSPCChucVu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("HSPCChucVu");
    				On_HSPCChucVu_Changed(oldValue, _hSPCChucVu);//\\
    			}
            }
        }
    	public static String HSPCChucVu_PropertyName { get { return "HSPCChucVu"; } }
        private Nullable<decimal> _hSPCChucVu;
        partial void On_HSPCChucVu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_HSPCChucVu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayHuongHSPCChucVu
        {
            get
            {
                return _ngayHuongHSPCChucVu;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayHuongHSPCChucVu;
    			bool stopChanging = false;
                On_NgayHuongHSPCChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayHuongHSPCChucVu");
    			if(!stopChanging)
    			{
    				_ngayHuongHSPCChucVu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayHuongHSPCChucVu");
    				On_NgayHuongHSPCChucVu_Changed(oldValue, _ngayHuongHSPCChucVu);//\\
    			}
            }
        }
    	public static String NgayHuongHSPCChucVu_PropertyName { get { return "NgayHuongHSPCChucVu"; } }
        private Nullable<System.DateTime> _ngayHuongHSPCChucVu;
        partial void On_NgayHuongHSPCChucVu_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayHuongHSPCChucVu_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);

    #endregion

    }
}
