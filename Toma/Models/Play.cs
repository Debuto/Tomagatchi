using System;

namespace Toma.Models
{
  public class PlayOption
  {
    public string Name { get; }
    public int Value { get; }

    public PlayOption(string name, int value)
    {
      Name = name;
      Value = value;
    }
  }
  public static class PlayOptions
  {
    public static PlayOption Option1 { get; } = new PlayOption("Play Cards", 10);
    public static PlayOption Option2 { get; } = new PlayOption("Toss the ol Pig Skin", 25);
    public static PlayOption Option3 { get; } = new PlayOption("Watch a Movie", 50);
    public static PlayOption Option4 { get; } = new PlayOption("Mario Kart Tournament!!", 100);
  }
}