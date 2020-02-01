using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class DefinitionType : IEntity
    {
        public DefinitionType()
        {
            DefinitionTypeDetail = new HashSet<DefinitionTypeDetail>();
            Education = new HashSet<Education>();
        }

        public int DefinitionTypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DefinitionTypeDetail> DefinitionTypeDetail { get; set; }
        public virtual ICollection<Education> Education { get; set; }
    }
}
