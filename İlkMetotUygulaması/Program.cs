using System;

class Program
{
    static void YazdirSarkiSozu()
    {
        Console.WriteLine("Uzun İnce Bir Yoldayım");
    }

    static int RastgeleSayiKalan()
    {
        Random rastgele = new Random();
        return rastgele.Next() % 2;
    }

    static int Carpma(int a, int b)
    {
        return a * b;
    }

    static void Hosgeldiniz(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }

    static void Main(string[] args)
    {
        YazdirSarkiSozu();
        Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {RastgeleSayiKalan()}");
        Console.WriteLine($"3 ve 8'nin çarpımı: {Carpma(3, 8)}");
        Hosgeldiniz("Fatih", "Sezgin");
    }
}
