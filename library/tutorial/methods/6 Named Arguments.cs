using System;

namespace dev
{
  class Test
  {

    static void myMethod(
      string p1, 
      string p2,
      string p3
    )
    {
      Console.WriteLine(p1+" "+p2+" "+p3);
    }

    static void Main(string[] args)
    {
      myMethod("pepikus", "ketty", "ququsi");
    }
  }
}