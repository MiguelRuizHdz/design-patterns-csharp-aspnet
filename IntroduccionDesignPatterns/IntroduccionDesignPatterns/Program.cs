using System;
using System.Collections.Generic;

namespace IntroduccionDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var miguel = new SportyPerson("Miguel", 21, "mexicano");
            var pancho = new SportyPerson("Francisco", 21, "mexicano");
            Console.WriteLine(miguel.Show());
            Console.WriteLine(pancho.Show());

            miguel.Run();


            List<IVolador> aves = new List<IVolador>();
            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            var gallina1 = new Gallina();
            aves.Add(pato1);
            aves.Add(pato2);
            aves.Add(pato3);
            aves.Add(gallina1);

            AVolar(aves);

        }

        static void AVolar(List<IVolador> aves)
        {
            foreach (var ave in aves)
            {
                ave.Vuela();
            }
        }

        interface IVolador
        {
            public void Vuela();
        }

        interface ICaminador
        {
            public void Camina();
        }

        public class Pato : IVolador, ICaminador
        {
            public void Vuela()
            {
                Console.WriteLine("pato vuela");
            }
            public void Camina()
            {
                Console.WriteLine("pato camina");
            }
        }

        public class Gallina : IVolador
        {
            public void Vuela()
            {
                Console.WriteLine("pato vuela");
            }
        }
    }

    class Person
    {
        public string name;
        public int age;
        public string nationality;

        public Person(string name_, int age_, string nationality_)
        {
            this.name = name_;
            this.age = age_;
            this.nationality = nationality_;
        }

        public string Show()
        {
            return name + " " + age + " " + nationality;
        }
    }

    class SportyPerson : Person
    {
        public SportyPerson(string name_, int age_, string nationality_) : base(name_, age_, nationality_ )
        {

        }

        public void Run()
        {
            Console.WriteLine(name + " esta corriendo");
        }
    }

    

}
