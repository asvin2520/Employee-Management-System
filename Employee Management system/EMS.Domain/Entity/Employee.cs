using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Domain.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; }

        public Department Department { get; set; }
    }
}
