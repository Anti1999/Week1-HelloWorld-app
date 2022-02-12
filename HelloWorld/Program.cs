using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere, mis on Teie nimi");
            string UserName;
            UserName = Console.ReadLine();
            Console.WriteLine("Tere, " + UserName);
            Console.Read();
        }
    }
}
