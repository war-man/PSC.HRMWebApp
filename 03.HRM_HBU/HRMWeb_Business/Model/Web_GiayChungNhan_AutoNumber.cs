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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="Web_GiayChungNhan_AutoNumber")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Web_GiayChungNhan_AutoNumber : ERP_Core.BaseEntityObject//EntityObject
    {
    	static Web_GiayChungNhan_AutoNumber()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public Web_GiayChungNhan_AutoNumber()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new Web_GiayChungNhan_AutoNumber object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="soThuTuPhieu">Initial value of the SoThuTuPhieu property.</param>
        public static Web_GiayChungNhan_AutoNumber CreateWeb_GiayChungNhan_AutoNumber(System.Guid id, long soThuTuPhieu)
        {
            Web_GiayChungNhan_AutoNumber web_GiayChungNhan_AutoNumber = new Web_GiayChungNhan_AutoNumber();
            web_GiayChungNhan_AutoNumber.Id = id;
            web_GiayChungNhan_AutoNumber.SoThuTuPhieu = soThuTuPhieu;
            return web_GiayChungNhan_AutoNumber;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
        			System.Guid oldValue =  _id;
        			bool stopChanging = false;
                    On_Id_Changing(oldValue, ref value, ref stopChanging);
                    ReportPropertyChanging("Id");
        			if(!stopChanging)
        			{
        				_id = StructuralObject.SetValidValue(value);
        				ReportPropertyChanged("Id");
        				On_Id_Changed(oldValue, _id);//\\
        			}
                }
            }
        }
    	public static String Id_PropertyName { get { return "Id"; } }
        private System.Guid _id;
        partial void On_Id_Changing(System.Guid currentValue, ref System.Guid newValue, ref bool stopChanging);
        partial void On_Id_Changed(System.Guid oldValue, System.Guid currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public long SoThuTuPhieu
        {
            get
            {
                return _soThuTuPhieu;
            }
            set
            {
    			long oldValue =  _soThuTuPhieu;
    			bool stopChanging = false;
                On_SoThuTuPhieu_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("SoThuTuPhieu");
    			if(!stopChanging)
    			{
    				_soThuTuPhieu = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("SoThuTuPhieu");
    				On_SoThuTuPhieu_Changed(oldValue, _soThuTuPhieu);//\\
    			}
            }
        }
    	public static String SoThuTuPhieu_PropertyName { get { return "SoThuTuPhieu"; } }
        private long _soThuTuPhieu;
        partial void On_SoThuTuPhieu_Changing(long currentValue, ref long newValue, ref bool stopChanging);
        partial void On_SoThuTuPhieu_Changed(long oldValue, long currentValue);

        #endregion

    }
}
