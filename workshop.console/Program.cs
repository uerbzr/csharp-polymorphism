using workshop.console.Shop;
using workshop.console.Shop.Interfaces;
using workshop.console.Shop.Products;



Basket basket = new Basket();

Guitar sg = new Guitar() { Id=1, Name="Gibson SG", Price=999.99M, NumberOfStrings=6};
Guitar strat = new Guitar() { Id = 2, Name = "Fender Stratocaster", Price = 899.99M, NumberOfStrings=12 };
Drums export = new Drums() { Id = 3, Name = "Pearl Export", Price = 1799.99M };
Guitar gem = new Guitar() { Id=4, Name= "Ibanez Gem", Price = 1999.99M, NumberOfStrings = 7 };

basket.AddProduct(sg);
basket.AddProduct(strat);
basket.AddProduct(export);
basket.AddProduct(gem);

basket.Products.ForEach(p => {
    Console.WriteLine(p.GetType() + " " + p.Name);
    
    if(p is IStringable )
    {
        Console.WriteLine($"{p.Name} has {((IStringable)p).NumberOfStrings} strings");
    }
    else
    {
        Console.WriteLine($"{p.Name} does not have strings");
    }


    Console.WriteLine(p.Name);
});

Console.WriteLine($"Total: {basket.Total}");
Console.WriteLine($"Total: {basket.Products.Sum(p => p.Price)}");




















