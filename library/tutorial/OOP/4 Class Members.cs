using System;

namespace dev
{
  class Test
  {
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
    Test Ford = new Test();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Test Opel = new Test();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
    }
  }
}