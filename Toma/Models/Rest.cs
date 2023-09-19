using System;

namespace Toma.Models
{
  public class RestOption
  {
    public string Name { get; }
    public int Value { get; }

    public RestOption(string name, int value)
    {
      Name = name;
      Value = value;
    }
  }
  public static class RestOptions
  {
    public static RestOption Option1 { get; } = new RestOption("Close eyes 10 secs", 10);
    public static RestOption Option2 { get; } = new RestOption("light nap", 25);
    public static RestOption Option3 { get; } = new RestOption("Cat nap", 50);
    public static RestOption Option4 { get; } = new RestOption("Full overnight sleep", 100);
  }
}