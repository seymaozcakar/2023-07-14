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

class Program
{
    static void Main(string[] args)
    {
        Kare kare1 = new Kare { Kenar = 5 };
        Kare kare2 = new Kare { Kenar = 7 };

        var dortgen1 = new Dortgen { Kenar1 = 5, Kenar2 = 10 };
        var dortgen2 = new Dortgen { Kenar1 = 7, Kenar2 = 12 };

        List<Sekil2B> sekiller = new List<Sekil2B>();

        sekiller.Add(dortgen1);
        sekiller.Add(dortgen2);
        sekiller.Add(kare1);
        sekiller.Add(kare2);

        foreach (var sekil in sekiller)
        {
            sekil.Hakkinda();
        }

    }
}
