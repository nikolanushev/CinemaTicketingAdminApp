using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketingAdminApp.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string MovieImage { get; set; }
        public string MovieDesrciption { get; set; }
        public decimal MoviePrice { get; set; }

        public int Rating { get; set; }

        public List<MovieTicket> MovieTickets { get; set; }
    }
}
