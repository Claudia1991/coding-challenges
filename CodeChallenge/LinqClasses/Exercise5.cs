using System.Text.Json;

namespace LinqClasses
{
    public class Exercise5 : IExercise
    {
        public List<Order> Orders;
        public List<Customer> Customers;
        public string Execute()
        {
            var ordersInformation = Customers.Join(Orders, x => x.CustomerID, y => y.CustomerID, (x,y) => new { x.CustomerName, y.OrderID, y.Amount } );

            return ShowData(ordersInformation);
        }

        public void PrepareData()
        {
            Customers = new List<Customer>
            {
                new Customer
                {
                    CustomerName= "A",
                    CustomerID = 1
                },
                new Customer
                {
                    CustomerName= "B",
                    CustomerID = 2
                }
            };

            Orders = new List<Order> 
            {
                new Order
                {
                    OrderID = 1,
                    CustomerID = 1,
                    Amount=1000
                },
                new Order
                {
                    OrderID = 2,
                    CustomerID = 2,
                    Amount=2000
                }
            };
        }

        public string ShowData(object objectToParse)
        {
            return JsonSerializer.Serialize(objectToParse);
        }
    }
}
