using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
        if (product != null)
        {
            Console.WriteLine($"Old Price of Laptop: ₹{product.Price}");
            product.Price = 70000;
            await context.SaveChangesAsync();
            Console.WriteLine("Updated Laptop price to ₹70000.");
        }

        var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
        if (toDelete != null)
        {
            context.Products.Remove(toDelete);
            await context.SaveChangesAsync();
            Console.WriteLine("Deleted product: Rice Bag.");
        }

        var products = await context.Products.ToListAsync();
        Console.WriteLine("\nRemaining Products:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }
    }
}
