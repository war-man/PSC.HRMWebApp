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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhNghienCuuKhoaHoc_LUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhNghienCuuKhoaHoc_LUH_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> TuNam
        {
            get
            {
                return _tuNam;
            }
            set
            {
    			Nullable<int> oldValue =  _tuNam;
    			bool stopChanging = false;
                On_TuNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNam");
    			if(!stopChanging)
    			{
    				_tuNam = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TuNam");
    				On_TuNam_Changed(oldValue, _tuNam);//\\
    			}
            }
        }
    	public static String TuNam_PropertyName { get { return "TuNam"; } }
        private Nullable<int> _tuNam;
        partial void On_TuNam_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_TuNam_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> DenNam
        {
            get
            {
                return _denNam;
            }
            set
            {
    			Nullable<int> oldValue =  _denNam;
    			bool stopChanging = false;
                On_DenNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNam");
    			if(!stopChanging)
    			{
    				_denNam = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DenNam");
    				On_DenNam_Changed(oldValue, _denNam);//\\
    			}
            }
        }
    	public static String DenNam_PropertyName { get { return "DenNam"; } }
        private Nullable<int> _denNam;
        partial void On_DenNam_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_DenNam_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string CapQuanLy
        {
            get
            {
                return _capQuanLy;
            }
            set
            {
    			string oldValue =  _capQuanLy;
    			bool stopChanging = false;
                On_CapQuanLy_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CapQuanLy");
    			if(!stopChanging)
    			{
    				_capQuanLy = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("CapQuanLy");
    				On_CapQuanLy_Changed(oldValue, _capQuanLy);//\\
    			}
            }
        }
    	public static String CapQuanLy_PropertyName { get { return "CapQuanLy"; } }
        private string _capQuanLy;
        partial void On_CapQuanLy_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_CapQuanLy_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string CoQuanChuTri
        {
            get
            {
                return _coQuanChuTri;
            }
            set
            {
    			string oldValue =  _coQuanChuTri;
    			bool stopChanging = false;
                On_CoQuanChuTri_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("CoQuanChuTri");
    			if(!stopChanging)
    			{
    				_coQuanChuTri = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("CoQuanChuTri");
    				On_CoQuanChuTri_Changed(oldValue, _coQuanChuTri);//\\
    			}
            }
        }
    	public static String CoQuanChuTri_PropertyName { get { return "CoQuanChuTri"; } }
        private string _coQuanChuTri;
        partial void On_CoQuanChuTri_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_CoQuanChuTri_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChucDanhThamGia
        {
            get
            {
                return _chucDanhThamGia;
            }
            set
            {
    			string oldValue =  _chucDanhThamGia;
    			bool stopChanging = false;
                On_ChucDanhThamGia_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChucDanhThamGia");
    			if(!stopChanging)
    			{
    				_chucDanhThamGia = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChucDanhThamGia");
    				On_ChucDanhThamGia_Changed(oldValue, _chucDanhThamGia);//\\
    			}
            }
        }
    	public static String ChucDanhThamGia_PropertyName { get { return "ChucDanhThamGia"; } }
        private string _chucDanhThamGia;
        partial void On_ChucDanhThamGia_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChucDanhThamGia_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenDeTai
        {
            get
            {
                return _tenDeTai;
            }
            set
            {
    			string oldValue =  _tenDeTai;
    			bool stopChanging = false;
                On_TenDeTai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenDeTai");
    			if(!stopChanging)
    			{
    				_tenDeTai = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenDeTai");
    				On_TenDeTai_Changed(oldValue, _tenDeTai);//\\
    			}
            }
        }
    	public static String TenDeTai_PropertyName { get { return "TenDeTai"; } }
        private string _tenDeTai;
        partial void On_TenDeTai_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenDeTai_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayNghiemThu
        {
            get
            {
                return _ngayNghiemThu;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayNghiemThu;
    			bool stopChanging = false;
                On_NgayNghiemThu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayNghiemThu");
    			if(!stopChanging)
    			{
    				_ngayNghiemThu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayNghiemThu");
    				On_NgayNghiemThu_Changed(oldValue, _ngayNghiemThu);//\\
    			}
            }
        }
    	public static String NgayNghiemThu_PropertyName { get { return "NgayNghiemThu"; } }
        private Nullable<System.DateTime> _ngayNghiemThu;
        partial void On_NgayNghiemThu_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayNghiemThu_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiQuanLyKetQua
        {
            get
            {
                return _noiQuanLyKetQua;
            }
            set
            {
    			string oldValue =  _noiQuanLyKetQua;
    			bool stopChanging = false;
                On_NoiQuanLyKetQua_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiQuanLyKetQua");
    			if(!stopChanging)
    			{
    				_noiQuanLyKetQua = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiQuanLyKetQua");
    				On_NoiQuanLyKetQua_Changed(oldValue, _noiQuanLyKetQua);//\\
    			}
            }
        }
    	public static String NoiQuanLyKetQua_PropertyName { get { return "NoiQuanLyKetQua"; } }
        private string _noiQuanLyKetQua;
        partial void On_NoiQuanLyKetQua_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiQuanLyKetQua_Changed(string oldValue, string currentValue);

    #endregion

    }
}
