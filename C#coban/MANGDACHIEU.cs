using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_coban
{
    internal class MANGDACHIEU
    {
        static void Main(string[] args)
        {
            // mang luom chom
            int[][] jg =
                {
                new int[] {3},
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 }
                };

            for (int i = 0; i < jg.Length; i++)
            {
                for (int j = 0; j < jg[i].Length; j++)
                {
                    Console.WriteLine(jg[i][j] + " ");
                }
            }




            Console.ReadKey();
        }// end main
    }
}
