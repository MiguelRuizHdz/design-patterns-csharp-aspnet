using DesignPattern.Models;
using DesignPattern.RepositoryPattern;
using System;
using System.Linq;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {


            using (var context = new DesignPatternsContext())
            {
                var beerRepository = new BeerRepository(context);
                var beer = new Beer();
                beer.Name = "Corona";
                beer.Style = "Pilsner";

                beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var b in beerRepository.Get())
                {
                    Console.WriteLine(b.Name);
                }

                //var lst = context.Beers.ToList();
                //foreach (var beer in lst)
                //{
                //    Console.WriteLine(beer.Name);
                //}
            }



            /*
             *  Dependency Injection
             */
            // Tu clase no debería depender de cómo crear las cosas y simplemente recibir las cosas ya hechas.
            // Haces el objeto de cerveza.
            // Esta responsabilidad va a estar fuera de la clase DrinkWithBeer o bebida con cerveza.
            // Este objeto de cerveza se lo mandas donde tiene que ir.

            //var beer = new Beer("Pikantus", "Erdinger");
            //DrinkWithBeer drinkWithBeer = new DrinkWithBeer(10, 1, beer);
            //drinkWithBeer.Build();


            /*
             * Factory Method
             */

            // no puedes crear un objeto de una clase abstracta pero si puedes crearlo de sus jerarquías o sea sus hijos.
            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //SaleFactory internetSaleFactory = new StoreSaleFactory(2);

            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(15);

            //ISale sale2 = internetSaleFactory.GetSale();
            //sale2.Sell(15);


            /*
             * Singleton
             */
            //var singleton = Singleton.Singleton.Instance;
            //var log = Singleton.Log.Instance; // se obtiene el objeto
            //log.Save("a");
            //log.Save("b");

            //// El objeto es el mismo en toda la aplicación
            //var a = Singleton.Singleton.Instance;
            //var b = Singleton.Singleton.Instance;

            //Console.WriteLine(a == b); // True
        }
    }
}
