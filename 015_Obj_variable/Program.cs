class Program
{
    static void Main(string[] args)
    {

        int sayi = 5;
        string str = "yazi";

        object objSayi = 10;       //boxing
        object objStr = "yazi2";  //her veri tipi objeden türer.


        Console.WriteLine(sayi * 2);
        Console.WriteLine(str.ToUpper());
        Console.WriteLine("------------------");

        int sayi2 = (int)objSayi;     //unboxing (objeden çıkararak çarpma vs yapabildik. Obje halinde yapamayız.)
        string str2 = (string)objStr;  //mümkün mertebe unboxing yapmayacak şekilde kodlamak gerekir. İşlemciyi yorar,maliyetlidir.

        Console.WriteLine(sayi2*2);
        Console.WriteLine(str2.ToUpper());

    }
}
