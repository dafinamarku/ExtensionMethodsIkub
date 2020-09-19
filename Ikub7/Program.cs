using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikub7
{
  class Program
  {
    
    static void Main(string[] args)
    {
      int[] arr = new int[] { 1, 5, 0, 3, 10, 2 };
      arr.SortArray();
      Console.WriteLine("Sorted:\n");
      foreach(var i in arr)
        Console.WriteLine(i + "    ");
     
      arr.SortReverseArray(true);
      Console.WriteLine("Sorted and reversed:\n");
      foreach (var i in arr)
        Console.WriteLine(i + "    ");
      

    }
  }
}
