using hightqual_it_backend.Models.Detail;

namespace hightqual_it_backend.Models.Motherboard
{
    public class GraphicProduct
    {
        private int id;
        private string type;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }

        // Virtual getters & setters
        public virtual Brand Brand { get; set; }
        public virtual Memory Memory { get; set; }
    }
}
