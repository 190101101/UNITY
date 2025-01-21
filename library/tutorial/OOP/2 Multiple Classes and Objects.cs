using System;

namespace dev
{
  class Test
  {
    string color = "red";

    static void Main(string[] args)
    {
      Test myObj1 = new Test();
      Test myObj2 = new Test();
      Console.WriteLine(myObj1.color);
      Console.WriteLine(myObj2.color);
    }
  }
}