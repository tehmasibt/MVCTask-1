using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
