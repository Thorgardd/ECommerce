namespace hightqual_it_backend.Models.Detail
{
    public class Color
    {
        private int id;
        private string name;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        // Virtual getter & setter
        public virtual Image Sample { get; set; }
    }
}
