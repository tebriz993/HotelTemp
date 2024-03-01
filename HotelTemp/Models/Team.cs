using System.ComponentModel.DataAnnotations;

namespace HotelTemp.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public string Image { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "80 simvoldan cox ola bilmez")]
        public string Title { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "80 simvoldan cox ola bilmez")]
        public string Profession { get; set; }
    }
}
