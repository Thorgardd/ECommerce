using System.Collections.Generic;
using hightqual_it_backend.Dtos.Detail;
using hightqual_it_backend.Dtos.Device;
using hightqual_it_backend.Dtos.Logistic;
using hightqual_it_backend.Dtos.Motherboard;

namespace hightqual_it_backend.Dtos
{
    public class ComputerDto
    {
        // Computer
        private decimal price;
        private bool isOnSale;
        private string reference;
        private int nbVente;

        // Motherboard
        private OsDto os;
        private CpuDto cpu;
        private PowerSupplyDto powerSupply;
        private SoundDto sound;
        private List<GraphicProductDto> graphProds;
        private List<HardDiskDto> hardDisks;
        private List<MemoryDto> memories;
        private List<ConnectorDto> connectors;

        // Detail
        private BrandDto brand;
        private List<ImageDto> images;
        private List<ColorDto> colors;
        private List<RankDto> ranks;
        private List<CommentaryDto> commentaries;

        // Device
        private MouseDto mouse;
        private ScreenDto screen;
        

        // Logistic
        private CategoryDto category;
        private CriticalStockDto criticalStock;
        private List<TagDto> tags;
        private StockDto stock;



        // Getters & Setters
        public decimal Price { get => price; set => price = value; }
        public bool IsOnSale { get => isOnSale; set => isOnSale = value; }
        public string Reference { get => reference; set => reference = value; }
        public int NbVente { get => nbVente; set => nbVente = value; }


        public OsDto Os { get => os; set => os = value; }
        public CpuDto Cpu { get => cpu; set => cpu = value; }
        public PowerSupplyDto PowerSupply { get => powerSupply; set => powerSupply = value; }
        public SoundDto Sound { get => sound; set => sound = value; }
        public List<GraphicProductDto> GraphProds { get => graphProds; set => graphProds = value; }
        public List<HardDiskDto> HardDisks { get => hardDisks; set => hardDisks = value; }
        public List<MemoryDto> Memories { get => memories; set => memories = value; }
        public List<ConnectorDto> Connectors { get => connectors; set => connectors = value; }


        public BrandDto Brand { get => brand; set => brand = value; }
        public List<ImageDto> Images { get => images; set => images = value; }
        public List<ColorDto> Colors { get => colors; set => colors = value; }
        public List<RankDto> Ranks { get => ranks; set => ranks = value; }
        public List<CommentaryDto> Commentaries { get => commentaries; set => commentaries = value; }


        public MouseDto Mouse { get => mouse; set => mouse = value; }
        public ScreenDto Screen { get => screen; set => screen = value; }


        public CategoryDto Category { get => category; set => category = value; }
        public CriticalStockDto CriticalStock { get => criticalStock; set => criticalStock = value; }
        public List<TagDto> Tags { get => tags; set => tags = value; }
        public StockDto Stock { get => stock; set => stock = value; }
    }
}
