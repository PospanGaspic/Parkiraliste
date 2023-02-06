using System;

namespace ParkingApp
{
    public class Reservation
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long GarageId { get; set; }
        public long SpotId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Boolean? Paid { get; set; }
    }
}