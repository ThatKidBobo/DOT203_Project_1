
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

        while (islemtamam == false)
        {
            Console.Write("Sayı gir: ");
            deger = Console.ReadLine();

            if (int.TryParse(deger, out sayi))
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sayı çifttir.");
                    islemtamam = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sayı tektir.");
                    islemtamam = true;
                }
            }
            else if (islemtamam == false)
            {
                Console.WriteLine("Lütfen sayı girin.");
            }
        }
    }
}