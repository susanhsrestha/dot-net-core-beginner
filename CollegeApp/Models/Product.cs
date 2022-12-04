using System.ComponentModel;

namespace CollegeApp.Models;

public class ProductDB
{
    public List<Product> GetProductList()
    {
        List<Product> list = new List<Product>
            ();
        Product prod1 = new Product()
        {
            ProductID = 1,
            ProductName= "P1",
            category = "C1",
            Price= 10,
        };
        Product prod2 = new Product()
        {
            ProductID = 1,
            ProductName = "P1",
            category = "C1",
            Price = 10,
        };
        Product prod3 = new Product()
        {
            ProductID = 4,
            ProductName = "SQL",
            category = "Man",
            Price = 101,
        };
        list.Add(prod1);
        list.Add(prod2);
        return list;
    }
}

public class Product
{
    public int ProductID { get; set; }
    [DisplayName("Products Name")]
    public string ProductName { get; set; }
    public string category { get; set; }
    public decimal Price { get; set; }
}
