using System.ComponentModel;
using hightqual_it_backend.Dtos.Detail;
using Newtonsoft.Json;

namespace hightqual_it_backend.Dtos.Device
{
    public class MouseDto
    {
        private bool isWireless;
        private BrandDto brand;
        private string reference;
        private decimal price;
        private int stock;
        
        public bool IsWireless { get => isWireless; set => isWireless = value; }
        public string Reference { get => reference; set => reference = value; }
        public decimal Price { get => price; set => price = value; }        
        public int Stock { get => stock; set => stock = value; }
        public BrandDto Brand { get => brand; set => brand = value; }
    }
}
