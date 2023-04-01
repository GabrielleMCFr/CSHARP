// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage : Mage {
    public Archmage(string title) : base(title) {}

    public override Storm CastRainStorm() {
      Storm rainStorm = new Storm("rain", true, Title);
      return rainStorm;
    }

    public Storm CastLightningStorm() {
      Storm lightnings = new Storm("lightning", true, Title);
      return lightnings;
    }
  }
}
