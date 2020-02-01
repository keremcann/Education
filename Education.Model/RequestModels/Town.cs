using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Town : IEntity
    {
        public Town()
        {
            Branch = new HashSet<Branch>();
            Employee = new HashSet<Employee>();
            Supplier = new HashSet<Supplier>();
        }

        public int TownId { get; set; }
        public int CityId { get; set; }
        public string TownName { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
