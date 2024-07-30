using System;

namespace IfElsePratik
{
    class Program
    {        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayi giriniz:");
            int number = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan aldığımız string değeri int'e çeviriyoruz
            if (number > 10) // number değeri 10'dan büyükse bu koşul çalışır.
            {
                Console.WriteLine("Girilen sayi 10'dan büyüktür."); 
                if (number % 2 == 0) // number değerinin modülüs bölümünden kalanı 0 ise bu koşul çalışır.
                    Console.WriteLine("Girilen sayi çifttir.");
                else // number değerinin modülüs bölümünden kalanı 0'dan farklı ise bu koşul çalışır.
                    Console.WriteLine("Girilen sayi tektir.");
            }

            else if (number == 10) // number değeri 10'a eşitse bu koşul çalışır.
            {
                Console.WriteLine("Girilen sayi 10'a eşittir.");
                if (number % 2 == 0) // number değerinin modülüs bölümünden kalanı 0 ise bu koşul çalışır.
                    Console.WriteLine("Girilen sayi çifttir.");
                else // number değerinin modülüs bölümünden kalanı 0'dan farklı ise bu koşul çalışır.
                    Console.WriteLine("Girilen sayi tektir.");
            }
            else // number değeri 10'dan küçükse bu koşul çalışır.
            {
                Console.WriteLine("Girilen sayi 10'dan küçüktür.");
                if (number % 2 == 0) // number değerinin modülüs bölümünden kalanı 0 ise bu koşul çalışır.
                    Console.WriteLine("Girilen sayi çifttir.");
                else // number değerinin modülüs bölümünden kalanı 0'dan farklı ise bu koşul çalışır.
                    Console.WriteLine("Girilen sayi tektir.");
            }
        }
    }       
}




