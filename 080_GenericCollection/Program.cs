abstract class Sekil2B
{
    public abstract int AlanHesapla();
    public abstract int CevreHesapla();

    public virtual void Hakkinda()
    {
        Console.WriteLine($"Alan = {AlanHesapla()}, Cevre = {CevreHesapla()}");
    }
}

class Kare : Sekil2B
{
    public int Kenar { get; set; }
    public override int AlanHesapla()
    {
        return Kenar * Kenar;
    }
    public override int CevreHesapla()
    {
        return 4 * Kenar;
    }
    public override void Hakkinda()
    {
        Console.WriteLine($"Kenar = {Kenar}, Alan = {AlanHesapla()}, Cevre = {CevreHesapla()}");
    }

}
class Dortgen : Sekil2B
{
    public int Kenar1 { get; set; }
    public int Kenar2 { get; set; }

    public override int AlanHesapla()
    {
        return Kenar1 * Kenar2;
    }

    public override int CevreHesapla()
    {
        return 2 * (Kenar1 + Kenar2);
    }
    public override void Hakkinda()
    {
        Console.WriteLine($"Kenar1 = {Kenar1}, Kenar2 = {Kenar2}, Alan = {AlanHesapla()}, Cevre = {CevreHesapla()}");
    }
}
class Sekiller
{
    private List<Sekil2B> _items = new List<Sekil2B>();

    public void Ekle(Sekil2B sekil)
    {
        _items.Add(sekil);
        Console.WriteLine("sekil eklendi");
    }
    public void Listele()
    {
        Console.WriteLine($"Koleksiyonda {_items.Count} tane şekil var");
        Console.WriteLine("--------------------------------------");
        foreach (var item in _items)
        {
            item.Hakkinda();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var kare1 = new Kare { Kenar = 5 };
        var kare2 = new Kare { Kenar = 7 };

        var dortgen1 = new Dortgen { Kenar1 = 5, Kenar2 = 10 };
        var dortgen2 = new Dortgen { Kenar1 = 7, Kenar2 = 12 };

        Sekiller sekiller = new Sekiller();
        sekiller.Ekle(kare1);
        sekiller.Ekle(kare2);
        sekiller.Ekle(dortgen1);

        sekiller.Listele();

    }
}
