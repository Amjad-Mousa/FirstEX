namespace ConsoleApp1;
public class MainClass
{
    public static void Main(string[] args){
    Inventory inventory = new Inventory();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Inventory Management Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Show All Products");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Search Product");
                Console.WriteLine("6. Exit");
                Console.Write("Please select an option (1-6): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter Product Name: ");
                        string addName = Console.ReadLine();
                        Console.Write("Enter Product Price: ");
                        double addPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Product Quantity: ");
                        int addQuantity = Convert.ToInt32(Console.ReadLine());
                        inventory.AddProduct(new Product(addName, addPrice, addQuantity));
                        Console.WriteLine("Product added successfully!");
                        break;

                    case "2":
                        inventory.ShowAllProducts();
                        break;

                    case "3":
                        Console.Write("Enter Product Name to Edit: ");
                        string editName = Console.ReadLine();
                        Console.Write("Enter New Price: ");
                        string editPrice = Console.ReadLine();
                        Console.Write("Enter New Quantity: ");
                        string editQuantity = Console.ReadLine();
                        Console.WriteLine(inventory.EditProduct(editName, editPrice, editQuantity));
                        break;

                    case "4":
                        Console.Write("Enter Product Name to Delete: ");
                        string deleteName = Console.ReadLine();
                        Console.WriteLine(inventory.DeleteProduct(deleteName));
                        break;

                    case "5":
                        Console.Write("Enter Product Name to Search: ");
                        string searchName = Console.ReadLine();
                        Console.WriteLine(inventory.SearchProduct(searchName));
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
    }
    
