 using System.Collections.Generic;

 namespace AssignSeat.Models
 {
     public class MeetingRoom
     {
         public string RoomName { get; set; }
         public int Capacity { get; set; }
         public bool IsAvailable { get; set; }
         public List<Seat> Seats { get; set; }

         public MeetingRoom(string roomName, int capacity, int rows, int columns)
         {
             RoomName = roomName;
             Capacity = capacity;
             IsAvailable = true; // Default to available
             Seats = new List<Seat>();

             // Initialize seats
             for (int row = 1; row <= rows; row++)
             {
                 for (int column = 1; column <= columns; column++)
                 {
                     Seats.Add(new Seat(row, column));
                 }
             }
         }
     }
 }