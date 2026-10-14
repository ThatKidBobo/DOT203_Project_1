
using System;

class SayiKontrol
{
    static void Main(string[] args)
    {
        SayiKontrol kontrol = new SayiKontrol();
        kontrol.Calistir();
    }

    public void Calistir()
    {
        string deger = "";
        int sayi;
        bool islemtamam = false;

        Console.WriteLine("Hoşgeldiniz, bir sayı girin veya N tuşu ile çıkın.");

        while (islemtamam == false)
        {
            Console.WriteLine("");
            Console.WriteLine("Sayı gir: ");
            deger = Console.ReadLine();

            if (deger.ToUpper() == "N")
            {
                Console.WriteLine("İşlem sonlandırılıyor...");
                Environment.Exit(0);
            }
            else if (int.TryParse(deger, out sayi))
            {
                CiftTekKontrol(sayi, ref islemtamam);
            }
            else if (islemtamam == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Lütfen sayı girin.");
            }
        }
    }

    public void CiftTekKontrol(int girileceksayi, ref bool donenislemtamam)
    {
        if (girileceksayi % 2 == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Sayı çifttir.");
            donenislemtamam = true;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sayı tektir.");
            donenislemtamam = true;
        }
    }
}