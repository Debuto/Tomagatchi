using System;

namespace Toma.Models
{
  public class Pet
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }

    public Pet(string name)
    {
      Name = name;
      Food = 100;
      Attention = 100;
      Rest = 100;

      StartTimer();
    }

    private void StartTimer()
    {
      void HandleTimer()
      {
        this.Food -= 5;
        this.Attention -= 5;
        this.Rest -= 5;
        Console.WriteLine($"Food: {this.Food} \nLove: {this.Attention} \nRest: {this.Rest}");
      }
      System.Timers.Timer timer = new(interval: 1000);
      timer.Elapsed += (sender, e) => HandleTimer();
      timer.Start();

      Console.ReadLine();

      if (this.Food <= 0 || this.Attention <= 0 || this.Rest <= 0)
      {
        timer.Dispose();
        Console.WriteLine($"{this.Name} died!");
      }

    }

    public void Feed(int amount)
    {
      Food += amount;
      if (Food > 100)
        Food = 100;
    }

  }
}