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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhThamGiaLucLuongVuTrang_LUH_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhThamGiaLucLuongVuTrang_LUH_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgayNhapNgu
        {
            get
            {
                return _ngayNhapNgu;
            }
            set
            {
    			string oldValue =  _ngayNhapNgu;
    			bool stopChanging = false;
                On_NgayNhapNgu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayNhapNgu");
    			if(!stopChanging)
    			{
    				_ngayNhapNgu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayNhapNgu");
    				On_NgayNhapNgu_Changed(oldValue, _ngayNhapNgu);//\\
    			}
            }
        }
    	public static String NgayNhapNgu_PropertyName { get { return "NgayNhapNgu"; } }
        private string _ngayNhapNgu;
        partial void On_NgayNhapNgu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayNhapNgu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgayXuatNgu
        {
            get
            {
                return _ngayXuatNgu;
            }
            set
            {
    			string oldValue =  _ngayXuatNgu;
    			bool stopChanging = false;
                On_NgayXuatNgu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayXuatNgu");
    			if(!stopChanging)
    			{
    				_ngayXuatNgu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayXuatNgu");
    				On_NgayXuatNgu_Changed(oldValue, _ngayXuatNgu);//\\
    			}
            }
        }
    	public static String NgayXuatNgu_PropertyName { get { return "NgayXuatNgu"; } }
        private string _ngayXuatNgu;
        partial void On_NgayXuatNgu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayXuatNgu_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuanHam
        {
            get
            {
                return _quanHam;
            }
            set
            {
    			string oldValue =  _quanHam;
    			bool stopChanging = false;
                On_QuanHam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuanHam");
    			if(!stopChanging)
    			{
    				_quanHam = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuanHam");
    				On_QuanHam_Changed(oldValue, _quanHam);//\\
    			}
            }
        }
    	public static String QuanHam_PropertyName { get { return "QuanHam"; } }
        private string _quanHam;
        partial void On_QuanHam_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuanHam_Changed(string oldValue, string currentValue);
    
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

    #endregion

    }
}
