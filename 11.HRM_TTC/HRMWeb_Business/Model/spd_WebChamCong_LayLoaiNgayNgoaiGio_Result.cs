//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 09:24:55 ngay 29/02/2020
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_WebChamCong_LayLoaiNgayNgoaiGio_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_WebChamCong_LayLoaiNgayNgoaiGio_Result : ComplexObject
    {
    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> LoaiNgayNgoaiGio
        {
            get
            {
                return _loaiNgayNgoaiGio;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _loaiNgayNgoaiGio;
    			bool stopChanging = false;
                On_LoaiNgayNgoaiGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LoaiNgayNgoaiGio");
    			if(!stopChanging)
    			{
    				_loaiNgayNgoaiGio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LoaiNgayNgoaiGio");
    				On_LoaiNgayNgoaiGio_Changed(oldValue, _loaiNgayNgoaiGio);//\\
    			}
            }
        }
    	public static String LoaiNgayNgoaiGio_PropertyName { get { return "LoaiNgayNgoaiGio"; } }
        private Nullable<System.Guid> _loaiNgayNgoaiGio;
        partial void On_LoaiNgayNgoaiGio_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_LoaiNgayNgoaiGio_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<decimal> SoGioNghiTruaNgoaiGio
        {
            get
            {
                return _soGioNghiTruaNgoaiGio;
            }
            set
            {
    			Nullable<decimal> oldValue =  _soGioNghiTruaNgoaiGio;
    			bool stopChanging = false;
                On_SoGioNghiTruaNgoaiGio_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoGioNghiTruaNgoaiGio");
    			if(!stopChanging)
    			{
    				_soGioNghiTruaNgoaiGio = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoGioNghiTruaNgoaiGio");
    				On_SoGioNghiTruaNgoaiGio_Changed(oldValue, _soGioNghiTruaNgoaiGio);//\\
    			}
            }
        }
    	public static String SoGioNghiTruaNgoaiGio_PropertyName { get { return "SoGioNghiTruaNgoaiGio"; } }
        private Nullable<decimal> _soGioNghiTruaNgoaiGio;
        partial void On_SoGioNghiTruaNgoaiGio_Changing(Nullable<decimal> currentValue, ref Nullable<decimal> newValue, ref bool stopChanging);
        partial void On_SoGioNghiTruaNgoaiGio_Changed(Nullable<decimal> oldValue, Nullable<decimal> currentValue);

    #endregion

    }
}
