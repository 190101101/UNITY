using System;

namespace dev
{
  class Program
  {
    public string color = "green";
  }

  class Test
  {
    static void Main(string[] args)
    {
      Program myObj = new Program();
      Console.WriteLine(myObj.color);
    }
  }
}