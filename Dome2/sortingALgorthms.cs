using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome2
{
    internal class sortingALgorthms
    {
        public static void Bubblesort(int[] array,CompaerFunction compaerFunction)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                       /* if (CompaerFunction.ComaperGrt(array[j], array[j+1]))*/
                       if (compaerFunction.Invoke(array[j], array[j+1]))
                            SWAP(ref array[j], ref array[j + 1]);
                }
            }
        }

        internal static void Bubblesort(int[] numbers, Func<int, int, bool> comaperGrt)
        {
            throw new NotImplementedException();
        }
    }

    public static void SWAP(ref int v1,ref int v2) 
    {
        int Tamp = v1;
        v1 = v2;
        v2 = Tamp;

    
    } 
}
