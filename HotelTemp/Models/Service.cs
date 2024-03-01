using System.ComponentModel.DataAnnotations;

namespace HotelTemp.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public string Icon { get; set; }
        [Required]
        [MaxLength(80, ErrorMessage = "80 simvoldan cox ola bilmez")]
        public string Title { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "250 simvoldan cox ola bilmez")]
        public string SubTitle { get; set; }
    }
}
