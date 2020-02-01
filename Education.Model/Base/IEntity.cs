using System;
using System.Collections.Generic;
using System.Text;

namespace Education.Model.Base
{
    public interface IEntity
    {
        int CreateUser { get; set; }
        DateTime CreateDate { get; set; }
        int? UpdateUser { get; set; }
        DateTime? UpdateDate { get; set; }
        int? DeleteUser { get; set; }
        DateTime? DeleteDate { get; set; }
        bool IsActive { get; set; }
    }
}
