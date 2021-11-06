using System;

namespace zad1Project
{

    public class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c;
            Console.Write("Enter a value: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b value: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c value: ");
            c = Convert.ToDouble(Console.ReadLine());
            
            var (x1, x2) = Program.Calc(a, b, c);
            Program.Print(a, b, c, x1, x2);
        }

        static public (Double?, Double?) Calc(Double a, Double b, Double c)
        {
            Double? x1 = null;
            Double? x2 = null;

            if(a == 0){
                if (b != 0) x1 = -c / b;
            }
            else{
                Double delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    x1 = (-b) / (2 * a);
                }
                else if (delta > 0)
                {
                    Double deltaSqrt = Math.Sqrt(delta);
                    x1 = (-b - deltaSqrt) / (2 * a);
                    x2 = (-b + deltaSqrt) / (2 * a);
                }
            }
            
            return (x1, x2);
        }

        static public void Print(Double a, Double b, Double c, Double? x1, Double? x2)
        {
            Console.Clear();
            Console.Write("Results for");
            if (a != 0) 
                Console.Write($" {(a < 0 ? "-" : "")} {Math.Abs(a)}x^2");
            if (b != 0) 
                Console.Write($" {(b < 0 ? "-" : (a != 0 ? "+" : ""))} {Math.Abs(b)}x");
            if (c != 0) 
                Console.Write($" {(c < 0 ? "-" : ((b != 0 || a != 0) ? "+" : ""))} {Math.Abs(c)}");
            Console.WriteLine(" = 0: ");
            if(x2 is null){
                if (x1 is null) 
                    Console.WriteLine("Not found");
                else 
                    Console.WriteLine("x1 = {0} {1:F5}", x1 < 0 ? "-" : "", Math.Abs((double)x1));
            }
            else{
                Console.WriteLine($"x1 = {(x1 < 0 ? "-" : "")} {Math.Abs((double)x1):0.#####}");
                Console.WriteLine($"x2 = {(x2 < 0 ? "-" : "")} {Math.Abs((double)x2):0.#####}");
            }
        }
    }
}
