using hightqual_it_backend.Dtos.Detail;

namespace hightqual_it_backend.Dtos.Motherboard
{
    public class CpuDto
    {
        private int nbCore;
        private decimal frequency;
        private string model;
        private BrandDto brand;
        private MemoryDto cpuMemory;

        public int NbCore { get => nbCore; set => nbCore = value; }
        public decimal Frequency { get => frequency; set => frequency = value; }
        public string Model { get => model; set => model = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
        public MemoryDto CpuMemory { get => cpuMemory; set => cpuMemory = value; }

        
    }
}
