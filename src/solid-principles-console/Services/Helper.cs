using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles_console.Services
{
    public static class Helper
    {
        public static void PrintHeader(string title)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(title);
            Console.WriteLine(new string('-', 50));
        }
    }
}
