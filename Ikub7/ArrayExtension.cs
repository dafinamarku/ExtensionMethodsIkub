using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikub7
{
  public static class  ArrayExtension
  {
    public static void SortArray(this int[] a)
    {
      Array.Sort(a);
    }

    public static void SortReverseArray(this int[] a, bool reverse)
    {
      Array.Sort(a);
      if (reverse)
        Array.Reverse(a);
    }
  }
}
