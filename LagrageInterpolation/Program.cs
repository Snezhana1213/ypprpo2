using System;
using System.Collections.Generic;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace LagrangeInterpolation;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string xv = Console.ReadLine();
            string yv = Console.ReadLine();
            string xi = Console.ReadLine();
            // Вывод результатов
            Console.WriteLine("xv: " + xv);
            Console.WriteLine("yv: " + yv);
            Console.WriteLine("xi: " + xi);
            
            List<double> x_list = new List<double>() {double.Parse(xv)};
            List<double> y_list = new List<double>() {double.Parse(yv)};

            double interpolatedValue = LagrangeInterpolation.Lagrange(x_list, y_list, double.Parse(xi));
            Console.WriteLine($"The value of the interpolation polynomial at a point {xi}: {interpolatedValue}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}