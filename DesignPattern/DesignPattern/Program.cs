using DesignPattern.FactoryPattern;
using System;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Factory Method
             */

            // no puedes crear un objeto de una clase abstracta pero si puedes crearlo de sus jerarquías o sea sus hijos.
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new StoreSaleFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);


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
