using System.ComponentModel.DataAnnotations;

namespace HotelTemp.Models
{
    public class Home
    {
        [Key]
        public int Id { get; set; }

        public string Image { get; set; }
        [Required]
        [MaxLength(60,ErrorMessage ="60 simvoldan cox ola bilmez")]
        public string Title { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "150 simvoldan cox ola bilmez")]
        public string SubTitle { get; set; }
    }
}
