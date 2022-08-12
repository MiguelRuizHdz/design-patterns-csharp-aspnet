using System;

namespace IntroduccionDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Person miguel = new Person("Miguel", 21, "Mx");
            Person pancho = new Person("Francisco", 21, "Mx");
            Console.WriteLine(miguel.Show());
            Console.WriteLine(pancho.Show());
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
}
