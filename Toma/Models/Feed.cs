using System;

namespace Toma.Models
{
  public class FoodOption
  {
    public string Name { get; }
    public int Value { get; }

    public FoodOption(string name, int value)
    {
      Name = name;
      Value = value;
    }
  }
  public static class FoodOptions
  {
    public static FoodOption Option1 { get; } = new FoodOption("Snack", 10);
    public static FoodOption Option2 { get; } = new FoodOption("Meal", 25);
    public static FoodOption Option3 { get; } = new FoodOption("2 meals?!", 50);
    public static FoodOption Option4 { get; } = new FoodOption("Feast", 100);
  }
}