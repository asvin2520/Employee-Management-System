using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Domain.Entity
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
