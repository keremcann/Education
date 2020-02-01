using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Budget : IEntity
    {
        public Budget()
        {
            BudgetDocument = new HashSet<BudgetDocument>();
        }

        public int BudgetId { get; set; }
        public int ExpenseGroupId { get; set; }
        public int ExpenseItemId { get; set; }
        public string BudgetYear { get; set; }
        public string BudgetMonth { get; set; }
        public string BudgetCode { get; set; }
        public string Amount { get; set; }
        public string TotalAmount { get; set; }
        public string CurrencyType { get; set; }
        public string Description { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ExpenseGroup ExpenseGroup { get; set; }
        public virtual ExpenseItem ExpenseItem { get; set; }
        public virtual ICollection<BudgetDocument> BudgetDocument { get; set; }
    }
}
