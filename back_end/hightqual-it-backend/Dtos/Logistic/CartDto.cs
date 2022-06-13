using System;

namespace hightqual_it_backend.Dtos.Logistic
{
    public class CartDto
    {
        private string reference;
        private string productRef;
        private int count;
        private DateTime dateCreated;
        private ComputerDto item;

        public string Reference { get => reference; set => reference = value; }
        public string ProductRef { get => productRef; set => productRef = value; }
        public int Count { get => count; set => count = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public ComputerDto Item { get => item; set => item = value; }
    }
}
