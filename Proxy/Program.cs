using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy");

            Person person = new Person();
            person.Name = "Enzo";
            person.Idade = 20;

            Service.Insert(person);

            Console.WriteLine("Fim");
        }
    }
}