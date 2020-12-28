﻿using System;
using System.Collections.Generic;

namespace HRMWebApp.KPI.DB.Entities
{
    public class Department
    {
        public Department()
        {
            Staffs = new List<Staff>();
        }
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Staff> Staffs { get; set; }
        public virtual Department ParentDepartment { get; set; }
        public virtual int DepartmentType { get; set; }
        public virtual int? GCRecord { get; set; }
        public virtual bool IsDisabled { get; set; }
    }
}
