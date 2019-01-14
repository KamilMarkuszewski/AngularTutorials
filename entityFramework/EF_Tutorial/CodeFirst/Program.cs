using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KingsContext())
            {
                var cat = new Cat()
                {
                    IsLordAndKing = true,
                    Name = "Koteczek"
                };

                context.Cats.Add(cat);
                context.SaveChanges();

                foreach (var c in context.Cats)
                {
                    Console.WriteLine($"{c.Name}");
                }
            }



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
