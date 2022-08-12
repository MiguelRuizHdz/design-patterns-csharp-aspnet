using System;

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
