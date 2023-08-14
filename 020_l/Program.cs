using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 12, 45, 78, 96 };
            string[] isimler = {"aa","bb","cc" };
            ArrayList list = new ArrayList();
            list.Add("aaaa");
            list.Add("bbbb");
            list.Add(1);
            list.Add("cccc");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("---------------------");

            foreach (var item in list)  //(foreach=herbir öge için)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
