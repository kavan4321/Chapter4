

namespace Chapter4.Model
{
    public  class Page2Model
    {
        public string Name 
        { 
            get => "Freight"; 
            set { } 
        }
        public string TruckWidth 
        {
            get => "4";
            set { }
        }
        public string TruckWeight 
        {
            get => "1.5";
            set { } 
        }
        public DateTime SelcetDate { get; set; }
        public DateTime SelcetTime { get; set; }

    }
}
