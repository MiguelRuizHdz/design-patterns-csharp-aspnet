using System;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Singleton.Instance;
            var log = Singleton.Log.Instance; // se obtiene el objeto
            log.Save("a");
            log.Save("b");
            
            // El objeto es el mismo en toda la aplicación
            var a = Singleton.Singleton.Instance;
            var b = Singleton.Singleton.Instance;

            Console.WriteLine(a == b); // True
        }
    }
}
