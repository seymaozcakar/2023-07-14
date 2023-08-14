using System.Collections;

class Program
    {
        static void Main(string[] args)
        {
        int[] sayilar = {111,222,3333 };
        string[] isimler = {"lizge","özge","şeyma" };

        ArrayList list= new ArrayList();
        list.Add(1);            //Add-objecttir.Her veri tipini kapsar.
        list.Add(true);
        list.Add("Şeyma");
        list.Add(3.14);
        list.AddRange(sayilar); //bir diziyi ilave edebiliyoruz.
        list.Add("-------------------");
        list.AddRange(isimler);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]); 
        }
        Console.WriteLine("*********************");
        Console.WriteLine(list[3]);
        Console.WriteLine();
        Console.WriteLine();

        list.Remove(true);
        list.Remove("Şeyma");
        list.RemoveAt(3); //3 indeksinde olanı  sil.

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

    }
    }
