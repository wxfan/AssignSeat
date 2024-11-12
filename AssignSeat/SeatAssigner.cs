 using System;
 using System.Collections.Generic;
 using AssignSeat.Models;
 using AssignSeat.Strategies;

 namespace AssignSeat
 {
     public class SeatAssigner
     {
         private ISeatAssignmentStrategy _strategy;

         public SeatAssigner(ISeatAssignmentStrategy strategy)
         {
             _strategy = strategy;
         }

         public void AssignSeats(MeetingRoom room, List<Employee> employees)
         {
             _strategy.AssignSeats(room, employees);
         }
     }
 }