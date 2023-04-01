using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
        // Storm s = new Storm("wind", false, "Zul'rajas");
        // Console.WriteLine(s.Announce());
        Pupil p = new Pupil("Mezil-kree");
        Storm sCasted = p.CastWindStorm();
        Console.WriteLine(sCasted.Announce());

        Mage m = new Mage("Gul'dan");
        Storm rain = m.CastRainStorm();
        Console.WriteLine(rain.Announce());

        Archmage a = new Archmage("Nielas Aran");
        Storm s1 = a.CastRainStorm();
        Storm s2 = a.CastLightningStorm();
        Console.WriteLine(s1.Announce());
        Console.WriteLine(s2.Announce());
    }
  }
}