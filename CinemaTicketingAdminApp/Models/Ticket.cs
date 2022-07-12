using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketingAdminApp.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string TicketNumber { get; set; }
        public int SeatNumber { get; set; }
        public string Row { get; set; }
        public string Hall { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
