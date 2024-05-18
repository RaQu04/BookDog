using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BookDog.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa wynajmującego")]
        public string? Name { get; set; }
        [Display(Name = "Numer telefonu")]
        [RegularExpression(@"^\d{3} \d{3} \d{3}$", ErrorMessage = "Nieprawidłowy format numeru telefonu.")]
        public string? PhoneNumer { get; set; }
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu e-mail.")]
        [Display(Name = "Adres E-mail")]
        public string? Mail { get; set; }
    }
}