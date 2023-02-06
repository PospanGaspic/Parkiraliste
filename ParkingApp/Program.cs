using System;
using System.Globalization;

namespace ParkingApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            UserInterfaceService userInterfaceService = new UserInterfaceService();
            userInterfaceService.OpenStartMenu();
            userInterfaceService.OpenExitMenu();
        }
        
/*    public class Vehicle
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Licence { get; set; }
    }

    public class Spot
    {
        public long Id { get; set; }
        public string GarageId { get; set; }
        public SpotStatus Status { get; set; }
    }
    
    public class FinanceReport
    {
        public long Id { get; set; }
        public string Month { get; set; }
        public string NrOfVehicles{ get; set; }
        public int TotalPayedMount { get; set; }
    }

    public enum SpotStatus
    {
        Free,
        Occupied
    }
    */

    }
}