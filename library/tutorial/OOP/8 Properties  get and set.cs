using System;

namespace dev
{
  class Person
  {
    public string Name
    { get;set;}
  }

  class Test
  {
    static void Main(string[] args)
    {
      Person myobj = new Person();
      myobj.Name = "pepis";
      Console.WriteLine(myobj.Name);
    }
  }
}