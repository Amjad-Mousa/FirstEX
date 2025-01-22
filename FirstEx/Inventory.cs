namespace ConsoleApp1;
public class Inventory
{
private List<Product> products=new List<Product>();

public void AddProduct(Product product)
{
    products.Add(product);
}

public void ShowProducts()
{
    if (products.Count==0)
    {
        System.Console.WriteLine("There are no products in inventory.");
    }

    foreach (var product in products)
    {
        System.Console.WriteLine($"ProductName:{products[0].Name}, Price:{products[0].Price}, Quantity:{products[0].Quantity}");
    }
}
}