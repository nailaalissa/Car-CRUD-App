using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Exercise
{
    internal class Print
    {
        public Print()
        {
        }
        public void mainChoices()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(">> Pick an Option");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Add New Car ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Show All Cars");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Update Car Information ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Delete Car Information");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("5");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Save and Quite");

        }
    }
}
