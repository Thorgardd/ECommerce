namespace hightqual_it_backend.Models.Logistic
{
    public class Category
    {
        private int id;
        private string name;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
