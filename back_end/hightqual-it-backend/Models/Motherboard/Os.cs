namespace hightqual_it_backend.Models.Motherboard
{
    public class Os
    {
        private int id;
        private string name;
        private string version;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Version { get => version; set => version = value; }
    }
}
