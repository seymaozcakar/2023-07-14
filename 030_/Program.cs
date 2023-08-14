using System.Collections;

class Kitap
{
    public string Adi { get; set; }
    public int Sayfa { get; set; }
    public override string ToString()
    {
        return Adi + " - " + Sayfa;
    }
}
class Kisi //:object (yazmasakta var.)
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public override string ToString()
    {
        return base.ToString();  //obje sınıfına ait tostring virtualdır.(f12ye basarak tanımlanan yere gidebilirsin.)
    }

}

class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        Kisi kisi1 = new Kisi { Adi = "İsmail", Soyadi = "Türkmen" };
        var kisi2 = new Kisi { Adi = "Arda", Soyadi = "Büyükdoluca" };

        var kitap1 = new Kitap { Adi = "Olasılık", Sayfa = 123 };
        var kitap2 = new Kitap { Adi = "Matematik", Sayfa = 456 };

        list.Add(kisi1);
        list.Add(kisi2);
        list.Add(123);
        list.Add("Hi!");

        list.Add(kitap1);
        list.Add(kitap2);

        //foreach (var item in list)
        //{
        //    Console.WriteLine(item.ToString()); //item.tostring yazmasak da tostring var.
        //}

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------");

        foreach (var item in list)
        {
            if (item is Kisi)
            {
                Kisi siradakiKisi = (Kisi)item;
                Console.WriteLine(siradakiKisi.Adi);
            }
            else if (item is Kitap)
                Console.WriteLine("==>" + item);
            else
                Console.WriteLine("-->" + item);


        }
        Console.WriteLine("-------------");
        Console.WriteLine(kisi1);
    }

}
    
