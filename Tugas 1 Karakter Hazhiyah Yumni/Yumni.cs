using System;

namespace Tugas_1_Karakter_Hazhiyah_Yumni
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            String ulang = "";
            do
            {
                Console.Write("Masukan karakter :");
                //konversi dari tipe string ke integer
                karakter = Convert.ToChar(Console.ReadLine());

                if (karakter >= 'a' && karakter <= 'z')
                {
                    Console.WriteLine(karakter + " adalah huruf kecil");
                    Console.WriteLine("Ingin mengecek karakter lagi? \n Ketik y atau Y untuk melanjutkan");
                    ulang = Convert.ToString(Console.ReadLine());
                }
                else if (karakter >= 'A' && karakter <= 'B')
                {
                    Console.WriteLine(karakter + " adalah huruf kapital");
                    Console.WriteLine("Ingin mengecek karakter lagi? \n Ketik y atau Y untuk melanjutkan");
                    ulang = Convert.ToString(Console.ReadLine());
                }
                else if (karakter >= '0' && karakter <= '9')
                {
                    Console.WriteLine(karakter + " adalah digit");
                    Console.WriteLine("Ingin mengecek karakter lagi? \n Ketik y atau Y untuk melanjutkan");
                    ulang = Convert.ToString(Console.ReadLine());
                }
                else if (karakter == ' ')
                {
                    Console.WriteLine(karakter + " adalah spasi");
                    Console.WriteLine("Ingin mengecek karakter lagi? \n Ketik y atau Y untuk melanjutkan");
                    ulang = Convert.ToString(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(karakter + " adalah karakter khusus\n ");
                    Console.WriteLine("Ingin mengecek karakter lagi? \n Ketik y atau Y untuk melanjutkan");
                    ulang = Convert.ToString(Console.ReadLine());
                }
            } while (ulang == "y" || ulang == "Y");
        }
    }
}
