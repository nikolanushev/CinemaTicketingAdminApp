using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketingAdminApp.Models
{
    public class MovieTicket
    {
        public Guid Id { get; set; }
        [ForeignKey("MovieId")]
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("TicketId")]
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public virtual ICollection<MovieTicketInOrder> Orders { get; set; }
    }
}
