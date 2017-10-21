using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ski.Domain.Entities;
using Ski.Domain.Entity;
using Ski.Service;

namespace Ski.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyFinanceContext ctx = new MyFinanceContext();

            //Category c = new Category { Name = "vetements" };
            //ctx.Categories.Add(c);
            //ctx.SaveChanges();
            //System.Console.Write("aaa");
            //System.Console.ReadKey();
            Product b = new Biological()
            {
                Name = "B1",
                Description = "produit de type Biological",
                Price = 800,
                Category = new Category { Name = "Meubles" },
                DateProd = new DateTime(2016,10,08),
                Herbs="test"

            };
            

            ProductService ps = new ProductService();
            // ps.Create(b);
            // ps.Commit();

            //System.Console.WriteLine("Insertion avec succès");

            /*List<Product> listeProduit = new List<Product>();
             listeProduit = ps.GetPGetProductsLastYearByCategory("Meubles").ToList();
             foreach (Product product in listeProduit)
             System.Console.WriteLine(product.Name);*/

            ps.Remove(b);
            System.Console.WriteLine("Suppression avec succès");

            System.Console.ReadKey();



        }
    }
}
