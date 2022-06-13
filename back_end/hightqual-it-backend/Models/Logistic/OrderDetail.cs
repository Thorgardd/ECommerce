namespace hightqual_it_backend.Models.Logistic
{
    public class OrderDetail
    {
        private int id;
        private string orderRef;
        private string productRef;
        private int quantity;
        private decimal unitPrice;

        public int Id { get => id; set => id = value; }
        public string OrderRef { get => orderRef; set => orderRef = value; }
        public string ProductRef { get => productRef; set => productRef = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }

        public virtual Computer Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
