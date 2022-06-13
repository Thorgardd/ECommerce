using System;
using System.Collections.Generic;

namespace hightqual_it_backend.Models.Logistic
{
    public class Order
    {
        private int id;
        private string orderRef;
        private string username;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string postalCode;
        private string country;
        private string phone;
        private string email;
        private decimal total;
        private DateTime orderDate;

        public int Id { get => id; set => id = value; }
        public string OrderRef { get => orderRef; set => orderRef = value; }
        public string Username { get => username; set => username = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string Country { get => country; set => country = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public decimal Total { get => total; set => total = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
