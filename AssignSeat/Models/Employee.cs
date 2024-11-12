 namespace AssignSeat.Models
 {
     public class Employee
     {
         public string Name { get; set; }
         public int EmployeeId { get; set; }
         public string Department { get; set; }
         public string JobTitle { get; set; }

         public Employee(string name, int employeeId, string department, string jobTitle)
         {
             Name = name;
             EmployeeId = employeeId;
             Department = department;
             JobTitle = jobTitle;
         }
     }
 }