﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMWebApp.KPI.DB.Entities
{
    public class StaffSalaryInfo
    {
        public virtual Guid Id { get; set; }
        public virtual ScaleSalary ScaleSalary { get; set; }
    }
}
