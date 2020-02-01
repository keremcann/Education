using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class ExpenseGroup : IEntity
    {
        public ExpenseGroup()
        {
            Budget = new HashSet<Budget>();
            ExpenseItem = new HashSet<ExpenseItem>();
        }

        public int ExpenseGroupId { get; set; }
        public string ExpenseGroupName { get; set; }
        public string ExpenseGroupDescription { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Budget> Budget { get; set; }
        public virtual ICollection<ExpenseItem> ExpenseItem { get; set; }
    }
}
