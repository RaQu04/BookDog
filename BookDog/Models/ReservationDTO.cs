using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BookDog.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public virtual string Name { get { return Start.ToString() + " - " + End.ToString(); } }
        public int OfferId { get; set; }
        public Offer? Offer { get; set; }
    }
}
