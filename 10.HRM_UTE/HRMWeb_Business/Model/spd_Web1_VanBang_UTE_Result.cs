//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi SERVERERP\tai luc 09:33:23 ngay 03/10/2017
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_VanBang_UTE_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_VanBang_UTE_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_VanBang_UTE_Result object.
        /// </summary>
        /// <param name="xepLoai">Initial value of the XepLoai property.</param>
        public static spd_Web1_VanBang_UTE_Result Createspd_Web1_VanBang_UTE_Result(string xepLoai)
        {
            spd_Web1_VanBang_UTE_Result spd_Web1_VanBang_UTE_Result = new spd_Web1_VanBang_UTE_Result();
            spd_Web1_VanBang_UTE_Result.XepLoai = xepLoai;
            return spd_Web1_VanBang_UTE_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenTrinhDoChuyenMon
        {
            get
            {
                return _tenTrinhDoChuyenMon;
            }
            set
            {
    			string oldValue =  _tenTrinhDoChuyenMon;
    			bool stopChanging = false;
                On_TenTrinhDoChuyenMon_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenTrinhDoChuyenMon");
    			if(!stopChanging)
    			{
    				_tenTrinhDoChuyenMon = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenTrinhDoChuyenMon");
    				On_TenTrinhDoChuyenMon_Changed(oldValue, _tenTrinhDoChuyenMon);//\\
    			}
            }
        }
    	public static String TenTrinhDoChuyenMon_PropertyName { get { return "TenTrinhDoChuyenMon"; } }
        private string _tenTrinhDoChuyenMon;
        partial void On_TenTrinhDoChuyenMon_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenTrinhDoChuyenMon_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChuyenNganhDaoTao
        {
            get
            {
                return _chuyenNganhDaoTao;
            }
            set
            {
    			string oldValue =  _chuyenNganhDaoTao;
    			bool stopChanging = false;
                On_ChuyenNganhDaoTao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChuyenNganhDaoTao");
    			if(!stopChanging)
    			{
    				_chuyenNganhDaoTao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChuyenNganhDaoTao");
    				On_ChuyenNganhDaoTao_Changed(oldValue, _chuyenNganhDaoTao);//\\
    			}
            }
        }
    	public static String ChuyenNganhDaoTao_PropertyName { get { return "ChuyenNganhDaoTao"; } }
        private string _chuyenNganhDaoTao;
        partial void On_ChuyenNganhDaoTao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChuyenNganhDaoTao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TruongDaoTao
        {
            get
            {
                return _truongDaoTao;
            }
            set
            {
    			string oldValue =  _truongDaoTao;
    			bool stopChanging = false;
                On_TruongDaoTao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TruongDaoTao");
    			if(!stopChanging)
    			{
    				_truongDaoTao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TruongDaoTao");
    				On_TruongDaoTao_Changed(oldValue, _truongDaoTao);//\\
    			}
            }
        }
    	public static String TruongDaoTao_PropertyName { get { return "TruongDaoTao"; } }
        private string _truongDaoTao;
        partial void On_TruongDaoTao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TruongDaoTao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string HinhThucDaoTao
        {
            get
            {
                return _hinhThucDaoTao;
            }
            set
            {
    			string oldValue =  _hinhThucDaoTao;
    			bool stopChanging = false;
                On_HinhThucDaoTao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HinhThucDaoTao");
    			if(!stopChanging)
    			{
    				_hinhThucDaoTao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HinhThucDaoTao");
    				On_HinhThucDaoTao_Changed(oldValue, _hinhThucDaoTao);//\\
    			}
            }
        }
    	public static String HinhThucDaoTao_PropertyName { get { return "HinhThucDaoTao"; } }
        private string _hinhThucDaoTao;
        partial void On_HinhThucDaoTao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HinhThucDaoTao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> NamTotNghiep
        {
            get
            {
                return _namTotNghiep;
            }
            set
            {
    			Nullable<int> oldValue =  _namTotNghiep;
    			bool stopChanging = false;
                On_NamTotNghiep_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NamTotNghiep");
    			if(!stopChanging)
    			{
    				_namTotNghiep = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NamTotNghiep");
    				On_NamTotNghiep_Changed(oldValue, _namTotNghiep);//\\
    			}
            }
        }
    	public static String NamTotNghiep_PropertyName { get { return "NamTotNghiep"; } }
        private Nullable<int> _namTotNghiep;
        partial void On_NamTotNghiep_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_NamTotNghiep_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
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
    				_xepLoai = StructuralObject.SetValidValue(value, false);
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
        public Nullable<decimal> DiemTrungBinh
        {
            get
            {
                return _diemTrungBinh;
            }
            set
            {
    			Nullable<decimal> oldValue =  _diemTrungBinh;
    			bool stopChanging = false;
                On_DiemTrungBinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DiemTrungBinh");
    			if(!stopChanging)
    			{
    				_diemTrungBinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DiemTrungBinh");
    				On_DiemTrungBinh_Changed(oldValue, _diemTrungBinh);//\\
    			}
            }
        }
    	public static String DiemTrungBinh_PropertyName { get { return "DiemTrungBinh"; } }
        private Nullable<decimal> _diemTrungBinh;
        partial void On_DiemTrungBinh_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_DiemTrungBinh_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
