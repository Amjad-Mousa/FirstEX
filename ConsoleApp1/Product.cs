namespace ConsoleApp1;

public class Product(string name, double price, int quantity)
{
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;
    public int Quantity { get; set; } = quantity;

    public Product() : this(string.Empty, 0, 0)
    {
    }
}