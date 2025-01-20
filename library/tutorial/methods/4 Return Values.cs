using System;

namespace dev
{
  class Test
  {
    static int myMethod(int x)
    {
      return 10 * x;
    }

    static int myMethod2(int x, int y)
    {
      return y * x;
    }

    static void Main(string[] args)
    {
      Console.Write(myMethod(20));
      Console.Write(myMethod2(20, 30));
    }
  }
}