using System;
using System.Runtime.CompilerServices;

public class TestCode
{    
    static void errorMsg()
    {
        Console.WriteLine("Input error !!!");
        Console.ReadLine();
        MainMenu();
    }

    static void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Main Menu\n");
        Console.WriteLine("Pilih jenis operasi");
        
        Console.WriteLine("1. Looping");
        Console.WriteLine("2. Tahun Kabisat");
        Console.WriteLine("3. FizzBuzz Code Test");
        Console.WriteLine("4. Palindrome Test");
        Console.WriteLine("5. ");

        Console.WriteLine("");
        Console.WriteLine("0. Keluar");
        string pilih = Console.ReadLine();
        switch (pilih)
        {
            case "0": exit(); break;
            case "1": loopingIntro(); break;
            case "2": tahunKabisat(); break;
            case "3": fizzBuzz(); break;
            case "4": palindrome(); break;
            default: errorMsg(); break;
        }
    }

    static void loopingIntro()
    {

        Console.Clear();
        Console.WriteLine("Looping\n");
        Console.WriteLine("Halaman ini akan memberikan hasil seperti ini");
        Console.WriteLine("Jika panjang angka adalah 5, maka hasilnya :");
        for (int i = 1; i <= 5; i++)
        {
            for (int a = 1; a <= i; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine(", ");
        }
        Console.WriteLine("");
        Console.WriteLine("Ingin menggunakan operasi ini ?");
        Console.WriteLine("1. Ya");
        Console.WriteLine("2. Kembali ke menu");
        string pilih = Console.ReadLine();
        switch (pilih)
        {
            case "1": looping(); break;
            case "2": MainMenu(); break;
                default: loopingIntro(); break;
        }
    }

    static void looping()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Masukkan panjang angka (contoh: 10)");
            int panjang = Convert.ToInt32(Console.ReadLine());
            if (panjang == 0)
            {
                Console.WriteLine("angka 0 tidak memilikin panjang");
            }
            else
            {
                for (int i = 1; i <= panjang; i++)
                {
                    for (int a = 1; a <= i; a++)
                    {
                        Console.Write(a + " ");
                    }
                    Console.WriteLine(", ");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("1. Ulangi operasi ini?");
            Console.WriteLine("2. Kembali ke main menu");

            Console.WriteLine("");
            Console.WriteLine("0. Keluar");
            string pilih = Console.ReadLine();
            switch (pilih)
            {
                case "0": exit(); break;
                case "1": looping(); break;
                case "2": MainMenu(); break;
                default: MainMenu(); break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            looping();
        }        
    }

    static void tahunKabisat()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Tahun Kabisat Test Code\n");
            Console.Write("Masukkan tahun: ");
            int tahun = Convert.ToInt32(Console.ReadLine());
            if (tahun % 400 == 0)
            {
                Console.Write("Tahun " + tahun + " adalah kabisat\n");
            }
            else if (tahun % 100 == 0)
            {
                Console.Write("Tahun " + tahun + " bukan kabisat\n");
            }
            else if (tahun % 4 == 0) //4 pengecilan dari 400
            {
                Console.Write("Tahun " + tahun + " adalah kabisat\n");
            }
            else
            {
                Console.Write("Tahun " + tahun + " bukan kabisat\n");
            }

            Console.WriteLine("");
            Console.WriteLine("1. Ulangi operasi ini?");
            Console.WriteLine("2. Kembali ke main menu");

            Console.WriteLine("");
            Console.WriteLine("0. Keluar");
            string pilih = Console.ReadLine();
            switch (pilih)
            {
                case "0": exit(); break;
                case "1": tahunKabisat(); break;
                case "2": MainMenu(); break;
                default: MainMenu(); break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            tahunKabisat();
        }        
    }

    static void fizzBuzz()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("FizzBuzz Code Test\n");
            Console.WriteLine("Masukkan jumlah angka (Contoh: 50) ");
            int angka = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= angka; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("1. Ulangi operasi ini?");
            Console.WriteLine("2. Kembali ke main menu");

            Console.WriteLine("");
            Console.WriteLine("0. Keluar");
            string pilih = Console.ReadLine();
            switch (pilih)
            {
                case "0": exit(); break;
                case "1": fizzBuzz(); break;
                case "2": MainMenu(); break;
                default: MainMenu(); break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            fizzBuzz();
        }        
    }

    static void palindrome()
    {
        Console.Clear();
        Console.WriteLine("Palindrome Test\n");
        Console.Write("Masukkan kata atau angka : ");
        string input = Console.ReadLine().ToUpper().Trim().Replace(" ", string.Empty).Replace("i", "I");
        string temp = "";
        temp.ToUpper().Trim().Replace(" ", string.Empty.Replace("i", "I"));
        for (int i = input.Length - 1; i >= 0; i--)
        {
            temp += input[i];
        }
        Console.WriteLine("Kata = " + input);
        Console.WriteLine("Hasil = " + temp);
        if (temp == input)
        {
            Console.WriteLine(input + " adalah palindrome");
        }
        else
        {
            Console.WriteLine(input + " bukan palindrome");
        }
        Console.WriteLine("");
        Console.WriteLine("1. Ulangi operasi ini?");
        Console.WriteLine("2. Kembali ke main menu");

        Console.WriteLine("");
        Console.WriteLine("0. Keluar");
        string pilih = Console.ReadLine();
        switch (pilih)
        {
            case "0": exit(); break;
            case "1": palindrome(); break;
            case "2": MainMenu(); break;
            default: MainMenu(); break;
        }
    }

    static void exit()
    {

    }

    static void Main(string[] args)
    {
        MainMenu();
    }
}