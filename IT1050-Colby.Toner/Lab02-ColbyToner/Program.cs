using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_ColbyToner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine("Your first number plus your second number is " + sum);
            int x = 3;
            int y = 4;
            int z = 5;
            Console.WriteLine((x + y) * (z + 10));
            Console.WriteLine("Hello \t World ");
            Console.WriteLine("Hello \nWorld ");
            Console.WriteLine("\"Hello World!\" ");
            Console.WriteLine("Hello\\World! ");
            
        }
    }
}
