using System.ComponentModel.DataAnnotations;

namespace HotelTemp.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Price_Time { get; set; }

        [Required]
        [MaxLength(60, ErrorMessage = "60 simvoldan cox ola bilmez")]
        public string Title { get; set; }

        [Required]
        public string Type1 { get; set; }

        [Required]
        public string Type2 { get; set; }

        [Required]
        public string Type3 { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "150 simvoldan cox ola bilmez")]
        public string SubTitle { get; set; }

       
    }
}
