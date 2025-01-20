using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      int[,] p1 = {{1,2,3}, {4,5,6}};
      Console.WriteLine(p1[0, 1]);

      foreach(int i in p1)
      {
        Console.WriteLine(i);
      }

      for(int i = 0; i < p1.GetLength(0); i++)
      {
        for(int j = 0; j < p1.GetLength(1); j++)
        {
          Console.WriteLine(p1[i, j]);
        }
      }

    }
  }
}