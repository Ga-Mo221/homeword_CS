using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dahinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tong t = new tong();
            Console.WriteLine(t.Tong(3, 5));
            Console.WriteLine(t.Tong(4, 6, 7));
            
            Console.ReadKey();
        }
    }
}
