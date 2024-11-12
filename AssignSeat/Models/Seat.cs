 namespace AssignSeat.Models
 {
     public class Seat
     {
         public int Row { get; set; }
         public int Column { get; set; }

         public Seat(int row, int column)
         {
             Row = row;
             Column = column;
         }

         public string GetSeatNumber()
         {
             return $"Row {Row}, Column {Column}";
         }
     }
 }