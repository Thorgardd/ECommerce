using System;

namespace hightqual_it_backend.Models.Detail
{
    public class Rank
    {
        private int id;
        private decimal score;
        private string commentary;
        private string firstName;
        private string lastName;
        private DateTime date;

        public int Id { get => id; set => id = value; }
        public decimal Score { get => score; set => score = value; }
        public string Commentary { get => commentary; set => commentary = value; }
        public DateTime Date { get => date; set => date = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
