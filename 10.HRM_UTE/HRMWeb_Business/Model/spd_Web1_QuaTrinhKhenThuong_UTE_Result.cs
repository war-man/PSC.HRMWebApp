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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_Web1_QuaTrinhKhenThuong_UTE_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_Web1_QuaTrinhKhenThuong_UTE_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> NgayKhenThuong
        {
            get
            {
                return _ngayKhenThuong;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _ngayKhenThuong;
    			bool stopChanging = false;
                On_NgayKhenThuong_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("NgayKhenThuong");
    			if(!stopChanging)
    			{
    				_ngayKhenThuong = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("NgayKhenThuong");
    				On_NgayKhenThuong_Changed(oldValue, _ngayKhenThuong);//\\
    			}
            }
        }
    	public static String NgayKhenThuong_PropertyName { get { return "NgayKhenThuong"; } }
        private Nullable<System.DateTime> _ngayKhenThuong;
        partial void On_NgayKhenThuong_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_NgayKhenThuong_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public string DanhHieu
        {
            get
            {
                return _danhHieu;
            }
            set
            {
    			string oldValue =  _danhHieu;
    			bool stopChanging = false;
                On_DanhHieu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("DanhHieu");
    			if(!stopChanging)
    			{
    				_danhHieu = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("DanhHieu");
    				On_DanhHieu_Changed(oldValue, _danhHieu);//\\
    			}
            }
        }
    	public static String DanhHieu_PropertyName { get { return "DanhHieu"; } }
        private string _danhHieu;
        partial void On_DanhHieu_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_DanhHieu_Changed(string oldValue, string currentValue);
    
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
        public string LyDo
        {
            get
            {
                return _lyDo;
            }
            set
            {
    			string oldValue =  _lyDo;
    			bool stopChanging = false;
                On_LyDo_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LyDo");
    			if(!stopChanging)
    			{
    				_lyDo = StructuralObject.SetValidValue(value, true);
    				ReportPropertyChanged("LyDo");
    				On_LyDo_Changed(oldValue, _lyDo);//\\
    			}
            }
        }
    	public static String LyDo_PropertyName { get { return "LyDo"; } }
        private string _lyDo;
        partial void On_LyDo_Changing(string currentValue, ref string newValue, ref bool stopChanging);
        partial void On_LyDo_Changed(string oldValue, string currentValue);

    #endregion

    }
}