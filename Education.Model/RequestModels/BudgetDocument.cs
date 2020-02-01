using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class BudgetDocument : IEntity
    {
        public int BudgetDocumentId { get; set; }
        public int BudgetId { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string FilePath { get; set; }
        public string FileExtensionKey { get; set; }
        public string FileExtensionName { get; set; }
        public string Icon { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Budget Budget { get; set; }
    }
}
