using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class ExpenseItem : IEntity
    {
        public ExpenseItem()
        {
            Budget = new HashSet<Budget>();
        }

        public int ExpenseItemId { get; set; }
        public int ExpenseGroupId { get; set; }
        public string ExpenseItemName { get; set; }
        public string ExpenseItemDescription { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ExpenseGroup ExpenseGroup { get; set; }
        public virtual ICollection<Budget> Budget { get; set; }
    }
}
