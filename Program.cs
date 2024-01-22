using System;
using System.Linq;
using System.Collections.Generic;

//KLASSER. Här har jag lagt in Category listan i Product listan.
class Category
{
    public string name { get; set; }
}

class Product
{
    public string name { get; set; }
    public double price { get; set; }
    public Category category { get; set; }
}
/*Detta program använder en loop för att upprepade gånger be användaren om inmatning tills de anger "q". 
 Sedan skapade jag ett objekt och angav värdet på dess egenskaper, och sedan la till det i en lista med objekt.
Det skapar också ett objekt och lägger till det i en lista med objekt.
Sedan sorterar den listan över produkter efter pris och presenterar listan med summan av priserna.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv information om Kategori, Produkt och Pris.");
        Console.WriteLine("Skriv 'q' för att avsluta programmet.");
        Console.WriteLine();

        var products = new List<Product>();
        var categories = new List<Category>();

        while (true)
        {
            Console.Write("Ange Kategori (Ange 'q' för att avsluta.): ");
            string CategoryName = Console.ReadLine();
            if (CategoryName.ToLower() == "q")
            {
                break;
            }
            var category = new Category { name = CategoryName };
            categories.Add(category);

            Console.Write("Ange Produkt (Ange 'q' för att avsluta): ");
            string ProductName = Console.ReadLine();
            if (ProductName.ToLower() == "q")
            {
                break;
            }

            Console.Write("Ange Pris: ");
            double Price = double.Parse(Console.ReadLine()); //Måste skriva siffror
            Console.WriteLine();

        

        var product = new Product { name = ProductName, price = Price, category = category };
            products.Add(product);
        } 
    //SKRIVA UT PRODUKTERNA I PRIS ORDNING. LÄGSTA - HÖGSTA
        var sortedProducts = products.OrderBy(p => p.price).ToList();
        double total = 0;

        Console.WriteLine();
        Console.WriteLine("Program avslutat. Du skrev in följande,");
        Console.WriteLine("sorterade från lägsta pris till högsta pris:");

        foreach (var product in sortedProducts)
        {
            Console.WriteLine();
            Console.WriteLine("Kategori: "+ product.category.name);
            Console.WriteLine("Produkt: " + product.name);
            Console.WriteLine("Pris: " + product.price);
            Console.WriteLine();
            total += product.price;
        }
        Console.WriteLine("Totalsumma: " + total);
    }
}



