// See https://aka.ms/new-console-template for more information

using ConsoleApp.CodeFirst;
using ConsoleApp.CodeFirst.Models;
using ConsoleApp.CodeFirst.Services;

//DefaultContext db = new DefaultContext();
//db.Database.EnsureCreated();

var res = "n";
do
{
    Console.Clear();
    Console.WriteLine("\n1 to get the list of product\n2 to get by Id\n3 to create the product \n4 to edit the existing product \n5 to delete the product\nEnter the Choice.");
    var choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            GetAll();
            break;

        case 2:
            GetById();
            break;

        case 3:
            Create();
            break;

        case 4:
            Edit();
            break;

        case 5:
            Delete();
            break;

        default:
            Console.WriteLine("Invalid Entry");
            break;
    }

    Console.WriteLine("Do you want to continue more? (y/n)");
    res = Console.ReadLine();
} while (res.ToUpper() == "Y");

static void GetAll()
{
    ProductServices product = new ProductServices();
    var data = product.GetAll();
    foreach (var item in data)
    {
        Console.WriteLine($"Id = {item.Id}");
        Console.WriteLine($"Product Name = {item.ProductName}");
        Console.WriteLine($"Product Descriptiom = {item.Description}");
        Console.WriteLine("----------------------------------------------------");
    }
}
static void GetById()
{
    ProductServices product = new ProductServices();
    Console.WriteLine("Enter the Id of product");
    var id = Convert.ToInt32(Console.ReadLine());
    var item = product.GetById(id);

    Console.WriteLine($"Id = {item.Id}");
    Console.WriteLine($"Product Name = {item.ProductName}");
    Console.WriteLine($"Product Descriptiom = {item.Description}");
    Console.WriteLine("----------------------------------------------------");
}
static void Create()
{
    ProductServices product = new ProductServices();

    var pr = new Product();
    Console.WriteLine("Enter the Name of product");
    pr.ProductName = Console.ReadLine();
    Console.WriteLine("Enter the description of product");
    pr.Description = Console.ReadLine();

    var result = product.Create(pr);
    if (result)
    {
        Console.WriteLine("Added record successfully");
    }
    else
    {
        Console.WriteLine("Unable to add");
    }
}
static void Edit()
{
    ProductServices product = new ProductServices();

    var pr = new Product();
    Console.WriteLine("Enter the Id of product");
    pr.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Name of product");
    pr.ProductName = Console.ReadLine();
    Console.WriteLine("Enter the description of product");
    pr.Description = Console.ReadLine();

    var result = product.Edit(pr);
    if (result)
    {
        Console.WriteLine("updated record successfully");
    }
    else
    {
        Console.WriteLine("Unable to update");
    }
}
static void Delete()
{
    ProductServices product = new ProductServices();

    Console.WriteLine("Enter the Id of product");
    var Id = Convert.ToInt32(Console.ReadLine());

    var result = product.Delete(Id);
    if (result)
    {
        Console.WriteLine("deleted record successfully");
    }
    else
    {
        Console.WriteLine("Unable to delete");
    }
}