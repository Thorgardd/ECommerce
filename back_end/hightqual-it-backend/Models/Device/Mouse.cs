using System.ComponentModel;
using hightqual_it_backend.Models.Detail;
using Newtonsoft.Json;

namespace hightqual_it_backend.Models.Device
{
    public class Mouse
    {
        private int id;
        private bool isWireless;
        private string reference;
        private decimal price;
        private int stock;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public bool IsWireless { get => isWireless; set => isWireless = value; }
        public string Reference { get => reference; set => reference = value; }
        public decimal Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }

        // Virtual getter & setter
        public virtual Brand Brand { get; set; }
    }
}
