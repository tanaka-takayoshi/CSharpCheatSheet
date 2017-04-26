using System;

namespace CheatSheetConsoleApp
{
  class Ex3_2_ShiftOperator
  {
    internal static void Run()
    {
      // 0001 << 00001 = 0010
      var x0 = 1 << 1; //2
      x0.Dump();
      // 33 = 0010 0001 だが下位5ビットをシフトカウントとして使うため、 00001 でシフトする 
      // 0001 << 00001 = 0010
      var x1 = 1 << 33; //2 
      x1.Dump();
      // longまたはulongのときは下位6ビットでシフトする
      // 0001 << 100001
      var x2 = 1L << 33; //8589934592
      x2.Dump();
      // 97 = 0110 0001 の下位6ビットでシフトする
      // 0001 << 100001
      var x3 = 1L << 97; //8589934592
      x3.Dump();
      
      // 0011 1110 1000 >> 3 = 125 (0111 1101)
      var x4 = 1000 >> 3; //125
      x4.Dump();
    }
  }
}
