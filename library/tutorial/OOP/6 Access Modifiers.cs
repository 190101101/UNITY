using System;

namespace dev
{
  class Car
  {
    private string model = "mustang";
  }

  class Test
  {
    
    static void Main(string[] args)
    {
      Car myobj = new Car();
      Console.WriteLine(myobj.model);
    }
  }
}