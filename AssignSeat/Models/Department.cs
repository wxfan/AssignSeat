 using System.Collections.Generic;

 namespace AssignSeat.Models
 {
     public class Department
     {
         public string DepartmentName { get; set; }
         public int OrderNumber { get; set; }
         public List<Employee> Employees { get; set; }

         public Department(string departmentName, int orderNumber)
         {
             DepartmentName = departmentName;
             OrderNumber = orderNumber;
             Employees = new List<Employee>();
         }

         public void AddEmployee(Employee employee)
         {
             Employees.Add(employee);
         }
     }
 }