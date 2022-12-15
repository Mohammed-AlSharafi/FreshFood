using FreshFood;
using FreshFood.Data;

using (var unitOfWork = new UnitOfWork(new FreshFoodContext()))

{
    var burger = new Product()
    {
        Name = "burger",
        Price = 15.99M
    };
    unitOfWork.ProductsRepository.Add(burger);
    unitOfWork.Complete();
    var products = unitOfWork.ProductsRepository.GetAll();

    foreach (Product product in products)
    {
        Console.WriteLine($"Id:    {product.Id}");
        Console.WriteLine($"Name:  {product.Name}");
        Console.WriteLine($"Price: {product.Price}");
        Console.WriteLine(new string('-', 20));
    }
    unitOfWork.Dispose();
}