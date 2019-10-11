using System;

namespace Arrayer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperature = new double[]{ 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
            Console.WriteLine("average temperature: " + Average(temperature)); 
        }
        static double Average(double[] a)
        {
            double summa = 0;
            for(int i = 0; i < a.Length; i++)
            {
                summa += a[i];
            }
            double Average = summa / a.Length;
            return (Math.Round(Average, 1));
        }
    }
}
