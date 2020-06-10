using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestString2Int
{
    class Program
    {
        static void Main(string[] args)
        {
            string outText = "";
            Console.WriteLine("Key text : ");           
            while (Console.ReadKey().Key != ConsoleKey.Escape || (Console.ReadKey().Key == ConsoleKey.V) && (Console.ReadKey().Modifiers == ConsoleModifiers.Control))
            {
                string inputText = Console.ReadLine();
                outText = Regex.Replace(inputText, "[^0-9]", "");
                Console.WriteLine();
                Console.WriteLine("Numberic in text : ");
                Console.WriteLine(outText);
                Console.WriteLine();
                Console.WriteLine("Key text : ");
            }
        }
    }
}
