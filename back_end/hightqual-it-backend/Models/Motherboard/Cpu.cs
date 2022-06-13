using hightqual_it_backend.Models.Detail;

namespace hightqual_it_backend.Models.Motherboard
{
    public class Cpu
    {
        private int id;
        private int nbCore;
        private string model;
        private decimal frequency;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public int NbCore { get => nbCore; set => nbCore = value; }
        public string Model { get => model; set => model = value; }
        public decimal Frequency { get => frequency; set => frequency = value; }

        // Virtual getters & setters
        public virtual Brand Brand { get; set; }
        public virtual Memory CpuMemory { get; set; }

        
    }
}
