using System;
using System.Collections;
//using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace C_coban
{
    internal class collection
    {
        struct sinhvien
        {
            public String Masv;
            public String Hoten;
            public DateTime Ngaysinh;
            public long CCCD;
            public String Gioitinh;
            public sinhvien(string masv, String hoten, DateTime ngaysinh, long cccd, String gioitinh)
            {
                Masv = masv;
                Hoten = hoten;
                Ngaysinh = ngaysinh;
                CCCD = cccd;
                Gioitinh = gioitinh;
            }
            public void Nhap()
            {
                Console.Write("Nhap ma sinh vien: ");
                Masv = Console.ReadLine();
                Console.Write("Nhap ho te sinh vien: ");
                Hoten = Console.ReadLine();
                Console.Write("Nhap ngay sinh sinh vien: ");
                Ngaysinh = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhap CCCD: ");
                CCCD = long.Parse(Console.ReadLine());
                Console.Write("Nhap Gioi tinh: ");
                Gioitinh = Console.ReadLine();
            }
            public void Xuat()
            {
                Console.WriteLine("Ma sinh vien:{0}", Masv);
                Console.WriteLine("Ho ten sinh vien:{0}", Hoten);
                Console.WriteLine("Ngay sinh sinh vien:{0}", Ngaysinh.ToString("dd/MM/yyyy"));
                Console.Write("CCCD:{0}", CCCD);
                Console.WriteLine("Nhap Gioi tinh:{0}", Gioitinh);
            }
        }//end struct sinhvien

        static void ArrayListCollection(sinhvien[] mang)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < mang.Length; i++)
                list.Add(mang[i]); // => list[vs1,vs2,vs3]

            list.Remove(mang[0]);// xóa theo đối tượng => list[vs2,vs3]
            list.RemoveAt(1);// xóa theo chỉ số =>list[vs2]
            sinhvien sv4 = new sinhvien("sv004", "Le van B", DateTime.Parse("2/2/2001"), 1234324, "Nu");

            list.Insert(1, sv4);// chèn => list[vs2,vs4]

            for (int i = 0; i < list.Count; i++)
                ((sinhvien)list[i]).Xuat();
        }


        static void StringCollection()
        {
            StringCollection collection = new StringCollection();
            collection.Add("Le Van A");
            collection.Add("Le Van B");
            collection.Add("Le Van C");
            collection.Add("Le Van D");
            collection.Add("Le Van E");

            foreach (string str in collection)// foreach (<kiểu dữ liệu> <tên biến> in <tập hợp>) 
                Console.WriteLine(str); // foreach có thể thay thế cho for
            Console.WriteLine("--------------------------------");
            collection.Remove("Le Van A");
            collection.RemoveAt(0);
            collection.Insert(0, "Le Van H");// chèn trước vị trí collection[0] hiện tại

            foreach (string str in collection)
                Console.WriteLine(str);
        }
        static void MyStringDictionary()
        {
            Console.WriteLine("tap hop StringDictionary:");
            StringDictionary strList = new StringDictionary(); // gồm có key và chuổi 
            strList.Add("A", "Ha Nam");// vd Key là "A" và chuổi là "Ha Nam"
            strList.Add("B", "Ha Giang");// lưu Ý*** Key không được trùng nhau
            strList.Add("C", "Ha Noi");
            Console.WriteLine("Danh sach gia tri truoc khi thao tac");
            foreach (string s in strList.Values) // duyệt qua từng giá trị
                Console.WriteLine(s);
            Console.WriteLine("--------------------------------");
            strList.Remove("B"); // xóa theo Key
            Console.WriteLine(strList["C"]);// in theo Key
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Danh sach gia tri sau khi thao tac");
            foreach (string s in strList.Values) // duyệt qua từng giá trị(value)
                Console.WriteLine(s);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Danh sach Key");
            foreach (string s in strList.Keys) // duyệt qua từng khóa(key)
                Console.WriteLine(s);
            Console.WriteLine("--------------------------------");
            foreach (DictionaryEntry d in strList) //dictionaryentry giúp thao tác trên tập hợp với Key và value là String
                Console.WriteLine("Key: {0} ==> Value: {1}", d.Key, d.Value);
            // Key: a ==> Value: Ha Nam
            // Key: c ==> Value: Ha Noi
        }

        static void MyStack()
        {
            Console.WriteLine("tập hợp Stack:");
            Stack objs = new Stack();
            objs.Push("Ha Giang");
            objs.Push("Ha Nam");
            objs.Push("Ha Noi");

            IEnumerator item = objs.GetEnumerator();
            while (item.MoveNext())// Movenext trả về giá trị True ban đầu và cuối cùng là False để thoát vòng lặp
                Console.WriteLine(item.Current);

            Console.WriteLine("------------------------------");
            while (objs.Count > 0)
                Console.WriteLine(objs.Pop());//pop lấy ra và xóa phần tử trong stack

            Console.WriteLine("-------------------------------");
            IEnumerator xuat = objs.GetEnumerator();
            while (xuat.MoveNext())
                Console.WriteLine(xuat.Current);
        }
        static void MyQueue()
        {
            Console.WriteLine("Collection Queue:");
            Queue objs = new Queue();
            objs.Enqueue("Ha Giang");
            objs.Enqueue("Ha Nam");
            objs.Enqueue("Ha Noi");

            IEnumerator item = objs.GetEnumerator();
            while (item.MoveNext())
                Console.WriteLine(item.Current);

            while (objs.Count > 0)
                Console.WriteLine(objs.Dequeue());

        }
        static void MyHashTable()
        {
            Console.WriteLine("Collection Hashtable:");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Ha Nam");
            hashtable.Add(2, "Ha Giang");
            hashtable.Add(3, "Ha Noi");

            Console.WriteLine("Key:");
            foreach (int key in hashtable.Keys) //xuất các khóa
                Console.WriteLine(key);

            Console.WriteLine("value:");
            foreach (string value in hashtable.Values) //xuất các value
                Console.WriteLine(value);

            IDictionaryEnumerator en = hashtable.GetEnumerator();
            while (en.MoveNext())
                Console.WriteLine("Key: {0} ==> Value: {1}",
                          en.Key, en.Value);
        }

        static void MySortedlist()
        {
            Console.WriteLine("Collection SortedList:");
            SortedList slist = new SortedList();
            slist.Add(2, "B");
            slist.Add(4, "D");
            slist.Add(3, "C");
            slist.Add(1, "A");

            foreach (string s in slist.Values) // duyệt qua các giá trị 
                Console.WriteLine(s);

            IDictionaryEnumerator en = slist.GetEnumerator();// IDictionaryEnumerator giúp thao tác lên tập hợp, sử dụng cho Key là int 
            // GeEnumerator giúp truy xuất vào kiểu dử liệu IDictionaryEnumerator
            while (en.MoveNext())
                Console.WriteLine("Key: {0} ==> Value: {1}",
                          en.Key, en.Value);
        }
        static void Main(string[] args)
        {
            sinhvien sv1;
            sv1.Masv = "sv011";
            sv1.Hoten = "le Van A";
            sv1.Gioitinh = "Nam";
            sv1.Ngaysinh = DateTime.Parse("1/1/1999");
            sv1.CCCD = 12243;
            sinhvien sv2 = new sinhvien("sv002", "Le van B", DateTime.Parse("2/2/2001"), 1234324, "Nu");
            sinhvien sv3 = new sinhvien("sv003", "Le van c", DateTime.Parse("2/2/2001"), 1234324, "Nu");
            sinhvien[] mang = { sv1, sv2, sv3 };
            //ArrayListCollection(mang);
            //StringCollection();
            //MyStringDictionary();

            MyStack();
            //MyQueue();

            //MySortedlist();
            //MyHashTable();
            Console.ReadKey();
        }
    }
}
