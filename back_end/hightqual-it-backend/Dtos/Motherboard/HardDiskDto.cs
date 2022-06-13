using System.Text.Json.Serialization;
using hightqual_it_backend.Dtos.Detail;

namespace hightqual_it_backend.Dtos.Motherboard
{
    public class HardDiskDto
    {
        private double capacity;
        private string type;
        private bool isExternal;
        private BrandDto brand;
        private ComputerDto computer;

        public double Capacity { get => capacity; set => capacity = value; }
        public string Type { get => type; set => type = value; }
        public bool IsExternal { get => isExternal; set => isExternal = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
    }
}
