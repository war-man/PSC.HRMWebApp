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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_WebChamCong_KiemTraPhongBanDaXet_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_WebChamCong_KiemTraPhongBanDaXet_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string TenBoPhan
        {
            get
            {
                return _tenBoPhan;
            }
            set
            {
    			string oldValue =  _tenBoPhan;
    			bool stopChanging = false;
                On_TenBoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TenBoPhan");
    			if(!stopChanging)
    			{
    				_tenBoPhan = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("TenBoPhan");
    				On_TenBoPhan_Changed(oldValue, _tenBoPhan);//\\
    			}
            }
        }
    	public static String TenBoPhan_PropertyName { get { return "TenBoPhan"; } }
        private string _tenBoPhan;
        partial void On_TenBoPhan_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_TenBoPhan_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string ThangNam
        {
            get
            {
                return _thangNam;
            }
            set
            {
    			string oldValue =  _thangNam;
    			bool stopChanging = false;
                On_ThangNam_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThangNam");
    			if(!stopChanging)
    			{
    				_thangNam = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("ThangNam");
    				On_ThangNam_Changed(oldValue, _thangNam);//\\
    			}
            }
        }
    	public static String ThangNam_PropertyName { get { return "ThangNam"; } }
        private string _thangNam;
        partial void On_ThangNam_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThangNam_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<bool> TrangThai
        {
            get
            {
                return _trangThai;
            }
            set
            {
    			Nullable<bool> oldValue =  _trangThai;
    			bool stopChanging = false;
                On_TrangThai_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TrangThai");
    			if(!stopChanging)
    			{
    				_trangThai = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TrangThai");
    				On_TrangThai_Changed(oldValue, _trangThai);//\\
    			}
            }
        }
    	public static String TrangThai_PropertyName { get { return "TrangThai"; } }
        private Nullable<bool> _trangThai;
        partial void On_TrangThai_Changing(Nullable<bool> currentValue, ref Nullable<bool> newValue, ref bool stopChanging);
        partial void On_TrangThai_Changed(Nullable<bool> oldValue, Nullable<bool> currentValue);

    #endregion

    }
}
