using System;

namespace Days_5
{
    public class CalculadeMachine
    {

        public int Topla(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Cikar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Carp(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Bol(int num1, int num2)
        {
            if (num2 == 0 || num1 == 0)
            {
                Console.WriteLine("Bölen sıfır olamaz.");
                return double.NaN; // Not a Number
            }
            return (double)num1 / num2;
        }

    }
}
