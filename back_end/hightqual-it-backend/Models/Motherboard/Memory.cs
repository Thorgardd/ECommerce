using hightqual_it_backend.Models.Detail;

namespace hightqual_it_backend.Models.Motherboard
{
    public class Memory
    {
        private int id;
        private string type;
        private string capacity;
        private string frequency;
        private string model;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Frequency { get => frequency; set => frequency = value; }
        public string Model { get => model; set => model = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        // Virtual getter & setter
        public virtual Brand Brand { get; set; }
        
    }
}
