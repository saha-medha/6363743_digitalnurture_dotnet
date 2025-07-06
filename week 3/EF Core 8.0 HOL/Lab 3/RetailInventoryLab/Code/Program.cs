using (var context = new AppDbContext())
{
    var products = context.Products.ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Category ID: {product.CategoryId}");
    }
}

