using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      string[] p1 = new string[2];
      string[] p2 = new string[2] {"a", "b"};
      string[] p3 = new string[] {"a", "b", "c"};
      string[] p4 = {"a", "b"};

      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine(p3);
      Console.WriteLine(p4);
    }
  }
}