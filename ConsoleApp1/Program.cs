using System.Collections.Generic;

class Kisi : Object
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
}
class Kitap
{
    public string Adi { get; set; }
    public int Sayfa { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<string> isimler = new List<string>();
        List<int> sayilar = new List<int>();
        List<Kisi> kisiler = new List<Kisi>();
        var kitaplar = new List<Kitap>();

        var kitap = new Kitap() { Adi = "matematik", Sayfa = 123 };
        var kitap2 = new Kitap() { Adi = "felsefe", Sayfa = 1230 };

        kitaplar.Add(kitap);
        kitaplar.Add(kitap2);
        kitaplar.Add(kitap2);

        foreach (var item in kitaplar)
        {
            Console.WriteLine($"{item.Adi} - {item.Sayfa} sayfa");
        }
        Console.WriteLine("-----------------------------");

        isimler.Add("ismail");
        isimler.Add("arda");
        isimler.Add("lizge");

        sayilar.AddRange(new int[] { 12, 45, 55 });
        sayilar.Add(10);

        kisiler.Add(new Kisi { Adi = "Berat", Soyadi = "Genç" });
        kisiler.Add(new Kisi { Adi = "Özge", Soyadi = "Doblan" });

        foreach (var item in sayilar)
        {
            Console.WriteLine(item * 20);
        }
        Console.WriteLine("----------------");
        foreach (var item in isimler)
        {
            Console.WriteLine(item.ToUpper());
        }
        Console.WriteLine("----------------");
        foreach (var item in kisiler)
        {
            Console.WriteLine(item.Adi);
        }
    }
}

