using System;

namespace ConsoleApp1
{
    class Program
    {
        class Fraction : IEquatable<Fraction>, IComparable<Fraction>
        {


            private int numerator { get; set; }   //licznik
            private int denominator { get; set; }  //mianownik

            public int c_denominator { get => denominator; }
            public int c_numerator { get => numerator; }

            //konstruktor
            public Fraction() //konstruktor domyślny
            {
                numerator = 1;
                denominator = 2;

            }

            //konstrukotr 2 argumentowy
            public Fraction(int x, int y)
            {
                numerator = x;
                denominator = y;
            }

            //konstruktor kopiujący

            public Fraction(Fraction copyFraction)
            {
                copyFraction.numerator = numerator;
                copyFraction.denominator = denominator;
            }

            //uzycie metody ToString()

            public override string ToString()
            {
                return $"{numerator}/{denominator}";
            }

            public int CompareTo(Fraction other)
            {
                return (this - other).numerator;
            }

            public bool Equals(Fraction other)
            {
                return this.denominator == other.denominator && denominator == other.denominator;
            }

            //dodwanaie jednego ulamka
            public static Fraction operator +(Fraction a) => a;

            //odejmowanie jednego ulamka

            public static Fraction operator -(Fraction a) => new Fraction(-a.numerator, a.denominator);

            //dodawanie wielu ulamkow
            public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);


            //odejmowanie wielu ulamkow
            //public static Fraction operator -(Fraction a, Fraction b) => new Fraction(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
            public static Fraction operator -(Fraction a, Fraction b) => a + (-b);

            //mnozenie
            public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);

            //dzielenie
            public static Fraction operator /(Fraction a, Fraction b)
            {
                if(b.numerator == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
            }


            //zaokraglenie w gore
            public double RoundDown()
            {
                double toRound = (double)this.numerator / (double)this.denominator;
                double roundDown = toRound % 1;
                toRound = toRound - roundDown;
                return toRound;

            }


            //zaokraglenie w dol
            public double RoundUp()
            {

                double toRound = (double)this.numerator / (double)this.denominator;
                double roundUP = toRound % 1;
                roundUP = roundUP - toRound;
                if(roundUP >=0)
                {
                    toRound = +1;
                }
                else
                {
                    toRound -= 1;
                }
                return toRound;

            }




        }
            static void Main(string[] args)
            {




            var a = new Fraction(3, 7);
            var b = new Fraction(2, 5);
            Console.WriteLine(a + b);

            Fraction fraction = new Fraction(1, 2);
           bool x = fraction.Equals(new Fraction(1, 2));
            //Console.WriteLine(x);

            Fraction fraction2 = new Fraction(1, 1);
            int y = fraction2.CompareTo(new Fraction(1, 5));
            //Console.WriteLine(y);


            Fraction fraction3 = new Fraction(3, 4);
            double test = fraction3.RoundDown();

            Console.WriteLine(test);

        }
        }
    }

