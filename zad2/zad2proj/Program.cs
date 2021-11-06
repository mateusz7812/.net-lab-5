using System;
using System.Collections.Generic;

namespace zad2proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int n = Int32.Parse(Console.ReadLine());
            int max = -1;
            int second = -1;
            int integer = 0;
            for(int i = 0; i < n; i++){
                integer = GetInt();
                if (integer > max){
                    second = max;
                    max = integer;
                }
                else if (integer < max && integer > second){
                    second = integer;
                }
            }
            if (second == -1) 
                Console.WriteLine("brak rozwiązania");
            else
                Console.WriteLine($"Szukana liczba: {second}");
        }
        static int GetInt()
        {
            int integer = 0;
            int n = Console.Read();
            while (n == ' ' || n == '\t' || n == '\n' || n == 13)
                n = Console.Read();
            while (n >= '0' && n <= '9')
            {
                integer = integer * 10 + n - '0';
                n = Console.Read();
            }
            return integer;
        }
    }
}
