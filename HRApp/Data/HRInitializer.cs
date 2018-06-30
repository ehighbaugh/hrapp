using HRApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRApp.Data
{
    public class HRInitializer : DropCreateDatabaseIfModelChanges<HRContext>
    {
        protected override void Seed(HRContext context)
        {
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Sue", MiddleName = "Ellen", LastName = "Jones", DOB = DateTime.Parse("11/01/1954"), Position = "salesman", DepartmentId = 1},
                new Employee { FirstName = "Robert", MiddleName = "Alan", LastName = "Smith", DOB = DateTime.Parse("02/18/1965"), Position = "marketing", DepartmentId = 2},
                new Employee { FirstName = "Jessie", MiddleName = "Marie", LastName = "Wright", DOB = DateTime.Parse("07/07/1985"), Position = "secretary", DepartmentId = 3}
            };

            employees.ForEach(e => context.Employee.Add(e));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { DepartmentName = "IT"},
                new Department { DepartmentName = "Human Resources"},
                new Department { DepartmentName = "Sales"},
                new Department { DepartmentName = "Operations"}
            };

            departments.ForEach(d => context.Department.Add(d));
            context.SaveChanges();
        }
    }
}