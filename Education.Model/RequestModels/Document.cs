using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Document : IEntity
    {
        public Document()
        {
            UserDocument = new HashSet<UserDocument>();
        }

        public int DocumentId { get; set; }
        public int DocumentTypeId { get; set; }
        public int EducationId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileExtensionKey { get; set; }
        public string FileExtensionName { get; set; }
        public string TotalDuration { get; set; }
        public string Icon { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Education Education { get; set; }
        public virtual ICollection<UserDocument> UserDocument { get; set; }
    }
}
