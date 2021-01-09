using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizidekiDegerinIndeksiniDondurme
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string[] Sehirler = { "Eskişehir", "İstanbul", "Ankara", "İzmir", "Ankara", "Diyarbakır", "Sinop" };
                Console.WriteLine("Bir şehir giriniz");
                string girilenSehir = Console.ReadLine(); // kullanıcıdan şehir değerini alıyoruz
                bool varMi = true; // flag tanımlıyoruz ve değerine true atıyoruz
                for (int i = 0; i < Sehirler.Length; i++) // dizinin indeks değerini döndürmek için for döngüsü kullanıyoruz
                {
                    if (Sehirler[i] == girilenSehir)
                    {
                        varMi = false; // girilen şehir dizi içinde bulunduğunda flag değerini false yapıyoruz
                        Console.WriteLine("Girilen şehir dizinin " + i + ". indeksinde tutulmaktadır. ");
                        break; // girilen şehiri dizide bulduğumuz için döngüden çıkıyoruz
                    }
                }
                if (varMi) // girilen şehir dizide yoksa flag değeri true kalır
                {
                    Console.WriteLine(girilenSehir + " dizide yok.");
                }
           
            Console.ReadKey();
        }
    }
}
