using System;
using System.Linq;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"{ProductId} - {ProductName} ({Category})";
    }
}

class Program
{
    public static Product LinearSearch(Product[] products, string targetName)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, string targetName)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int result = string.Compare(products[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

            if (result == 0)
                return products[mid];
            else if (result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shirt", "Clothing"),
            new Product(3, "Shoes", "Footwear"),
            new Product(4, "Watch", "Accessories"),
            new Product(5, "Phone", "Electronics"),
        };

        // Linear Search (unsorted)
        Console.WriteLine("🔍 Linear Search for 'Phone'");
        var resultLinear = LinearSearch(products, "Phone");
        Console.WriteLine(resultLinear != null ? resultLinear.ToString() : "Product not found");

        // Binary Search (requires sorted array by name)
        var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
        Console.WriteLine("\n🔍 Binary Search for 'Phone'");
        var resultBinary = BinarySearch(sortedProducts, "Phone");
        Console.WriteLine(resultBinary != null ? resultBinary.ToString() : "Product not found");
    }
}
