//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi SERVERERP\tai luc 05:27:30 ngay 19/04/2017
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_WebChamCong_ThongKeSoGioLamViecCanBo_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_WebChamCong_ThongKeSoGioLamViecCanBo_Result : ComplexObject
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
        public string HoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
    			string oldValue =  _hoTen;
    			bool stopChanging = false;
                On_HoTen_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("HoTen");
    			if(!stopChanging)
    			{
    				_hoTen = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("HoTen");
    				On_HoTen_Changed(oldValue, _hoTen);//\\
    			}
            }
        }
    	public static String HoTen_PropertyName { get { return "HoTen"; } }
        private string _hoTen;
        partial void On_HoTen_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_HoTen_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NgayQuet
        {
            get
            {
                return _ngayQuet;
            }
            set
            {
    			string oldValue =  _ngayQuet;
    			bool stopChanging = false;
                On_NgayQuet_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayQuet");
    			if(!stopChanging)
    			{
    				_ngayQuet = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NgayQuet");
    				On_NgayQuet_Changed(oldValue, _ngayQuet);//\\
    			}
            }
        }
    	public static String NgayQuet_PropertyName { get { return "NgayQuet"; } }
        private string _ngayQuet;
        partial void On_NgayQuet_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NgayQuet_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string GioVao
        {
            get
            {
                return _gioVao;
            }
            set
            {
    			string oldValue =  _gioVao;
    			bool stopChanging = false;
                On_GioVao_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GioVao");
    			if(!stopChanging)
    			{
    				_gioVao = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("GioVao");
    				On_GioVao_Changed(oldValue, _gioVao);//\\
    			}
            }
        }
    	public static String GioVao_PropertyName { get { return "GioVao"; } }
        private string _gioVao;
        partial void On_GioVao_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_GioVao_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string GioRa
        {
            get
            {
                return _gioRa;
            }
            set
            {
    			string oldValue =  _gioRa;
    			bool stopChanging = false;
                On_GioRa_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("GioRa");
    			if(!stopChanging)
    			{
    				_gioRa = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("GioRa");
    				On_GioRa_Changed(oldValue, _gioRa);//\\
    			}
            }
        }
    	public static String GioRa_PropertyName { get { return "GioRa"; } }
        private string _gioRa;
        partial void On_GioRa_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_GioRa_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoGio
        {
            get
            {
                return _soGio;
            }
            set
            {
    			string oldValue =  _soGio;
    			bool stopChanging = false;
                On_SoGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoGio");
    			if(!stopChanging)
    			{
    				_soGio = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoGio");
    				On_SoGio_Changed(oldValue, _soGio);//\\
    			}
            }
        }
    	public static String SoGio_PropertyName { get { return "SoGio"; } }
        private string _soGio;
        partial void On_SoGio_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoGio_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<long> STT
        {
            get
            {
                return _sTT;
            }
            set
            {
    			Nullable<long> oldValue =  _sTT;
    			bool stopChanging = false;
                On_STT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("STT");
    			if(!stopChanging)
    			{
    				_sTT = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("STT");
    				On_STT_Changed(oldValue, _sTT);//\\
    			}
            }
        }
    	public static String STT_PropertyName { get { return "STT"; } }
        private Nullable<long> _sTT;
        partial void On_STT_Changing(Nullable<long> currentValue, ref Nullable<long> newValue, ref bool stopChanging);
        partial void On_STT_Changed(Nullable<long> oldValue, Nullable<long> currentValue);

    #endregion

    }
}
