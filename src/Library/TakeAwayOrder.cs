namespace Ucu.Poo.Restaurant
{
    public class TakeAwayOrder
    {
        public string CustomerName { get; private set; }
        public Order OrderDetails { get; private set; }
        public TakeAwayOrder(string customerName, Order orderDetails)
        {
            this.CustomerName = customerName;
            this.OrderDetails = orderDetails;
        }
        public double GetTotal()
        {
            return this.OrderDetails.GetTotal();
        }
    }
}