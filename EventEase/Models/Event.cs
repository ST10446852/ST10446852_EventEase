﻿using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        [Key]

        public int EventId { get; set; }
        public string? EventName { get; set; }
        public DateTime? EventDate { get; set; }
        public string? Description { get; set; }

        public List<Booking>? Bookings { get; set; }
    }
}
