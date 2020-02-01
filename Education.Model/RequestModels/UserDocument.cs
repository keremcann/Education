using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class UserDocument : IEntity
    {
        public int UserDocumentId { get; set; }
        public int DocumentId { get; set; }
        public int UserId { get; set; }
        public string PauseDuration { get; set; }
        public bool? IsOpen { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Document Document { get; set; }
    }
}
