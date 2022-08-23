using System;

namespace Proxy
{
    public class Repository
    {
        public static void Insert(Person person)
        {
            Console.WriteLine($"Nome: {person.Name}\nIdade: {person.Idade}");
        }
    }
}
