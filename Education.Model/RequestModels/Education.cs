using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Education : IEntity
    {
        public Education()
        {
            Benefit = new HashSet<Benefit>();
            Comment = new HashSet<Comment>();
            Document = new HashSet<Document>();
            EducationCompetence = new HashSet<EducationCompetence>();
            Feature = new HashSet<Feature>();
            Plan = new HashSet<Plan>();
            UserEducation = new HashSet<UserEducation>();
        }

        public int EducationId { get; set; }
        public int? CategoryId { get; set; }
        public int CompanyId { get; set; }
        public string EducationName { get; set; }
        public string EducationDescription { get; set; }
        public string EducationCode { get; set; }
        public int? DefinitionTypeId { get; set; }
        public int? DefinitionTypeDetailId { get; set; }
        public string EducationRequirements { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual DefinitionType DefinitionType { get; set; }
        public virtual DefinitionTypeDetail DefinitionTypeDetail { get; set; }
        public virtual ICollection<Benefit> Benefit { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<EducationCompetence> EducationCompetence { get; set; }
        public virtual ICollection<Feature> Feature { get; set; }
        public virtual ICollection<Plan> Plan { get; set; }
        public virtual ICollection<UserEducation> UserEducation { get; set; }
    }
}
