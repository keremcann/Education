using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Supplier : IEntity
    {
        public Supplier()
        {
            Trainer = new HashSet<Trainer>();
        }

        public int SupplierId { get; set; }
        public int? CompanyId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public int? CityId { get; set; }
        public int? TownId { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierTaxOffice { get; set; }
        public string SupplierTaxNo { get; set; }
        public string SupplierManagerName { get; set; }
        public string SupplierManagerEmail { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual City City { get; set; }
        public virtual Company Company { get; set; }
        public virtual Town Town { get; set; }
        public virtual ICollection<Trainer> Trainer { get; set; }
    }
}
