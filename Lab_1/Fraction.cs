using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Fraction
    {
        private double numerator { get; set; }      //licznik
        private double denominator { get; set; }     //mianownik

        //konstruktor
        public Fraction()
        {
            numerator = 1;
            denominator = 2;
        }

        //konstruktor dwu argumentowy
        public Fraction(double numerator, double denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        //konstruktor kopiujący
        public Fraction(Fraction previousFraction)
        {
            numerator = previousFraction.numerator;
            denominator = previousFraction.denominator;
        }

        public override string ToString()
        {
            return $"Numerator: {numerator}, denominator: {denominator}";
        }

        public static Fraction operator +(Fraction x1) => x1;
        public static Fraction operator -(Fraction x1) => new Fraction(-x1.numerator, x1.denominator);
        public static Fraction operator +(Fraction x1, Fraction x2) => new Fraction(x1.numerator * x2.denominator + x2.numerator * x1.denominator, x1.denominator * x2.denominator);
        public static Fraction operator -(Fraction x1, Fraction x2) => new Fraction(x1.numerator * x2.denominator - x2.numerator * x1.denominator, x1.denominator * x2.denominator);
        public static Fraction operator *(Fraction x1, Fraction x2) => new Fraction(x1.numerator * x2.numerator, x1.denominator * x2.denominator);
        public static Fraction operator /(Fraction x1, Fraction x2) => new Fraction(x1.numerator * x2.denominator, x2.denominator * x1.numerator);

    }
}
