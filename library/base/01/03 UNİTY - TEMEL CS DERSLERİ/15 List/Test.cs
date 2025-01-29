using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      List<int> ages = new List<int>();
      ages.Add(4);
      ages.Add(11);
      Console.WriteLine(ages[0]);
      Console.WriteLine(ages[1]);
      Console.WriteLine(ages.Count);

      ages.Insert(1, 10);
      Console.WriteLine(ages.Count);
      ages.Remove(2);
      Console.WriteLine(ages.Count);
      Console.WriteLine(ages.Contains(3));
      Console.WriteLine(ages.Contains(4));
      ages.Clear();
      Console.WriteLine(ages.Count);
    }
  }
}