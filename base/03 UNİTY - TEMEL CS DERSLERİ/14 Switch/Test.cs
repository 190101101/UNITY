using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      string name = "pepi";

      switch (name)
      {
        case "pepi":
          Console.Write("name is pepi");
          break;
        case "apsi":
          Console.Write("name is apsi");
          break;
        default:
          Console.Write("name is unknown");
          break;
      }
    }
  }
}