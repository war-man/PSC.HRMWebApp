//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMWeb_Business.Model.MapObjectCreator
{
    using System;
    using System.Collections.Generic;
    
    using System.Runtime.Serialization;//[DataContract],[DataMember]
    [DataContract]
    public partial class Mdl_CC_MailManager
    {
    	[DataMember]
        public System.Guid Oid { get; set; }
    	[DataMember]
        public string Title { get; set; }
    	[DataMember]
        public string Contents { get; set; }
    	[DataMember]
        public string ReceiverEmail { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> SendDate { get; set; }
    	[DataMember]
        public string FileName { get; set; }
    	[DataMember]
        public string SendEmail { get; set; }
    	[DataMember]
        public string SendPass { get; set; }
    	[DataMember]
        public Nullable<System.Guid> IDWebUser { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_WebUser WebUser { get; set; }
    }
}
