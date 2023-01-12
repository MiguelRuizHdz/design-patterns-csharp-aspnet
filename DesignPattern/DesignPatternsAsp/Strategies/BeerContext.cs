using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;

namespace DesignPatternsAsp.Strategies
{
    public class BeerContext
    {
        // Soy un contexto, no pienso, solo ejecuto
        private IBeerStrategy _strategy;

        public IBeerStrategy Strategy
        {
            set { _strategy = value; }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        // Tu estrategia a mí no me interesa, a mí lo único que me interesa es trabajar
        // Yo soy solamente un vil mensajero
        // Estrategia es un patrón de diseño de comportamiento
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVM, unitOfWork);
        }

    }
}
