using hightqual_it_backend.Models;

namespace hightqual_it_backend.Dtos.Motherboard
{
    public class ConnectorDto
    {
        private string name;
        private string version;
        private ComputerDto computer;

        public string Name { get => name; set => name = value; }
        public string Version { get => version; set => version = value; }
        public ComputerDto Computer { get => computer; set => computer = value; }
    }
}
