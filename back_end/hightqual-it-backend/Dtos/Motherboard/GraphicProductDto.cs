using hightqual_it_backend.Dtos.Detail;

namespace hightqual_it_backend.Dtos.Motherboard
{
    public class GraphicProductDto
    {
        private string type;
        private BrandDto brand;
        private MemoryDto memory;

        public string Type { get => type; set => type = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
        public MemoryDto Memory { get => memory; set => memory = value; }
    }
}
