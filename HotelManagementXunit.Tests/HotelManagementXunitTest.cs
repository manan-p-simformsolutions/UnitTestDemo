using HotelManagement;
using Xunit;
namespace HotelManagementXunit.Tests
{
    public class HotelManagementTest
    {
        [Fact]
        public void When_NormalCustomer_Expect_5PercentDiscount()
        {
            //Arrange
            Customer normalCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "Manan",
                CustomerType = CustomerType.Normal
            };
            Order order = new Order
            {
                OrderId = 1,
                ProductId = 1,
                ProductQuantity = 1,
                Amount = 300
            };

            HotelManagement.HotelManagement customerOrderService2 = new HotelManagement.HotelManagement();

            //Act
            customerOrderService2.ApplyDiscount(normalCustomer, order);

            //Assert
            Assert.Equal(order.Amount, 285);
        }
        [Fact]
        public void When_PremiumCustomer_Expect_15PercentDiscount()
        {
            //Arrange
            Customer premiumCustomer = new Customer
            {
                CustomerId = 2,
                CustomerName = "Akash",
                CustomerType = CustomerType.Premium
            };
            Order order = new Order
            {
                OrderId = 1,
                ProductId = 1,
                ProductQuantity = 1,
                Amount = 200
            };

            HotelManagement.HotelManagement customerOrderService2 = new HotelManagement.HotelManagement();

            //Act
            customerOrderService2.ApplyDiscount(premiumCustomer, order);

            //Assert
            Assert.Equal(order.Amount, 170);
        }
        [Fact]  
        public void When_SpecialCustomer_Expect_30PercentDiscount()
        {
            Customer specialcustomer = new Customer
            {
                CustomerId = 3,
                CustomerName = "Keval",
                CustomerType = CustomerType.SpecialCustomer
            };

            Order order = new Order
            {
                OrderId = 2,
                ProductId = 1,
                ProductQuantity = 1,
                Amount = 300
            };

            HotelManagement.HotelManagement customerOrderService2 = new HotelManagement.HotelManagement();

            //Act
            customerOrderService2.ApplyDiscount(specialcustomer, order);

            //Assert
            Assert.Equal(order.Amount, 210);
        }
    }
}