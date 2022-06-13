using hightqual_it_backend.Models.Detail;

namespace hightqual_it_backend.Models.Motherboard
{
    public class HardDisk
    {
        private int id;
        private double capacity;
        private string type;
        private bool isExternal;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public double Capacity { get => capacity; set => capacity = value; }
        public string Type { get => type; set => type = value; }
        public bool IsExternal { get => isExternal; set => isExternal = value; }

        // Virtual getter & setter
        public virtual Brand Brand { get; set; }
        public virtual Computer Computer { get; set; }
    }
}
