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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_ChiTietThuLaoGiangDay_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_ChiTietThuLaoGiangDay_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_ChiTietThuLaoGiangDay_Result object.
        /// </summary>
        /// <param name="dienGiai">Initial value of the DienGiai property.</param>
        /// <param name="soTien">Initial value of the SoTien property.</param>
        public static spd_Web1_ChiTietThuLaoGiangDay_Result Createspd_Web1_ChiTietThuLaoGiangDay_Result(string dienGiai, decimal soTien)
        {
            spd_Web1_ChiTietThuLaoGiangDay_Result spd_Web1_ChiTietThuLaoGiangDay_Result = new spd_Web1_ChiTietThuLaoGiangDay_Result();
            spd_Web1_ChiTietThuLaoGiangDay_Result.DienGiai = dienGiai;
            spd_Web1_ChiTietThuLaoGiangDay_Result.SoTien = soTien;
            return spd_Web1_ChiTietThuLaoGiangDay_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayTinh
        {
            get
            {
                return _ngayTinh;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayTinh;
    			bool stopChanging = false;
                On_NgayTinh_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayTinh");
    			if(!stopChanging)
    			{
    				_ngayTinh = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayTinh");
    				On_NgayTinh_Changed(oldValue, _ngayTinh);//\\
    			}
            }
        }
    	public static String NgayTinh_PropertyName { get { return "NgayTinh"; } }
        private Nullable<System.DateTime> _ngayTinh;
        partial void On_NgayTinh_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayTinh_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
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
    				_dienGiai = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("DienGiai");
    				On_DienGiai_Changed(oldValue, _dienGiai);//\\
    			}
            }
        }
    	public static String DienGiai_PropertyName { get { return "DienGiai"; } }
        private string _dienGiai;
        partial void On_DienGiai_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DienGiai_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public decimal SoTien
        {
            get
            {
                return _soTien;
            }
            set
            {
    			decimal oldValue =  _soTien;
    			bool stopChanging = false;
                On_SoTien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoTien");
    			if(!stopChanging)
    			{
    				_soTien = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoTien");
    				On_SoTien_Changed(oldValue, _soTien);//\\
    			}
            }
        }
    	public static String SoTien_PropertyName { get { return "SoTien"; } }
        private decimal _soTien;
        partial void On_SoTien_Changing(decimal currentValue, ref decimal newValue, ref bool stopChanging);
        partial void On_SoTien_Changed(decimal oldValue, decimal currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> KhongTinhThue
        {
            get
            {
                return _khongTinhThue;
            }
            set
            {
    			Nullable<decimal> oldValue =  _khongTinhThue;
    			bool stopChanging = false;
                On_KhongTinhThue_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("KhongTinhThue");
    			if(!stopChanging)
    			{
    				_khongTinhThue = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("KhongTinhThue");
    				On_KhongTinhThue_Changed(oldValue, _khongTinhThue);//\\
    			}
            }
        }
    	public static String KhongTinhThue_PropertyName { get { return "KhongTinhThue"; } }
        private Nullable<decimal> _khongTinhThue;
        partial void On_KhongTinhThue_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_KhongTinhThue_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
