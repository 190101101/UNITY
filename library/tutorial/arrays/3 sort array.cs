using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      string[] p1 = new string[] {"a", "b", "c"};

      for(int i = 0; i < p1.Length; i++)
      {
        Console.Write(p1[i]);
      }

      foreach(string elem in p1)
      {
        Console.Write(elem);
      }
    }
  }
}