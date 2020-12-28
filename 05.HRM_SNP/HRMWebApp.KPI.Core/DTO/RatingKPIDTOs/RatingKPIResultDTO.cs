﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMWebApp.KPI.DB.Entities;

namespace HRMWebApp.KPI.Core.DTO.RatingKPIDTOs
{
    public class RatingKPIResultDTO
    {
        public RatingKPIResultDTO(){
            TargetGroupRatingDTOs=new List<TargetGroupRatingDTO>();
            BonusRecordList = new List<ResultDetailRatingDTO>();
        }
        public Guid Id { get; set; }
        public Guid RatingResultId { get; set; }
        public StaffDTO StaffDTO { get; set; }
        public StaffDTO StaffLeader { get; set; }
        public Guid StaffId { get; set; }
        public Guid PlanStaffId { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsLocked { get; set; }
        public bool IsUnlocked { get; set; }
        public bool IsCommitted { get; set; }
        public bool IsAdminRating { get; set; }
        public bool IsUnlockedForRating { get; set; }
        public double TotalSumRecord { get; set; }
        public double TotalRecord { get; set; }
        public double TotalRecordSecond { get; set; }
        public double MaxBonusRecord { get; set; }
        public int NumberOfEditing { get; set; }
        public StaffDTO Supervisor { get; set; }
        public List<TargetGroupRatingDTO> TargetGroupRatingDTOs { get; set; }
        public List<ResultDetailRatingDTO> ProfessorAdditionalResultDetailDTOs { get; set; }
        public List<ResultDetailRatingDTO> BonusRecordList { get; set; }

    }
}
