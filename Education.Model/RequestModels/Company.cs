using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Company : IEntity
    {
        public Company()
        {
            Branch = new HashSet<Branch>();
            Category = new HashSet<Category>();
            Education = new HashSet<Education>();
            Supplier = new HashSet<Supplier>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? CityId { get; set; }
        public int? TownId { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyTaxOffice { get; set; }
        public string CompanyTaxNo { get; set; }
        public string CompanyManagerName { get; set; }
        public string CompanyManagerEmail { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Education> Education { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
