 using System;
 using System.Collections.Generic;
 using System.Linq;
using AssignSeat.Models;

 namespace AssignSeat.Strategies
 {
     public class DepartmentStrategy : ISeatAssignmentStrategy
     {
         public void AssignSeats(MeetingRoom room, List<Employee> employees)
         {
             if (room == null || employees == null || !employees.Any())
             {
                 Console.WriteLine("No room or employees to assign.");
                 return;
             }

             // Sort employees by department
             var sortedEmployees = employees.OrderBy(e => e.Department).ToList();

             // Check if the room has enough capacity
             if (sortedEmployees.Count > room.Capacity)
             {
                 Console.WriteLine("Not enough seats available in the meeting room.");
                 return;
             }

             // Assign seats
             Console.WriteLine($"Assigning seats in {room.RoomName} by department:");
             for (int i = 0; i < sortedEmployees.Count; i++)
             {
                 var employee = sortedEmployees[i];
                 var seat = room.Seats[i]; // Get the seat based on the index
                 Console.WriteLine($"{employee.Name} (Employee ID: {employee.EmployeeId}) is assigned to {seat.GetSeatNumber()}");
             }

             room.IsAvailable = false; // Mark the room as occupied
         }
     }
 }