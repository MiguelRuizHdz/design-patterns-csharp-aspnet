using System;
using System.IO;

namespace Tools
{
    // con sealed hacemos que ya no se pueda heredar
    public sealed class Log
    {
        // Singleton Patron para crear objetos
        // Hacer que solamente exista un objeto en nuestra aplicación

        private static Log _instance = null;
        private string _path;
        // protección de hilos
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            // Lock lo que va hacer es que mientras está un hilo trabajando con este atributo no puede trabajar este hilo.
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }
            
            return _instance;
        }

        // Constructor privado que protege de crear otros objetos de esta clase (protection level)
        private Log(string path) 
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
