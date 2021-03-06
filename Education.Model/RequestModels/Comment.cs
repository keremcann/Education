﻿using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Comment : IEntity
    {
        public int CommentId { get; set; }
        public int EducationId { get; set; }
        public int UserId { get; set; }
        public string CommentLine { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Education Education { get; set; }
        public virtual User User { get; set; }
    }
}
