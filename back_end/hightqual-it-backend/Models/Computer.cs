using System.Collections.Generic;

using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Device;
using hightqual_it_backend.Models.Logistic;
using hightqual_it_backend.Models.Motherboard;

namespace hightqual_it_backend.Models
{
    public class Computer
    {
        private int id;
        private decimal price;
        private bool isOnSale;
        private string reference;
        private int nbVente;

        // Getters & Setters
        public decimal Price { get => price; set => price = value; }
        public bool IsOnSale { get => isOnSale; set => isOnSale = value; }
        public string Reference { get => reference; set => reference = value; }
        public int NbVente { get => nbVente; set => nbVente = value; }
        


        // Virtual getters & setters
        public virtual Os Os { get; set; }
        public virtual int Id { get; set; }
        public virtual Cpu Cpu { get; set; }
        public virtual List<GraphicProduct> GraphProds { get; set; }
        public virtual PowerSupply PowerSupply { get; set; }
        public virtual List<HardDisk> HardDisks { get; set; }
        public virtual List<Memory> Memories { get; set; }
        public virtual List<Connector> Connectors { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Mouse Mouse { get; set; }
        public virtual Screen Screen { get; set; }
        public virtual Sound Sound { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual List<Commentary> Commentaries { get; set; }
        public virtual List<Color> Colors { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Rank> Ranks { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual CriticalStock CriticalStock { get; set; }



        // Constructor
        public Computer()
        {
            Images = new List<Image>();
            Commentaries = new List<Commentary>();
            Ranks = new List<Rank>();
            Tags = new List<Tag>();
            Colors = new List<Color>();

            GraphProds = new List<GraphicProduct>();
            HardDisks = new List<HardDisk>();
            Memories = new List<Memory>();
            Connectors = new List<Connector>();
            
        }

    }
}
