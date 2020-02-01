using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class User : IEntity
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            UserEducation = new HashSet<UserEducation>();
            UserGroupRelationship = new HashSet<UserGroupRelationship>();
        }

        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<UserEducation> UserEducation { get; set; }
        public virtual ICollection<UserGroupRelationship> UserGroupRelationship { get; set; }
    }
}
