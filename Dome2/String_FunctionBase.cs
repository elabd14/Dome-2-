namespace Dome2
{
    internal class String_FunctionBase
    {

        public static int GetCountOfUpperChars(string name)

        {
            int Count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]))

                        Count++;

                }
                return Count;


            }


        }
    }
}