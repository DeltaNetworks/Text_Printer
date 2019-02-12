using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Text_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome !  type your message: ");
            string msg = Console.ReadLine();
            Prinet_Text(msg);
            Thread.Sleep(4000);
        }

        private static void Prinet_Text(string msg)
        {
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine(msg);
        }
    }
}
