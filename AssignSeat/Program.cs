using System;
 using System.Collections.Generic;
 using AssignSeat.Models;
 using AssignSeat.Strategies;

 namespace AssignSeat
 {
     class Program
     {
         static void Main(string[] args)
         {
             // Create a meeting room with 3 rows and 5 columns
             MeetingRoom room = new MeetingRoom("Conference Room A", 15, 3, 5);

             // Create a list of departments (this can be modified to take user input)
             List<Department> departments = new List<Department>
             {
                 new Department("HR", 1),
                 new Department("IT", 2),
                 new Department("Finance", 3),
                 new Department("Marketing", 4),
                 new Department("Sales", 5)
             };

             // Add employees to departments
             departments[0].AddEmployee(new Employee("Alice", 1, "HR", "Manager"));
             departments[1].AddEmployee(new Employee("Bob", 2, "IT", "Developer"));
             departments[2].AddEmployee(new Employee("Charlie", 3, "Finance", "Analyst"));
             departments[3].AddEmployee(new Employee("David", 4, "Marketing", "Coordinator"));
             departments[4].AddEmployee(new Employee("Eve", 5, "Sales", "Representative"));

             // Create a seat assigner with the name order strategy
             SeatAssigner seatAssignerNameOrder = new SeatAssigner(new NameOrderStrategy());
             seatAssignerNameOrder.AssignSeats(room, departments[0].Employees);

             // Create a seat assigner with the department order strategy
             SeatAssigner seatAssignerDepartmentOrder = new SeatAssigner(new DepartmentOrderStrategy());
             seatAssignerDepartmentOrder.AssignSeats(room, departments[1].Employees);

             // Create a seat assigner with the department strategy
             SeatAssigner seatAssignerDepartment = new SeatAssigner(new DepartmentStrategy());
             seatAssignerDepartment.AssignSeats(room, departments[2].Employees);
         }
     }
 }