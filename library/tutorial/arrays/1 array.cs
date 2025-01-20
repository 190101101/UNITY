using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("hello");
      string[] p1 = {"a", "b", "c", "d", "e"};
      int[] p2 = {1,2,3,4,5};

      Console.WriteLine(p1[1]);
      Console.WriteLine(p2[1]);

      p1[4] = "f";
      Console.WriteLine(p1[4]);
      Console.WriteLine(p1.Length);
    }
  }
}