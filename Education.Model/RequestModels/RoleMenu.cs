using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class RoleMenu : IEntity
    {
        public int RoleMenuId { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Role Role { get; set; }
    }
}
