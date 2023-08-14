using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();  //Key-Value adı:"arda"
        ht.Add("06", "Ankara");
        ht.Add("34", "İstanbul");
        ht.Add("10", "Bursa"); //yeni eklemek için
        
        ShowHashtable(ht);
        Console.WriteLine("--------------------");
        ht["10"] = "Balıkesir";      // varsa değiştirir,yoksa ekler.
        ht["16"] = "Bursa";         //ht.Add("16","Bursa"); bununla aynı işi yapıyor.
        Console.WriteLine(ht["10"]); //key ile çağırılır.
        Console.WriteLine("---------------------");
        ShowHashtable(ht);

    }

    private static void ShowHashtable(Hashtable ht)
    {
        foreach (var key in ht.Keys)
        {
            Console.Write(key);
            Console.WriteLine(" - " + ht[key]);
            Console.WriteLine();
        }
    }
}
//indeks numarası yerine key ile değerlere erişiyoruz.
//aynı anahtar ile ikinci bir ekleme yapılamaz. Her anahtar tek olmak zorundadır.(unic)
