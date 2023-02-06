using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ParkingApp
{
    public class ReservationService
    {
        public Reservation CreateReservation(StreamWriter streamWriter, int userId, int garageId)
        {
            string filePath = ((FileStream)streamWriter.BaseStream).Name;
            var lineCount = File.ReadLines(filePath).Count() + 1;
            var reservation = new Reservation
            {
                Id = lineCount,
                UserId = userId,
                GarageId = garageId,
                SpotId = 1,
            };
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("Set start time of your reservation");
            Console.ResetColor();
            DateTime startTime = ConstructStartEndDateTime();
            
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("Set end time of your reservation");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("End time needs to be after " + startTime.ToString("dd/MM/yyyy HH:mm"));
            
            DateTime endTime = ConstructStartEndDateTime();;

            while (startTime >= endTime)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Start time should be before end time. Please set end time again.");
                Console.ResetColor(); 
                endTime = ConstructStartEndDateTime();
            }

            reservation.StartTime = startTime;
            reservation.EndTime = endTime;

            if (reservation.EndTime < reservation.StartTime)
            {
                
            }
            
            streamWriter.WriteLine(reservation.Id + "," + reservation.UserId + "," +  reservation.GarageId + "," + reservation.SpotId + "," + reservation.StartTime);
            streamWriter.Close();

            return reservation;
        }
        
        public void PrintCreatedReservation(Reservation reservation, User user)
        {
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("NEW RESERVATION CREATED ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("USER: " + user.FirstName + " " + user.LastName);
            Console.WriteLine("GARAGE ID: " + reservation.GarageId);
            Console.WriteLine("SPOT: " + reservation.SpotId);
            Console.WriteLine("PARKING START TIME: " + reservation.StartTime.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("PARKING END TIME: " + reservation.EndTime.ToString("dd/MM/yyyy HH:mm"));
        }

        private DateTime ConstructStartEndDateTime()
        {
            Console.WriteLine();
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month (January = 1, etc): ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            Helper helper = new Helper();
            helper.CreateCalendar(year, month);

            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the hour (1-12 AM/PM): ");
            int hour = Convert.ToInt32(Console.ReadLine());
            
            return new DateTime(year, month, day, hour, 0, 0);
        }
        
    }
}