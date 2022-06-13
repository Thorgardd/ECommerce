using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Logistic;

namespace hightqual_it_backend.Models.Motherboard
{
    public class PowerSupply
    {
        private int id;
        private string power;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Power { get => power; set => power = value; }

        // Virtual getters & setters
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}
