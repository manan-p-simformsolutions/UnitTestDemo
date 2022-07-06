using NUnit.Framework;
namespace HotelManagement.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestFixture]
        public class HotelManagementTests
        {
            [TestCase]
            public void When_NormalCustomer_Expect_5PercentDiscount()
            {
                Customer normalcustomer = new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Mohit",
                    CustomerType = CustomerType.Normal
                };

                Order order = new Order
                {
                    OrderId = 1,
                    ProductId = 1,
                    ProductQuantity = 1,
                    Amount = 200
                };

                HotelManagement customerOrderService = new HotelManagement();

                //Act
                customerOrderService.ApplyDiscount(normalcustomer, order);

                //Assert
                Assert.AreEqual(order.Amount, 190);
            }

            [TestCase]
            public void When_PremiumCustomer_Expect_15PercentDiscount()
            {
                //Arrange
                Customer premiumCustomer = new Customer
                {
                    CustomerId = 2,
                    CustomerName = "Manan",
                    CustomerType = CustomerType.Premium
                };

                Order order = new Order
                {
                    OrderId = 2,
                    ProductId = 2,
                    ProductQuantity = 1,
                    Amount = 300
                };

                HotelManagement customerOrderService = new HotelManagement();

                //Act
                customerOrderService.ApplyDiscount(premiumCustomer, order);

                //Assert
                Assert.AreEqual(order.Amount, 255);
            }

            [TestCase]
            public void When_SpecialCustomer_Expect_30PercentDiscount()
            {
                //Arrange
                Customer specialcustomer = new Customer
                {
                    CustomerId = 3,
                    CustomerName = "Manav",
                    CustomerType = CustomerType.SpecialCustomer
                };

                Order order = new Order
                {
                    OrderId = 2,
                    ProductId = 2,
                    ProductQuantity = 1,
                    Amount = 300
                };

                HotelManagement customerOrderService = new HotelManagement();

                //Act
                customerOrderService.ApplyDiscount(specialcustomer, order);

                //Assert
                Assert.AreEqual(order.Amount, 210);
            }
        }
    }
}