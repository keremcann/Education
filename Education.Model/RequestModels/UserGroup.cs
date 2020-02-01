using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class UserGroup : IEntity
    {
        public UserGroup()
        {
            UserGroupRelationship = new HashSet<UserGroupRelationship>();
        }

        public int UserGroupId { get; set; }
        public string GroupName { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserGroupRelationship> UserGroupRelationship { get; set; }
    }
}
