using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {

      Forest f = new Forest("Amazon");
      Console.WriteLine(f.Trees);
      f.Grow();
      f.Burn();
      Console.WriteLine(f.Trees);

    }
  }
}
