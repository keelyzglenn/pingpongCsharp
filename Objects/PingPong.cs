using System.Collections.Generic;

namespace PingPongApp.Objects
{
  public class PingPong
  {
    private static List<string> _instances = new List<string> {};


    // this will count up to usernumer using pingpong rules
    public static List<string> CountUp(int number)
    {
      for(int i=1; i <= number; i++)
      {
        if (i % 3 == 0 && i % 5 ==0)
        {
          _instances.Add("Ping-Pong");
        }
        else if (i % 3 == 0)
        {
          _instances.Add("Ping");
        }
        else if (i % 5 == 0)
        {
          _instances.Add("Pong");
        }
        else
        {
          string stringNumber = i.ToString();
          _instances.Add(stringNumber);
        }
      }
      return _instances;
    }

    // this will clear all instances
    public static void DeleteAll()
    {
      _instances.Clear();
    }
  }
}
