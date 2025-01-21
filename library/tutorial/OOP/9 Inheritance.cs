using System;

namespace dev
{
  class Vehicle
  {
    public string brand = "ford";

    public void hank()
    {
      Console.WriteLine("tuut, tuuut!");
    }
  }

  class Car:Vehicle
  {
    public string modelName = "mustag";
  }

  class Test
  {
    static void Main(string[] args)
    {
      Car myCar = new Car();
      myCar.hank();
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}