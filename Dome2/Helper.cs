using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome2
{
    internal class Helper
    {
        public static List<int> GetOddNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            if (numbers != null)
           
                for (int i = 0; i < numbers.Count; i++)
               
                    if (numbers[i] % 2 == 1)
                        result.Add(numbers[i]);
               
            
            return result;
        }
    }
}
