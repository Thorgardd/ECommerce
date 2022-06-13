using hightqual_it_backend.Dtos.Detail;

namespace hightqual_it_backend.Dtos.Motherboard
{
    public class MemoryDto
    {
        private string type;
        private string frequency;
        private string capacity;
        private string model;
        private BrandDto brand;

        public string Type { get => type; set => type = value; }
        public string Frequency { get => frequency; set => frequency = value; }
        public string Model { get => model; set => model = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
        public string Capacity { get => capacity; set => capacity = value; }
    }
}
