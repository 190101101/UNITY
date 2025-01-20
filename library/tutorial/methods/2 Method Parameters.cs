using System;

namespace dev
{
  class Test
  {
    static void myMethod(string uname, int age)
    {
      Console.WriteLine("my name is " + uname + " and me " + age + " year");
    }

    static void Main(string[] args)
    {
      myMethod("pepi", 2);
    }
  }
}