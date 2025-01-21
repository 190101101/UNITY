using System;

namespace dev
{
  class Person
  {
    private string name;

    public string Name{
      get{return name;}
      set{name = value;}
    }
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