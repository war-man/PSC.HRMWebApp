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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_DangVien_LUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_DangVien_LUH_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DangBo
        {
            get
            {
                return _dangBo;
            }
            set
            {
    			string oldValue =  _dangBo;
    			bool stopChanging = false;
                On_DangBo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DangBo");
    			if(!stopChanging)
    			{
    				_dangBo = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DangBo");
    				On_DangBo_Changed(oldValue, _dangBo);//\\
    			}
            }
        }
    	public static String DangBo_PropertyName { get { return "DangBo"; } }
        private string _dangBo;
        partial void On_DangBo_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DangBo_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ChiBoDang
        {
            get
            {
                return _chiBoDang;
            }
            set
            {
    			string oldValue =  _chiBoDang;
    			bool stopChanging = false;
                On_ChiBoDang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ChiBoDang");
    			if(!stopChanging)
    			{
    				_chiBoDang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ChiBoDang");
    				On_ChiBoDang_Changed(oldValue, _chiBoDang);//\\
    			}
            }
        }
    	public static String ChiBoDang_PropertyName { get { return "ChiBoDang"; } }
        private string _chiBoDang;
        partial void On_ChiBoDang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ChiBoDang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoLyLich
        {
            get
            {
                return _soLyLich;
            }
            set
            {
    			string oldValue =  _soLyLich;
    			bool stopChanging = false;
                On_SoLyLich_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoLyLich");
    			if(!stopChanging)
    			{
    				_soLyLich = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoLyLich");
    				On_SoLyLich_Changed(oldValue, _soLyLich);//\\
    			}
            }
        }
    	public static String SoLyLich_PropertyName { get { return "SoLyLich"; } }
        private string _soLyLich;
        partial void On_SoLyLich_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoLyLich_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgayVaoDang
        {
            get
            {
                return _ngayVaoDang;
            }
            set
            {
    			string oldValue =  _ngayVaoDang;
    			bool stopChanging = false;
                On_NgayVaoDang_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayVaoDang");
    			if(!stopChanging)
    			{
    				_ngayVaoDang = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayVaoDang");
    				On_NgayVaoDang_Changed(oldValue, _ngayVaoDang);//\\
    			}
            }
        }
    	public static String NgayVaoDang_PropertyName { get { return "NgayVaoDang"; } }
        private string _ngayVaoDang;
        partial void On_NgayVaoDang_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayVaoDang_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgayVaoDangChinhThuc
        {
            get
            {
                return _ngayVaoDangChinhThuc;
            }
            set
            {
    			string oldValue =  _ngayVaoDangChinhThuc;
    			bool stopChanging = false;
                On_NgayVaoDangChinhThuc_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayVaoDangChinhThuc");
    			if(!stopChanging)
    			{
    				_ngayVaoDangChinhThuc = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayVaoDangChinhThuc");
    				On_NgayVaoDangChinhThuc_Changed(oldValue, _ngayVaoDangChinhThuc);//\\
    			}
            }
        }
    	public static String NgayVaoDangChinhThuc_PropertyName { get { return "NgayVaoDangChinhThuc"; } }
        private string _ngayVaoDangChinhThuc;
        partial void On_NgayVaoDangChinhThuc_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayVaoDangChinhThuc_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoThe
        {
            get
            {
                return _soThe;
            }
            set
            {
    			string oldValue =  _soThe;
    			bool stopChanging = false;
                On_SoThe_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoThe");
    			if(!stopChanging)
    			{
    				_soThe = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoThe");
    				On_SoThe_Changed(oldValue, _soThe);//\\
    			}
            }
        }
    	public static String SoThe_PropertyName { get { return "SoThe"; } }
        private string _soThe;
        partial void On_SoThe_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoThe_Changed(string oldValue, string currentValue);
    
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
        public string NgayCap
        {
            get
            {
                return _ngayCap;
            }
            set
            {
    			string oldValue =  _ngayCap;
    			bool stopChanging = false;
                On_NgayCap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayCap");
    			if(!stopChanging)
    			{
    				_ngayCap = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayCap");
    				On_NgayCap_Changed(oldValue, _ngayCap);//\\
    			}
            }
        }
    	public static String NgayCap_PropertyName { get { return "NgayCap"; } }
        private string _ngayCap;
        partial void On_NgayCap_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayCap_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiCap
        {
            get
            {
                return _noiCap;
            }
            set
            {
    			string oldValue =  _noiCap;
    			bool stopChanging = false;
                On_NoiCap_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiCap");
    			if(!stopChanging)
    			{
    				_noiCap = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiCap");
    				On_NoiCap_Changed(oldValue, _noiCap);//\\
    			}
            }
        }
    	public static String NoiCap_PropertyName { get { return "NoiCap"; } }
        private string _noiCap;
        partial void On_NoiCap_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiCap_Changed(string oldValue, string currentValue);

    #endregion

    }
}
