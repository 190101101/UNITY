using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      int p1 = 10;
      int p2 = 11;

      if (p1 > p2)
      {
        Console.WriteLine("p1 > p2");
      }
      else if (p1 <= p2 || p1 == p2)
      {
        Console.WriteLine("p1 <= p2 || p1 == p2");
      }
      else
      {
        Console.WriteLine("p1 < p2");
      }
    }
  }
}