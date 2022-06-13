namespace hightqual_it_backend.Models.Detail
{
    public class Commentary
    {
        private int id;
        private string product_name;
        private string reference;
        private string content;
        private int rate;
        private string date_post;

        public int Id { get => id; set => id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public string Reference { get => reference; set => reference = value; }
        public string Content { get => content; set => content = value; }
        public int Rate { get => rate; set => rate = value; }
        public string Date_post { get => date_post; set => date_post = value; }
    }
}
