using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP2_HDT
{
    internal class Program
    {


        static void Main(string[] args)
        {
         

            HINH[] danhsach = new HINH[10]; 
           
            HINH tamgiac = new TAMGIAC();
            HINH tron = new TRON();
            danhsach[0] = tamgiac;
            danhsach[1] = tron;

            foreach(HINH h in danhsach)
            {
                if (h is TAMGIAC)
                {
                    TAMGIAC tg = (TAMGIAC)h;
                    tg.Xuat();
                }
                else if (h is TRON)
                    ((TRON)h).Xuat();              

            }

            for(int i=0;i<danhsach.Length;i++)
            {
                if (danhsach[i] is TAMGIAC)
                    ((TAMGIAC)danhsach[i]).Xuat();
                else if (danhsach[i] is TRON)
                    ((TRON)danhsach[i]).Xuat();

            }


            Console.ReadKey();
        }
    }
}
