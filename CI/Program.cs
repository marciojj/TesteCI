using System;

namespace CITest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(CreateMessage());
        }

        public static String CreateMessage()
        {
            return "Metodo Teste CI";
        }
    }
}
