using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Location : IEntity
    {
        public Location()
        {
            Plan = new HashSet<Plan>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public string LocationAddress { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ManagerName { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Plan> Plan { get; set; }
    }
}
