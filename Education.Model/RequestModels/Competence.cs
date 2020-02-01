using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Competence : IEntity
    {
        public Competence()
        {
            EducationCompetence = new HashSet<EducationCompetence>();
        }

        public int CompetenceId { get; set; }
        public int CompetenceGroupId { get; set; }
        public string CompetenceName { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual CompetenceGroup CompetenceGroup { get; set; }
        public virtual ICollection<EducationCompetence> EducationCompetence { get; set; }
    }
}
