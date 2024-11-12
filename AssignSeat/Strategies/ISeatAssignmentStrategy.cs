 using AssignSeat.Models;
 
 namespace AssignSeat.Strategies
 {
     public interface ISeatAssignmentStrategy
     {
         void AssignSeats(MeetingRoom room, List<Employee> employees);
     }
 }