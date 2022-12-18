using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjectionPattern
{
    public class DrinkWithBeer
    {
        // La inyección de dependencia en primero trata sobre quitar la responsabilidad de una clase de crear objetos a partir de otras clases.
        // Es decir, esta clase no tiene por qué saber cómo crear ciertos objetos.
        
        //private Beer _beer = new Beer("Pikantus", "Erdinger");
        private Beer _beer;
        private decimal _water;
        private decimal _sugar;

        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }

        public void Build()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {_water}" +
                $" azúcar {_sugar} y cerveza {_beer.Name}");
        }
    }
}
