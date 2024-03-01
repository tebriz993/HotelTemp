using System.ComponentModel.DataAnnotations;

namespace HotelTemp.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        
        [Required]

        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Count), "Count deyeri menfi ola bilmez.");
                }
                _count = value;
            }
        }
        private int _count;

        [Required]
        [MaxLength(60, ErrorMessage = "60 simvoldan cox ola bilmez")]
        public string Title { get; set; }
    }
}
