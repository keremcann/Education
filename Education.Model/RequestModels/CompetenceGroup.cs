using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class CompetenceGroup : IEntity
    {
        public CompetenceGroup()
        {
            Competence = new HashSet<Competence>();
        }

        public int CompetenceGroupId { get; set; }
        public string CompetenceGroupName { get; set; }
        public string CompetenceGroupDescription { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Competence> Competence { get; set; }
    }
}
