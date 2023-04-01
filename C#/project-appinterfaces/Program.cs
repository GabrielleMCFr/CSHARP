using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");

      PasswordManager pm = new PasswordManager("iluvpie", true);
      Console.WriteLine("TDL:");
      tdl.Display();
      tdl.Reset();
      tdl.Display();

      Console.WriteLine("PM:");
      pm.Display();
      pm.Reset();
      pm.Display();
    }
  }
}
