namespace hightqual_it_backend.Dtos.Detail
{
    public class ColorDto
    {
        private string name;
        private ImageDto sample;

        public string Name { get => name; set => name = value; }
        public ImageDto Sample { get => sample; set => sample = value; }
    }
}
