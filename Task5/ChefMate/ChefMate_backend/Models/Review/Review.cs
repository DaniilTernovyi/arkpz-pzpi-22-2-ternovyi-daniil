﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ChefMate_backend.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public string Feedback { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
    }
}
