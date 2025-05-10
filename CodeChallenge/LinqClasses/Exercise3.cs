using System.ComponentModel.Design;
using System.Text.Json;

namespace LinqClasses
{
    public class Exercise3 : IExercise
    {
        public List<Product> products;
        public string Execute()
        {
            var topProducExpensive = 3;

            products = products.OrderByDescending(x => x.Price).ToList();

            return ShowData(GetTopNExpensiveProducts(products, topProducExpensive));
        }

        private List<Product> GetTopNExpensiveProducts(List<Product> products, int n)
        {
            return products.Take(n).ToList();
        }

        public void PrepareData()
        {
            products = new List<Product>
            {
                new Product
                {
                    Name = "A",
                    Price= 50
                },
                new Product
                {
                    Name = "B",
                    Price= 100
                },
                new Product
                {
                    Name = "C",
                    Price= 10
                },
                new Product
                {
                    Name = "D",
                    Price= 70
                },
                new Product
                {
                    Name = "E",
                    Price= 50
                },
                new Product
                {
                    Name = "F",
                    Price= 200
                },
                new Product
                {
                    Name = "G",
                    Price= 150
                },
                new Product
                {
                    Name = "H",
                    Price= 100
                }
            };
        }

        public string ShowData(object objectToParse)
        {
            return JsonSerializer.Serialize(objectToParse);
        }
    }
}
