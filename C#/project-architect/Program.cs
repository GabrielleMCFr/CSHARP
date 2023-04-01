using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double rectArea = Rect(1500, 2500);
      double circArea = Circle(375)/2;
      double trArea = Triangle(700, 500);
      double totalArea = rectArea + circArea + trArea;
      double flooringCost = Math.Round(totalArea * 180, 2);
      Console.WriteLine($"It's gonna cost {flooringCost} pesos.");
    }

    static double Rect(double length, double width) {
      return length * width;
    }

    static double Circle(double radius) {
      return Math.PI * Math.Pow(radius, 2);
    }

    static double Triangle(double bottom, double height) {
      return 0.5* bottom * height;
    }

  }
}
