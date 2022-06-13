namespace hightqual_it_backend.Dtos.Logistic
{
    public class OrderDetailDto
    {
        private int orderRef;
        private int productRef;
        private int quantity;
        private int unitPrice;
        private ComputerDto product;
        private OrderDto order;

        public int OrderRef { get => orderRef; set => orderRef = value; }
        public int ProductRef { get => productRef; set => productRef = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public ComputerDto Product { get => product; set => product = value; }
        public OrderDto Order { get => order; set => order = value; }
    }
}
