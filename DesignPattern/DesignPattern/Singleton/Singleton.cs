using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        // Patron para crear objetos
        // Hacer que solamente exista un objeto en nuestra aplicación

        // se ejecuta al iniciar el proyecto
        private readonly static Singleton _instance = new Singleton();

        // acceso a la propiedad privada _instance
        // static: pertenece a la clase no al objeto
        public static Singleton Instance { get { return _instance; } }

        // Constructor privado por lo cual no vas a poder crear un objeto de esta clase (protection level)
        private Singleton() { }
    }
}
