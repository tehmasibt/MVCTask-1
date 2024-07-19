using Task1.Models;

namespace Task1.ViewModels
{
    public class HostileVM
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public List<Car> Cars { get; set; }
    }
}
