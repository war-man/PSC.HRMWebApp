//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 12:14:05 ngay 06/04/2019
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
    [EdmComplexTypeAttribute(NamespaceName="ERPModel", Name="spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result object.
        /// </summary>
        /// <param name="iDNhanVien">Initial value of the IDNhanVien property.</param>
        /// <param name="iDBoPhan">Initial value of the IDBoPhan property.</param>
        public static spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result Createspd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result(System.Guid iDNhanVien, System.Guid iDBoPhan)
        {
            spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result = new spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result();
            spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result.IDNhanVien = iDNhanVien;
            spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result.IDBoPhan = iDBoPhan;
            return spd_WebChamCong_DanhSachCanBoChotChamCongCuoiThang_Result;
        }

        #endregion

    #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid IDNhanVien
        {
            get
            {
                return _iDNhanVien;
            }
            set
            {
    			System.Guid oldValue =  _iDNhanVien;
    			bool stopChanging = false;
                On_IDNhanVien_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("IDNhanVien");
    			if(!stopChanging)
    			{
    				_iDNhanVien = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("IDNhanVien");
    				On_IDNhanVien_Changed(oldValue, _iDNhanVien);//\\
    			}
            }
        }
    	public static String IDNhanVien_PropertyName { get { return "IDNhanVien"; } }
        private System.Guid _iDNhanVien;
        partial void On_IDNhanVien_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_IDNhanVien_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid IDBoPhan
        {
            get
            {
                return _iDBoPhan;
            }
            set
            {
    			System.Guid oldValue =  _iDBoPhan;
    			bool stopChanging = false;
                On_IDBoPhan_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("IDBoPhan");
    			if(!stopChanging)
    			{
    				_iDBoPhan = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("IDBoPhan");
    				On_IDBoPhan_Changed(oldValue, _iDBoPhan);//\\
    			}
            }
        }
    	public static String IDBoPhan_PropertyName { get { return "IDBoPhan"; } }
        private System.Guid _iDBoPhan;
        partial void On_IDBoPhan_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_IDBoPhan_Changed(System.Guid oldValue, System.Guid currentValue);

    #endregion

    }
}
