using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "Ali", "Vali", "Mammad", "Hasan", "Aytac", "Rena", "Sevgul", "Ramin", "Xurma" };

            Console.WriteLine("Bir char daxil edin:");
            char c = Console.ReadKey().KeyChar;

            foreach (var item in strings)
            {
                foreach (char ch in item)
                {
                    if (ch.ToString().ToLower() == c.ToString().ToLower())
                    {

                        Console.WriteLine($"Element: {item}, İndeks: {Array.IndexOf(strings, item)}");
                        break;
                    }
                }
            }
        }
    }
}
