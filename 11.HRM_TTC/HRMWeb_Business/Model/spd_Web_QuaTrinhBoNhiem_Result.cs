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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web_QuaTrinhBoNhiem_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web_QuaTrinhBoNhiem_Result : ComplexObject
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
        public Nullable<System.DateTime> NgayHuongChucVu
        {
            get
            {
                return _ngayHuongChucVu;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayHuongChucVu;
    			bool stopChanging = false;
                On_NgayHuongChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayHuongChucVu");
    			if(!stopChanging)
    			{
    				_ngayHuongChucVu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayHuongChucVu");
    				On_NgayHuongChucVu_Changed(oldValue, _ngayHuongChucVu);//\\
    			}
            }
        }
    	public static String NgayHuongChucVu_PropertyName { get { return "NgayHuongChucVu"; } }
        private Nullable<System.DateTime> _ngayHuongChucVu;
        partial void On_NgayHuongChucVu_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayHuongChucVu_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
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
        public Nullable<decimal> PhuCapChucVu
        {
            get
            {
                return _phuCapChucVu;
            }
            set
            {
    			Nullable<decimal> oldValue =  _phuCapChucVu;
    			bool stopChanging = false;
                On_PhuCapChucVu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("PhuCapChucVu");
    			if(!stopChanging)
    			{
    				_phuCapChucVu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("PhuCapChucVu");
    				On_PhuCapChucVu_Changed(oldValue, _phuCapChucVu);//\\
    			}
            }
        }
    	public static String PhuCapChucVu_PropertyName { get { return "PhuCapChucVu"; } }
        private Nullable<decimal> _phuCapChucVu;
        partial void On_PhuCapChucVu_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_PhuCapChucVu_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
