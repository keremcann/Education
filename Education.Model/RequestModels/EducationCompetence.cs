﻿using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class EducationCompetence : IEntity
    {
        public int EducationCompetenceId { get; set; }
        public int EducationId { get; set; }
        public int CompetenceId { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Competence Competence { get; set; }
        public virtual Education Education { get; set; }
    }
}
