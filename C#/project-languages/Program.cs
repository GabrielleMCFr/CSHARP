using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
      
      //foreach(var l in languages) {
      //  Console.WriteLine(l.Prettify());
      //}

    var queryLanguages = from l in languages
    select $"{l.Name} created in {l.Year}";

      //foreach(var l in queryLanguages) {
      //Console.WriteLine(l);
      //}

    // find when C# was released
    var C = languages.Where(l => l.Name == "C#");

    // Remember that a query returns a collection of items, so you’ll have to iterate through the list, even if it has a count of 1.
    //foreach (var x in C) {
//Console.WriteLine(x.Prettify());
    //}

    // Find all of the languages which have "Microsoft" included in their ChiefDeveloper property.
    var microsoft = languages.Where(l => l.ChiefDeveloper.Contains("Microsoft"));

    //foreach (var x in microsoft) {
    //  Console.WriteLine(x.Prettify());
    //}

    // Find all of the languages that descend from Lisp.
    var lisp = languages.Where(l => l.Predecessors.Contains("Lisp"));
    //PrettyPrintAll(lisp);

    // Find all of the language names that contain the word "Script" (capital S). Make sure the query only selects the name of each language.
    var names = languages.Where(l => l.Name.Contains("Script")).Select(l => l.Name);

    PrintAll(names);

    // How many languages are included in the languages list?
    Console.WriteLine(languages.Count);

    // How many languages were launched between 1995 and 2005?
    var launch = from l in languages
    where l.Year >= 1995 && l.Year <= 2005
    select $"{l.Name} was invented in {l.Year}";
    Console.WriteLine(launch.Count());

    foreach( var l in launch) {
      Console.WriteLine(l);
    }

    }

    public static void PrettyPrintAll(IEnumerable<Language> langs) {
      foreach(var x in langs) {
        Console.WriteLine(x.Prettify());
      }
    }

    public static void PrintAll(IEnumerable<string> query) {
      foreach(var x in query) {
        Console.WriteLine(x);
      }
    }

    
  }
}
