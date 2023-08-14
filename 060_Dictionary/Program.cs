//Dictionary-->Hastable'ın Generic olan halidir.

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(6, "ankara");
        dic.Add(10, "bursa");
        dic.Add(34, "istanbul");

        ShowDic(dic);

        dic[10] = "balıkesir";
        dic.Add(16, "bursa");

        if (dic.ContainsKey(34))
        {
            Console.WriteLine("34 numaralı şehir kayıtlı");
            Console.WriteLine("--->" + dic[34]);
        }
        if (dic.ContainsKey(35))
        {
            Console.WriteLine("35 numaralı şehir kayıtlı");
            Console.WriteLine("--->" + dic[35]);
        }
        else
        {
            dic.Add(35, "izmir");
            Console.WriteLine("izmir eklendi");
        }


        Console.WriteLine("----------------------------");
        ShowDic(dic);

    }

    private static void ShowDic(Dictionary<int, string> dic)
    {
        foreach (int key in dic.Keys)
        {
            Console.WriteLine($"{key}- {dic[key]}");
        }
    }
}
