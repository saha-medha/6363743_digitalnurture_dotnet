using System;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // New category add karo
            var electronics = new Category { Name = "Electronics" };
            context.Categories.Add(electronics);
            context.SaveChanges();

            // Ek product bhi add karo
            var phone = new Product { Name = "Smartphone", Price = 25000, CategoryId = electronics.Id };
            context.Products.Add(phone);
            context.SaveChanges();

            // Print karo
            foreach (var product in context.Products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
