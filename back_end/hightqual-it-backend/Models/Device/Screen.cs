using hightqual_it_backend.Models.Detail;

namespace hightqual_it_backend.Models.Device
{
    public class Screen
    {
        private int id;
        private string size;
        private string quality;
        private string reference;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Size { get => size; set => size = value; }
        public string Quality { get => quality; set => quality = value; }
        public string Reference { get => reference; set => reference = value; }

        // Virtual getter & setter
        public virtual Brand Brand { get; set; }
    }
}
