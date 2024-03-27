using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BookDog.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa wynajmującego")]
        public string? Name { get; set; }
        public string? PhoneNumer { get; set; }
        public string? Mail { get; set; }
    }
}