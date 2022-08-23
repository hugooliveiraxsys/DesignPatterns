using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;

            singleton.Idade = 4;
            singleton.Nome = "Enzo";

            Singleton singleton2 = Singleton.Instance;

            singleton2.Idade = 5;
            singleton2.Nome = "Maria";

            Singleton singleton3 = Singleton.Instance;

            singleton3.Idade = 6;
            singleton3.Nome = "Joaquim";

            Console.WriteLine(singleton.Nome);
            Console.WriteLine(singleton.Idade);
            Console.WriteLine(singleton2.Nome);
            Console.WriteLine(singleton2.Idade);
            Console.WriteLine(singleton3.Nome);
            Console.WriteLine(singleton3.Idade);

            Console.WriteLine("Fim - Singleton");
        }
    }
}
