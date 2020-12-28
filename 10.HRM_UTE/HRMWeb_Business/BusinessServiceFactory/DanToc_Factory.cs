﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP_Core;
using System.Reflection;
using System.ComponentModel;
using System.Data.Linq;
using System.Data;

using ERP_Business;
using HRMWeb_Business.Model;
using HRMWeb_Business.Model.Context;

namespace HRMWeb_Business.BusinessServiceFactory
{
    public class DanToc_Factory : BaseFactory<Entities, DanToc>
    {
        //static readonly Log4netCustom.ILog TracingLog_ = Log4netCustom.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static ERP_Core.BaseEntityObject CreateStandAloneObject()
        {
            return DanToc_Factory.New().CreateAloneObject();
        }
        public static DanToc_Factory New()
        {
            return new DanToc_Factory();
        }
        public DanToc_Factory()
            : base(Database.NewEntities())
        {

        }

        #region Custom
        public IQueryable<DanToc> GetAll_GCRecordIsNull()
        {
            var result = from o in this.ObjectSet
                         where o.GCRecord == null
                         orderby o.TenDanToc ascending
                         select o;
            return result;
        }
        public DanToc GetByID(Guid oid)
        {
            var result = (from o in this.ObjectSet
                          where o.Oid == oid
                          select o).SingleOrDefault();
            return result;
        }

        #endregion
    }//end class
}
