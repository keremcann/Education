using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Plan : IEntity
    {
        public int PlanId { get; set; }
        public int EducationId { get; set; }
        public int TraninerId { get; set; }
        public int LocationId { get; set; }
        public string PlanName { get; set; }
        public string PlanDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Education Education { get; set; }
        public virtual Location Location { get; set; }
        public virtual Trainer Traniner { get; set; }
    }
}
