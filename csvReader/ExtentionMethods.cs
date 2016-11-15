using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReader
{
    public static class SplitRow
    {
        /// <summary>
        /// Extension method to read the string parth of the address
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
      public static string StringAddress(this string word)
      {
            return word.Split(' ')[1];
      }
    }
}
