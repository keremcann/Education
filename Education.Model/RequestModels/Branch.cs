using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Branch : IEntity
    {
        public Branch()
        {
            Department = new HashSet<Department>();
        }

        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public int? CityId { get; set; }
        public int? TownId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentAddress { get; set; }
        public string DepartmentEmail { get; set; }
        public string DepartmentPhone { get; set; }
        public string DepartmentTaxNo { get; set; }
        public string DepartmentManagerName { get; set; }
        public string DepartmentManagerEmail { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual City City { get; set; }
        public virtual Company Company { get; set; }
        public virtual Town Town { get; set; }
        public virtual ICollection<Department> Department { get; set; }
    }
}
