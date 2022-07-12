using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketingAdminApp.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public CinemaApplicationUser User { get; set; }
        public ICollection<MovieTicketInOrder> MovieTickets { get; set; }
    }
}
