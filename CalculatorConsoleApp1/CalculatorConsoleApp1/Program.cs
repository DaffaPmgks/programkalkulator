namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            //pemilihan menu
            Console.WriteLine("Pilihan Menu");
            Console.WriteLine("\n1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Silahkan tentukan Pilihan Anda : ");
            int menu = int.Parse(Console.ReadLine());

            switch(menu <= 1 && menu >= 4) { 
            
            case 1:
                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                break;








                    Console.WriteLine("\nTekan Sembarang key untuk keluar");
            Console.ReadKey();
        }

            /*int a = 10; //deklarasi variabel a, dengan nilai awal 10;
            int b = 6; //deklarasi variabel b, dengan nilai awal 6;

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));*/

            
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
        // TODO: tambahkan method untuk Perkalian dan Pembagian
    }
}