using hightqual_it_backend.Dtos.Detail;

namespace hightqual_it_backend.Dtos.Device
{
    public class ScreenDto
    {
        private string size;
        private string quality;
        private string reference;
        private BrandDto brand;


        public string Size { get => size; set => size = value; }
        public string Quality { get => quality; set => quality = value; }
        public string Reference { get => reference; set => reference = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
    }
}
