using System;

namespace Console_Temp_App_1
{
    class StringManipulation
    {
        public string SubString(string s, int i, int j)
        {
            try
            {
                if (i < 0 || j < 0 || i >= s.Length || j >= s.Length)
                    throw new Exception();
                else if (i > j)
                    return (s.Substring(j, i + 1 - j));
                else
                    return (s.Substring(i, j + 1 - i));
            }
            catch (Exception)
            {
                return "<error>";
            }
        }
    }
}
