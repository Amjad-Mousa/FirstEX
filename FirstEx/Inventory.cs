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

public bool FindProduct(string productName)
{
    foreach (var product in products)
    {
        if (product.Name == productName)
        {
            return true;
        }
    }
    return false;
 }

public string EditProduct(string productName, string productPrice, string productQuantity)
{
    if (FindProduct(productName))
    {
        productPrice = productPrice;
        productQuantity = productQuantity;
        return "Product updated successfully.";
    }
    else return "Product not found.";
}


}