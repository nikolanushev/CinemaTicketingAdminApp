using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketingAdminApp.Models
{
    public class MovieTicketInOrder
    {
        public Guid MovieTicketId { get; set; }
        public MovieTicket SelectedMovieTicket { get; set; }
        public Guid OrderId { get; set; }
        public Order UserOrder { get; set; }
        public int Quantity { get; set; }
    }
}
