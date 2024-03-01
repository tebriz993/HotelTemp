using System.ComponentModel.DataAnnotations;

namespace HotelTemp.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }

        public string Image { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "80 simvoldan cox ola bilmez")]
        public string FullName { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "250 simvoldan cox ola bilmez")]
        public string Profession { get; set; }
    }
}
