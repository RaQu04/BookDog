﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BookDog.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Display(Name = "Data rozpoczęcia")]
        public DateTime Start { get; set; }
        [Display(Name = "Data zakończenia")]
        public DateTime End { get; set; }
        public virtual string Name { get { return Start.ToString() + " - " + End.ToString(); } }
        public int OfferId { get; set; }
        public Offer? Offer { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
