using System;

namespace dev
{
  class Test
  {
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }
    
    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int p1 = PlusMethod(5,4);
      double p2 = PlusMethod(3.4, 5.3);

      Console.WriteLine("int: " + p1);
      Console.WriteLine("double: " + p2);
    }
  }
}