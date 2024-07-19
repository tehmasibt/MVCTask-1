using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}
