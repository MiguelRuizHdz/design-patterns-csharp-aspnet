using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public class BarmanDirector
    {
        private IBuilder _builder;

        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 Limones");
            _builder.AddIngredients("pizca de sal");
            _builder.AddIngredients("1/2 taza de Tequila");
            _builder.AddIngredients("3/4 tazas de licor de naranja");
            _builder.AddIngredients("4 Cubos de hielo");
            _builder.Mix();
            _builder.Rest(1000);
        }

        public void PreparePiñaColada()
        {
            _builder.Reset();
            _builder.SetAlcohol(20);
            _builder.SetWater(10);
            _builder.SetMilk(500);
            _builder.AddIngredients("1/2 taza de ron");
            _builder.AddIngredients("1/2 crema de coco");
            _builder.AddIngredients("3/4 tazas de jugo de piña");
            _builder.Mix();
            _builder.Rest(2000);
        }
    }
}
