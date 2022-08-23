using System;

namespace Proxy
{
    public class Service
    {
        public static void Insert(Person person)
        {
            if(person.Idade >= 18)
            {
                Repository.Insert(person);
                return;
            }
            Console.WriteLine("Pessoa é menor de idade");
        }
    }
}
