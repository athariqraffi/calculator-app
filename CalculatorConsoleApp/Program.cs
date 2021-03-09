using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)

        {
            kembali:
            Console.Clear();

            Console.Title = "Aplikasi Calculator";

            int pilih;

            Console.WriteLine("---------------------");
            Console.WriteLine("---Menu Kalkulator---");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Keluar");
            Console.WriteLine("---------------------");

            Console.Write("Pilih Menu (1 - 5) = ");
            pilih = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pilih > 5) {

                Console.WriteLine("Menu tidak tersedia!!");
                Console.ReadKey();
                goto kembali;

            } else if (pilih == 5) {

                Environment.Exit(0);

            } else {
                Console.Write("Masukkan Nilai A = ");
                int a = int.Parse(Console.ReadLine()); //proses casting (ngubah string menjadi int)

                Console.Write("Masukkan Nilai B = ");
                int b = int.Parse(Console.ReadLine()); //proses casting (ngubah string menjadi int)

                Console.WriteLine(); //tambahkan baris kosong

                switch (pilih) 
                {
                    case 1:
                        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                        break;

                    case 2:
                        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                        break;

                    case 3:
                        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                        break;

                    case 4:
                        Console.WriteLine("Hasil Perkalian {0} / {1} = {2}", a, b, Pembagian(a, b));
                        break;
                }
            }

            Console.ReadKey();
            goto kembali;
        }

    }
}

