
using System;

namespace SelectManyImplements
{
    public class Program
    {
        public class ProductStore
        {
            public int price { get; set; }
            public string name { get; set; }
            public List<string> size { get; set; }
        }
        public static void Main(String[] args)
        {
            IList<ProductStore> ProductList = new List<ProductStore>();
            ProductList.Add(new ProductStore
            { 
                price = 100, 
                name = "A",
                size = new List<string> { "A1", "A2", "A3" }
            });
            ProductList.Add(new ProductStore
            {
                price = 150,
                name = "B",
                size = new List<string> { "B1", "B2" }
            }); 
            ProductList.Add(new ProductStore
            {
                price = 10,
                name = "C",
                size = new List<string> { "C1", "C2", "C3", "C4" }
            });
            ProductList.Add(new ProductStore
            {
                price = 600,
                name = "D",
                size = new List<string> { "D1" }
            });

            var result = from p in ProductList
                         select p;
            foreach(var item in result.SelectMany(ProductStore => ProductStore.size))
            {
                Console.WriteLine(item);
            }

        }
    }
}
