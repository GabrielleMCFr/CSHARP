using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      
      citiesList.Add("Unverre");

      foreach(string city in citiesList) {
        Console.WriteLine(city);
      }
      
    }
  }
}