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
    public partial class Mdl_WebUser_BoPhan
    {
    	[DataMember]
        public System.Guid IDWebUser { get; set; }
    	[DataMember]
        public System.Guid BoPhanID { get; set; }
    	[DataMember]
        public string DienGiai { get; set; }
    
    	//[DataMember]
        //public virtual Mdl_BoPhan BoPhan { get; set; }
    	//[DataMember]
        //public virtual Mdl_WebUser WebUser { get; set; }
    }
}
