using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_coban
{
    internal class Generic
    {
        struct sinhvien
        {
            public int id;
            public string name;
            public int age;

            public void Xuat()
            {
                Console.WriteLine("Ten: "+ name);
                Console.WriteLine("Tuoi: " + age);
            }//end Xuat

        }//end struct

        static void MyListGeneric()
        {
            // Công thức List<T> <tên biến> = new List<T>();
            // T là kiểu dữ liệu
            List<sinhvien> list = new List<sinhvien>();

            sinhvien sv1;
            sv1.id = 22;
            sv1.name = "Nguyen van A";
            sv1.age = 18;
            sinhvien sv2;
            sv2.id = 33;
            sv2.name = "le van B";
            sv2.age = 20;

            list.Add(sv1);
            list.Add(sv2);
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Xuat();
            }

            foreach (sinhvien sv in list)
            {
                sv1.Xuat();
                break;
            }
        }// end MyListGeneric

        static void MyDictionaryGeneric()
        {
            //công thức Dictionary<Key<T>,Value<T>> <tên biến> = new Dictionary<Key<T>,Value<T>>
            Dictionary<int, sinhvien> list = new Dictionary<int, sinhvien>();
            sinhvien sv1;
            sv1.id = 22;
            sv1.name = "Nguyen van A";
            sv1.age = 18;
            sinhvien sv2;
            sv2.id = 33;
            sv2.name = "le van B";
            sv2.age = 20;

            list.Add(sv1.id, sv1);
            list.Add(sv2.id, sv2);

            foreach (sinhvien sv in list.Values)
                sv.Xuat();
            Console.WriteLine("-------------------------");
            Console.WriteLine("xuat theo id");
            list[22].Xuat();
            Console.WriteLine("xoa theo id");
            list.Remove(22);
        }// end MyDictionaryGeneric
        static void Main(string[] args)
        {
            //MyListGeneric();
            MyDictionaryGeneric();
            Console.ReadLine();
        }// end main
    }
}
