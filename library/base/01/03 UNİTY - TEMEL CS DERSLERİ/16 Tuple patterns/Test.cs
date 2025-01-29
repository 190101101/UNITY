using System;

namespace dev
{
  class Test
  {
    static void Main(string[] args)
    {
      string taskagitmakas(string bir, string iki) => (bir, iki) switch
      {
        ("tas", "kagit") => "kagit kazandi",
        ("tas", "makas") => "tas kazandi",
        ("kagit", "tas") => "kagit kazandi",
        ("kagit", "makas") => "makas kazandi",
        ("makas", "tas") => "tas kazandi",
        ("makas", "kagit") => "makas kazandi",
        ("tas", "tas") => "beraber",
        ("makas", "makas") => "beraber",
        ("kagit", "kagit") => "beraber",
        (_, _) => "degerler bosh"
      };

      Console.WriteLine(taskagitmakas("tas", "makas"));
    }
  }
}