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
    [EdmEntityTypeAttribute(NamespaceName="ERPModel", Name="CC_AttLog")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CC_AttLog : ERP_Core.BaseEntityObject//EntityObject
    {
    	static CC_AttLog()
    	{
    
    		AfterStaticConstruction();
        }
        static partial void AfterStaticConstruction();
    
    	public CC_AttLog()
    	{
    
    		this.AfterConstruction();
        }
        partial void AfterConstruction();
    
        #region Factory Method
    
        /// <summary>
        /// Create a new CC_AttLog object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static CC_AttLog CreateCC_AttLog(long id)
        {
            CC_AttLog cC_AttLog = new CC_AttLog();
            cC_AttLog.Id = id;
            return cC_AttLog;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
        			long oldValue =  _id;
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
        private long _id;
        partial void On_Id_Changing(long currentValue, ref long newValue, ref bool stopChanging);
        partial void On_Id_Changed(long oldValue, long currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<long> EnrollNumber
        {
            get
            {
                return _enrollNumber;
            }
            set
            {
    			Nullable<long> oldValue =  _enrollNumber;
    			bool stopChanging = false;
                On_EnrollNumber_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("EnrollNumber");
    			if(!stopChanging)
    			{
    				_enrollNumber = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("EnrollNumber");
    				On_EnrollNumber_Changed(oldValue, _enrollNumber);//\\
    			}
            }
        }
    	public static String EnrollNumber_PropertyName { get { return "EnrollNumber"; } }
        private Nullable<long> _enrollNumber;
        partial void On_EnrollNumber_Changing(Nullable<long> currentValue, ref Nullable<long> newValue, ref bool stopChanging);
        partial void On_EnrollNumber_Changed(Nullable<long> oldValue, Nullable<long> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> VerifyMode
        {
            get
            {
                return _verifyMode;
            }
            set
            {
    			Nullable<int> oldValue =  _verifyMode;
    			bool stopChanging = false;
                On_VerifyMode_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("VerifyMode");
    			if(!stopChanging)
    			{
    				_verifyMode = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("VerifyMode");
    				On_VerifyMode_Changed(oldValue, _verifyMode);//\\
    			}
            }
        }
    	public static String VerifyMode_PropertyName { get { return "VerifyMode"; } }
        private Nullable<int> _verifyMode;
        partial void On_VerifyMode_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_VerifyMode_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> InOutMode
        {
            get
            {
                return _inOutMode;
            }
            set
            {
    			Nullable<int> oldValue =  _inOutMode;
    			bool stopChanging = false;
                On_InOutMode_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("InOutMode");
    			if(!stopChanging)
    			{
    				_inOutMode = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("InOutMode");
    				On_InOutMode_Changed(oldValue, _inOutMode);//\\
    			}
            }
        }
    	public static String InOutMode_PropertyName { get { return "InOutMode"; } }
        private Nullable<int> _inOutMode;
        partial void On_InOutMode_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_InOutMode_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.DateTime> LogDateTime
        {
            get
            {
                return _logDateTime;
            }
            set
            {
    			Nullable<System.DateTime> oldValue =  _logDateTime;
    			bool stopChanging = false;
                On_LogDateTime_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("LogDateTime");
    			if(!stopChanging)
    			{
    				_logDateTime = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("LogDateTime");
    				On_LogDateTime_Changed(oldValue, _logDateTime);//\\
    			}
            }
        }
    	public static String LogDateTime_PropertyName { get { return "LogDateTime"; } }
        private Nullable<System.DateTime> _logDateTime;
        partial void On_LogDateTime_Changing(Nullable<System.DateTime> currentValue, ref Nullable<System.DateTime> newValue, ref bool stopChanging);
        partial void On_LogDateTime_Changed(Nullable<System.DateTime> oldValue, Nullable<System.DateTime> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<int> WorkCode
        {
            get
            {
                return _workCode;
            }
            set
            {
    			Nullable<int> oldValue =  _workCode;
    			bool stopChanging = false;
                On_WorkCode_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("WorkCode");
    			if(!stopChanging)
    			{
    				_workCode = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("WorkCode");
    				On_WorkCode_Changed(oldValue, _workCode);//\\
    			}
            }
        }
    	public static String WorkCode_PropertyName { get { return "WorkCode"; } }
        private Nullable<int> _workCode;
        partial void On_WorkCode_Changing(Nullable<int> currentValue, ref Nullable<int> newValue, ref bool stopChanging);
        partial void On_WorkCode_Changed(Nullable<int> oldValue, Nullable<int> currentValue);
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<System.Guid> TimeAttendanceDeviceId
        {
            get
            {
                return _timeAttendanceDeviceId;
            }
            set
            {
    			Nullable<System.Guid> oldValue =  _timeAttendanceDeviceId;
    			bool stopChanging = false;
                On_TimeAttendanceDeviceId_Changing(oldValue, ref value, ref stopChanging);
                ReportPropertyChanging("TimeAttendanceDeviceId");
    			if(!stopChanging)
    			{
    				_timeAttendanceDeviceId = StructuralObject.SetValidValue(value);
    				ReportPropertyChanged("TimeAttendanceDeviceId");
    				On_TimeAttendanceDeviceId_Changed(oldValue, _timeAttendanceDeviceId);//\\
    			}
            }
        }
    	public static String TimeAttendanceDeviceId_PropertyName { get { return "TimeAttendanceDeviceId"; } }
        private Nullable<System.Guid> _timeAttendanceDeviceId;
        partial void On_TimeAttendanceDeviceId_Changing(Nullable<System.Guid> currentValue, ref Nullable<System.Guid> newValue, ref bool stopChanging);
        partial void On_TimeAttendanceDeviceId_Changed(Nullable<System.Guid> oldValue, Nullable<System.Guid> currentValue);

        #endregion

    }
}
