using System;
using System.ComponentModel;

namespace PU
{
    class Program
    {
        static void Main(string[] args) 
        { 
            List<double> list = new List<double>();
            list.Add(1.212);
            list.Add(1.793);
            list.Add(3.123);
            list.Add(54.3452);
            list.Add(8.55);
            Console.WriteLine("5 stycken double i en lista");
            foreach (double d in list) 
            {
                Console.WriteLine(d);
            }
            list.RemoveAt(3);
            Console.WriteLine();
            Console.WriteLine("Efter borttagning av index nummer 3");
            foreach (double d in list) 
            { 
                Console.WriteLine(d);
            }
            double average = medelvärde(list);
            Console.WriteLine();
            Console.WriteLine("medelvärdet av alla double i listan är: "+ average);
            Console.ReadKey();
        }
        static double medelvärde(List<double>list) 
        {
            double sum = 0;
            foreach(double d in list)
            {
                sum += d;
            }
            double average = sum / list.Count;
            return average;
        }
    }
}