using System;

namespace hightqual_it_backend.Models.Logistic
{
    public class Cart
    {
        private int id;
        private string reference;
        private string productRef;
        private int count;
        private DateTime dateCreated;

        // Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Reference { get => reference; set => reference = value; }
        public string ProductRef { get => productRef; set => productRef = value; }
        public int Count { get => count; set => count = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }

        // Virtual getters & setters
        public virtual Computer Item { get; set; }
    }
}
