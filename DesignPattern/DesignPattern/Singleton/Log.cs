using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Log
    {
        // Patron para crear objetos
        // Hacer que solamente exista un objeto en nuestra aplicación

        // este objeto existe al momento que se compila o se genera el código en una aplicación
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        // acceso a la propiedad privada _instance que permite obtener el objeto mas no editarlo
        public static Log Instance { get { return _instance; } }

        // Constructor privado que protege de crear otros objetos de esta clase (protection level)
        private Log() { }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
