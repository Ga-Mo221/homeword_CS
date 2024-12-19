using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "ga";
            string type = "meo mun";
            CAT cat = new CAT(name, type);
            cat.XUAT();
            cat.SLEEP();
            cat.SPEECH();
            cat.RUN();

            Console.ReadKey();
        }
    }
}
