interface ISekil2B
{
    int AlanHesapla();
    int CevreHesapla();

    void Hakkinda();
}

class Kare : ISekil2B
{
    public int Kenar { get; set; }
    public int CevreHesapla()
    {
        return 4 * Kenar;
    }
    public int AlanHesapla()
    {
        return Kenar * Kenar;
    }
    public void Hakkinda()
    {
        Console.WriteLine($"Kenar = {Kenar}, Alan = {AlanHesapla()}, Cevre = {CevreHesapla()}");
    }
}

class Dortgen : ISekil2B
{
    public int Kenar1 { get; set; }
    public int Kenar2 { get; set; }

    public int AlanHesapla()
    {
        return Kenar1 * Kenar2;
    }
    public int CevreHesapla()
    {
        return 2 * (Kenar1 + Kenar2);
    }
    public void Hakkinda()
    {
        Console.WriteLine($"Kenar1 = {Kenar1}, Kenar2 = {Kenar2}, Alan = {AlanHesapla()}, Cevre = {CevreHesapla()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kare kare = new Kare() { Kenar = 5 };
        Dortgen dortgen = new Dortgen() { Kenar1 = 5, Kenar2 = 7 };

        ISekil2B sekil1 = new Kare { Kenar = 12 };

        List<ISekil2B> sekiller = new List<ISekil2B>();
        sekiller.Add(kare);
        sekiller.Add(dortgen);
        sekiller.Add(sekil1);

        foreach (var sekil in sekiller)
        {
            sekil.Hakkinda();
        }


    }
}
