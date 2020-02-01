using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Trainer : IEntity
    {
        public Trainer()
        {
            Plan = new HashSet<Plan>();
        }

        public int TrainerId { get; set; }
        public int SupplierId { get; set; }
        public string TrainerFirstName { get; set; }
        public string TrainerLastName { get; set; }
        public string TrainerPhone { get; set; }
        public string TrainerEmail { get; set; }
        public string TrainerAddress { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Plan> Plan { get; set; }
    }
}
