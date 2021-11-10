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
            int? max = null;
            int? second = null;
            int? integer = null;
            for(int i = 0; i < n; i++){
                integer = GetInt();
                if(integer is not null){
                    if (max is null || integer > max){
                        second = max;
                        max = integer;
                    }
                    else if (integer < max && (second is null || integer > second)){
                        second = integer;
                    }
                }
            }
            if (second is null) 
                Console.WriteLine("brak rozwiązania");
            else
                Console.WriteLine($"Szukana liczba: {second}");
        }
        static int? GetInt()
        {
            int? integer = null;
            bool negative = false;
            int n;
            do{
                n = Console.Read();
                if(n == '-')
                    negative = true;
            } while (n == ' ' || n == '\t' || n == '\n' || n == 13 || n == '-');
            while (n >= '0' && n <= '9')
            {
                if(integer is null) integer = 0;
                integer = integer * 10 + n - '0';
                n = Console.Read();
            }

            if(negative)
                integer *= -1;
            return integer;
        }
    }
}
