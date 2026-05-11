namespace PearlPineproject.Model
{
    public class orderModel
    {
        public int Id { get; set; }

        public string UserEmail { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int TotalAmount { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
