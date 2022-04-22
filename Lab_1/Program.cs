using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction x1 = new Fraction();
            Fraction x2 = new Fraction(1, 4);
            Console.WriteLine(x1); Console.WriteLine(x2); Console.WriteLine();
            Console.WriteLine(-x1);
            Console.WriteLine(x1+x2);

        }
        string Konstruktory()
        {
            //Żeby działało trzeba przekopiować do main
            Fraction x2 = new Fraction();
            Console.WriteLine(x2);

            Fraction f2 = new Fraction(5, 7);
            Console.WriteLine(f2);

            Fraction x3 = new Fraction(f2);
            Console.WriteLine(x3);
            return "";
        }
    }
}
