//interface'de access modif. yoktur. Çünkü her şey zaten sadece publictir.

interface IKisi
{
    string Adi { get; set; }
    string Soyadi { get; set; }

    void MaasAl();
}

class Kisi : IKisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }

    private int ToplamParasi = 1000;
    private int Maas;

    public void MaasAl()
    {
        ToplamParasi += Maas;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi = new Kisi();
    }
}
