using System;

namespace CheatSheetConsoleApp
{
  class Ex3_9_NameOfOperator
  {
    internal static void Run(string[] args)
    {
      var s1 = nameof(args); //args
      s1.Dump();
      
      var s2 = nameof(DateTime.Now); //Now
      s2.Dump();
      
      var s3 = nameof(System.Linq); //Linq
      s3.Dump();
    }
  }
}
