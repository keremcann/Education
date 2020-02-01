using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class DefinitionTypeDetail : IEntity
    {
        public DefinitionTypeDetail()
        {
            Education = new HashSet<Education>();
        }

        public int DefinitionTypeDetailId { get; set; }
        public int DefinitionTypeId { get; set; }
        public string DefinitionTypeDetailName { get; set; }
        public string DefinitionTypeDetailDescription { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual DefinitionType DefinitionType { get; set; }
        public virtual ICollection<Education> Education { get; set; }
    }
}
