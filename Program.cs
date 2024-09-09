using System;
using System.Collections.Generic;

namespace PozitifNegatifAyirma
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sayilar = new List<int>();
            var pozitif = 0;
            var negatif = 0;

            var donguKontrolu = true;
            do
            {
                Console.Write($"{sayilar.Count + 1}. sayı: ");
                var satir = Console.ReadLine();
                donguKontrolu = int.TryParse(satir, out var sayi);

                if (!donguKontrolu) continue;

                sayilar.Add(sayi);

                if (sayi > 0)
                    pozitif++;
                else if (sayi < 0)
                    negatif++;
            } while (donguKontrolu);

            Console.WriteLine($"Girilen sayı sayısı: {sayilar.Count}");
            Console.WriteLine($"Pozitif sayı sayısı: {pozitif}");
            Console.WriteLine($"Negatif sayı sayısı: {negatif}");
            Console.ReadKey();
        }
    }
}
