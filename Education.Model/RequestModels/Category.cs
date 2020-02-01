using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Category : IEntity
    {
        public Category()
        {
            Education = new HashSet<Education>();
        }

        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Education> Education { get; set; }
    }
}
