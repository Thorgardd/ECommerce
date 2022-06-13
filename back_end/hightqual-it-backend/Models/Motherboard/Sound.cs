using hightqual_it_backend.Models.Detail;

namespace hightqual_it_backend.Models.Motherboard
{
    public class Sound
    {
        private int id;
        private string power;
        private string format;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Power { get => power; set => power = value; }
        public string Format { get => format; set => format = value; }

        // Virtual getter & setter
        public virtual Brand Brand { get; set; }
    }
}
