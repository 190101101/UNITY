using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      int[] p1 = new int[5];
      int[] p2 = new int[] { 1, 2, 3, 4 };
      int[] p3 = { 1, 2, 3, 4, 5 };
      string[][] p4 = new string[3][];

      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine(p2[2]);
      Console.WriteLine(p3[1]);

      p4[0] = new string[] { "bmw", "audi", "seat" };
      p4[1] = new string[] { "2010", "2009", "2006" };
      p4[2] = new string[] { "140hp", "100hp", "90hp" };
      Console.WriteLine(p4[0][1]);
      Console.WriteLine(p4[1][0]);

    }
  }
}