using hightqual_it_backend.Dtos.Detail;

namespace hightqual_it_backend.Dtos.Motherboard
{
    public class SoundDto
    {
        private string power;
        private string format;
        private BrandDto brand;

        public string Power { get => power; set => power = value; }
        public string Format { get => format; set => format = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
    }
}
