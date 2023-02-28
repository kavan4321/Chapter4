
namespace Chapter4.Model.Page4Model
{
    public class CreateInvoiceModel
    {
        public string ProductName { get; set; }
        public string PurchaseDate { get; set; }
        public string PurchaseTime { get;set; }
        public bool IsPremium { get; set; }
        public string Premium { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string Address { get; set; }
        public double Quantity { get; set; }
        public string Amount { get; set; }
        public string Tax { get; set; }

    }
}
