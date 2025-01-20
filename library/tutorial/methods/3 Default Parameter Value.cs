using System;

namespace dev
{
  class Test
  {
    static void myMethod(string uname = "pepi", int age = 2)
    {
      Console.WriteLine("my name is " + uname + " and me " + age + " year");
    }

    static void Main(string[] args)
    {
      myMethod();
    }
  }
}