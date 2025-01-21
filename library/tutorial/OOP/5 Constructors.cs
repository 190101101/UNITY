using System;

namespace dev
{
  class Test
  {
    public string model;

    public Test(string modelName)
    {
     model = modelName; 
    }

    static void Main(string[] args)
    {
      Test Ford = new Test("mustang");
      Console.Write(Ford.model);
    }
  }
}