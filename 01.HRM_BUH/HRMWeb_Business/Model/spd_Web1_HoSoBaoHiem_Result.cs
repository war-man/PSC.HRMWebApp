//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-O8ODB0C\thevi luc 09:44:28 ngay 17/09/2019
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_HoSoBaoHiem_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_HoSoBaoHiem_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_Web1_HoSoBaoHiem_Result object.
        /// </summary>
        /// <param name="thamGiaBHTN">Initial value of the ThamGiaBHTN property.</param>
        public static spd_Web1_HoSoBaoHiem_Result Createspd_Web1_HoSoBaoHiem_Result(string thamGiaBHTN)
        {
            spd_Web1_HoSoBaoHiem_Result spd_Web1_HoSoBaoHiem_Result = new spd_Web1_HoSoBaoHiem_Result();
            spd_Web1_HoSoBaoHiem_Result.ThamGiaBHTN = thamGiaBHTN;
            return spd_Web1_HoSoBaoHiem_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoSoBHXH
        {
            get
            {
                return _soSoBHXH;
            }
            set
            {
    			string oldValue =  _soSoBHXH;
    			bool stopChanging = false;
                On_SoSoBHXH_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoSoBHXH");
    			if(!stopChanging)
    			{
    				_soSoBHXH = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoSoBHXH");
    				On_SoSoBHXH_Changed(oldValue, _soSoBHXH);//\\
    			}
            }
        }
    	public static String SoSoBHXH_PropertyName { get { return "SoSoBHXH"; } }
        private string _soSoBHXH;
        partial void On_SoSoBHXH_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoSoBHXH_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayThamGiaBHXH
        {
            get
            {
                return _ngayThamGiaBHXH;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayThamGiaBHXH;
    			bool stopChanging = false;
                On_NgayThamGiaBHXH_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayThamGiaBHXH");
    			if(!stopChanging)
    			{
    				_ngayThamGiaBHXH = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayThamGiaBHXH");
    				On_NgayThamGiaBHXH_Changed(oldValue, _ngayThamGiaBHXH);//\\
    			}
            }
        }
    	public static String NgayThamGiaBHXH_PropertyName { get { return "NgayThamGiaBHXH"; } }
        private Nullable<System.DateTime> _ngayThamGiaBHXH;
        partial void On_NgayThamGiaBHXH_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayThamGiaBHXH_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string SoTheBHYT
        {
            get
            {
                return _soTheBHYT;
            }
            set
            {
    			string oldValue =  _soTheBHYT;
    			bool stopChanging = false;
                On_SoTheBHYT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoTheBHYT");
    			if(!stopChanging)
    			{
    				_soTheBHYT = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("SoTheBHYT");
    				On_SoTheBHYT_Changed(oldValue, _soTheBHYT);//\\
    			}
            }
        }
    	public static String SoTheBHYT_PropertyName { get { return "SoTheBHYT"; } }
        private string _soTheBHYT;
        partial void On_SoTheBHYT_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_SoTheBHYT_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> TuNgay
        {
            get
            {
                return _tuNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _tuNgay;
    			bool stopChanging = false;
                On_TuNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TuNgay");
    			if(!stopChanging)
    			{
    				_tuNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TuNgay");
    				On_TuNgay_Changed(oldValue, _tuNgay);//\\
    			}
            }
        }
    	public static String TuNgay_PropertyName { get { return "TuNgay"; } }
        private Nullable<System.DateTime> _tuNgay;
        partial void On_TuNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_TuNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> DenNgay
        {
            get
            {
                return _denNgay;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _denNgay;
    			bool stopChanging = false;
                On_DenNgay_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DenNgay");
    			if(!stopChanging)
    			{
    				_denNgay = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("DenNgay");
    				On_DenNgay_Changed(oldValue, _denNgay);//\\
    			}
            }
        }
    	public static String DenNgay_PropertyName { get { return "DenNgay"; } }
        private Nullable<System.DateTime> _denNgay;
        partial void On_DenNgay_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_DenNgay_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string NoiDangKyKCB
        {
            get
            {
                return _noiDangKyKCB;
            }
            set
            {
    			string oldValue =  _noiDangKyKCB;
    			bool stopChanging = false;
                On_NoiDangKyKCB_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NoiDangKyKCB");
    			if(!stopChanging)
    			{
    				_noiDangKyKCB = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("NoiDangKyKCB");
    				On_NoiDangKyKCB_Changed(oldValue, _noiDangKyKCB);//\\
    			}
            }
        }
    	public static String NoiDangKyKCB_PropertyName { get { return "NoiDangKyKCB"; } }
        private string _noiDangKyKCB;
        partial void On_NoiDangKyKCB_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_NoiDangKyKCB_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string QuyenLoiHuongBHYT
        {
            get
            {
                return _quyenLoiHuongBHYT;
            }
            set
            {
    			string oldValue =  _quyenLoiHuongBHYT;
    			bool stopChanging = false;
                On_QuyenLoiHuongBHYT_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("QuyenLoiHuongBHYT");
    			if(!stopChanging)
    			{
    				_quyenLoiHuongBHYT = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("QuyenLoiHuongBHYT");
    				On_QuyenLoiHuongBHYT_Changed(oldValue, _quyenLoiHuongBHYT);//\\
    			}
            }
        }
    	public static String QuyenLoiHuongBHYT_PropertyName { get { return "QuyenLoiHuongBHYT"; } }
        private string _quyenLoiHuongBHYT;
        partial void On_QuyenLoiHuongBHYT_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_QuyenLoiHuongBHYT_Changed(string oldValue, string currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public string ThamGiaBHTN
        {
            get
            {
                return _thamGiaBHTN;
            }
            set
            {
    			string oldValue =  _thamGiaBHTN;
    			bool stopChanging = false;
                On_ThamGiaBHTN_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("ThamGiaBHTN");
    			if(!stopChanging)
    			{
    				_thamGiaBHTN = StructuralObject.SetValidValue(value, false);
    				ReportPropertyChanged("ThamGiaBHTN");
    				On_ThamGiaBHTN_Changed(oldValue, _thamGiaBHTN);//\\
    			}
            }
        }
    	public static String ThamGiaBHTN_PropertyName { get { return "ThamGiaBHTN"; } }
        private string _thamGiaBHTN;
        partial void On_ThamGiaBHTN_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_ThamGiaBHTN_Changed(string oldValue, string currentValue);

    #endregion

    }
}
