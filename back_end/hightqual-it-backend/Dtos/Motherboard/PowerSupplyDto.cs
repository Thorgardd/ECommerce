using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Logistic;

namespace hightqual_it_backend.Dtos.Motherboard
{
    public class PowerSupplyDto
    {
        private string power;
        private BrandDto brand;
        private CategoryDto category;

        public string Power { get => power; set => power = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
        public CategoryDto Category { get => category; set => category = value; }
    }
}
