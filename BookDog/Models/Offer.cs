using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BookDog.Models
{
    public class Offer
    {
        public int Id { get; set; }
        [Display(Name = "Tytuł oferty")]
        public string? Title { get; set; }
        [Display(Name = "Opis oferty")]
        public string? Description { get; set; }
        [Display(Name = "Cena za dobę")]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        public int OwnerId { get; set; }
        [Display(Name = "Wynajmujący")]
        public virtual Owner? Owner { get; set; }
        [Display(Name = "Dostępny")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Ocena")]
        public double? Rate { get; set; }
        [Display(Name = "Link")]
        public string? Link { get; set; }
    }
}
