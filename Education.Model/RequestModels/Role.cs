using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Role : IEntity
    {
        public Role()
        {
            RoleMenu = new HashSet<RoleMenu>();
            User = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public string RoleName { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RoleMenu> RoleMenu { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
