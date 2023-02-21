
namespace Chapter4.Model.Page4Model
{
    public class CreateInvoiceModel
    {
        public string ProductName { get; set; }
        public string PurchaseDate { get; set; }
        public string PurchaseTime { get;set; }
        public bool IsPremium { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public double Tax { get; set; }

    }
}
