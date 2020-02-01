using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Menu : IEntity
    {
        public Menu()
        {
            RoleMenu = new HashSet<RoleMenu>();
        }

        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int ParentId { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RoleMenu> RoleMenu { get; set; }
    }
}
