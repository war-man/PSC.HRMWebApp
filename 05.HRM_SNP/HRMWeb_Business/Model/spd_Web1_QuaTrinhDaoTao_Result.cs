//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 05:03:08 ngay 23/05/2017
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhDaoTao_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhDaoTao_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> NamNhapHoc
        {
            get
            {
                return _namNhapHoc;
            }
            set
            {
    			Nullable<int> oldValue =  _namNhapHoc;
    			bool stopChanging = false;
                On_NamNhapHoc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NamNhapHoc");
    			if(!stopChanging)
    			{
    				_namNhapHoc = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NamNhapHoc");
    				On_NamNhapHoc_Changed(oldValue, _namNhapHoc);//\\
    			}
            }
        }
    	public static String NamNhapHoc_PropertyName { get { return "NamNhapHoc"; } }
        private Nullable<int> _namNhapHoc;
        partial void On_NamNhapHoc_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_NamNhapHoc_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TrinhDoChuyenMon
        {
            get
            {
                return _trinhDoChuyenMon;
            }
            set
            {
    			string oldValue =  _trinhDoChuyenMon;
    			bool stopChanging = false;
                On_TrinhDoChuyenMon_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TrinhDoChuyenMon");
    			if(!stopChanging)
    			{
    				_trinhDoChuyenMon = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TrinhDoChuyenMon");
    				On_TrinhDoChuyenMon_Changed(oldValue, _trinhDoChuyenMon);//\\
    			}
            }
        }
    	public static String TrinhDoChuyenMon_PropertyName { get { return "TrinhDoChuyenMon"; } }
        private string _trinhDoChuyenMon;
        partial void On_TrinhDoChuyenMon_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TrinhDoChuyenMon_Changed(string oldValue, string currentValue);
    
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

    #endregion

    }
}
