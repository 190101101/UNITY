using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {

      //? string - text data
      //? int - number data
      //? float - number data 3.1111 32 byte
      //? double - big data 3.23123312 [50] 60 byte
      //? bool - true false

      string p1 = "hello world";
      int p2 = 19;
      float p3 = 3.6341f;
      double p4 = 3.54654;
      bool p5 = false;

      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine(p3);
      Console.WriteLine(p4);
      Console.WriteLine(p5);

    }  
  }
}