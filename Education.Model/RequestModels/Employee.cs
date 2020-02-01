using Education.Model.Base;
using System;
using System.Collections.Generic;

namespace Education.Model.RequestModels
{
    public partial class Employee : IEntity
    {
        public Employee()
        {
            User = new HashSet<User>();
        }

        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeTitle { get; set; }
        public string CitizenshipNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhoto { get; set; }
        public int ManagerId { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        public virtual City City { get; set; }
        public virtual Department EmployeeNavigation { get; set; }
        public virtual Town Town { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
