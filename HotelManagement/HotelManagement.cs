namespace HotelManagement
{
    public enum CustomerType
    {
        Normal,
        Premium,
        SpecialCustomer
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public CustomerType CustomerType { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal Amount { get; set; }
    }
    public class HotelManagement
    {   
        public void ApplyDiscount(Customer customer,Order order)
        {
            if(customer.CustomerType == CustomerType.Normal)
            {
                order.Amount = order.Amount - ((order.Amount * 5) / 100);
            }
            else if (customer.CustomerType == CustomerType.Premium)
            {
                order.Amount = order.Amount - ((order.Amount * 15) / 100);
            }
            else if (customer.CustomerType == CustomerType.SpecialCustomer)
            {
                order.Amount = order.Amount - ((order.Amount * 30) / 100);
            }
        }

    }
}