using System;
using Toma.Models;

namespace Toma
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Tomagatchi Time!");
      Console.Write("Please enter a name for your Tomagatchi: ");
      string name = Console.ReadLine();
      Console.Write("You have chosen: " + name + Environment.NewLine + "Is that ok? (y/n) ");
      string choice = Console.ReadLine().ToLower();

      if (choice == "y")
      {
        Console.WriteLine("Are you sure? (y/n) ");
        string choice1 = Console.ReadLine().ToLower();
        if (choice1 == "y")
        {
          Console.WriteLine("Ok then... Time to play Tomagatchi with " + name + "!");
          Pet myPet = new Pet(name);
        }
      }
    }
  }
}