using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        var filtered = await context.Products
            .Where(p => p.Price > 1000)
            .OrderByDescending(p => p.Price)
            .ToListAsync();

        Console.WriteLine("Filtered & Sorted Products (Price > ₹1000):");
        foreach (var p in filtered)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        var productDTOs = await context.Products
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();

        Console.WriteLine("\nProducts (DTO Projection):");
        foreach (var dto in productDTOs)
        {
            Console.WriteLine($"{dto.Name} - ₹{dto.Price}");
        }
    }
}
