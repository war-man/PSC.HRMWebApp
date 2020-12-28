﻿using HRMWebApp.KPI.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMWebApp.KPI.Core.DTO
{
    public class ProfessorCriterionDTO
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Tooltip { get; set; }
        public double Record { get; set; }
        public string ManageCode { get; set; }
        public TargetGroupDetail TargetGroupDetail { get; set; }
        public Guid TargetGroupDetailId { get; set; }
        public int OrderNumber { get; set; }
        public int NumberOfHour { get; set; }
        public int CriterionTypeId { get; set; }
        public CriterionType CriterionType { get; set; }

    }
}
