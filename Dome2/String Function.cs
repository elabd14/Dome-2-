using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome2
{
    internal class String_Function
    {

        public static int GetCountOfUpperChars(string name)

        {
            int Count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                
                    if (char.IsUpper(name[i]))
                       Count++;
                   return Count;
                
              


            }


        }
        public static int GetCountOfLowerChars(string name)

        {
            int Count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                
                    if (char.IsLower(name[i]))

                     Count++;
                     return Count;
                
               


            }
        }
    }
}
