using System;
using System.IO;

namespace Console_Temp_App_1
{
    class FileIO_With_USING_Directive
    {
        public void CreateAndReadFile()
        {
            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("This is line one");
                w.WriteLine("This is line two");
            }

            using (TextReader r = File.OpenText("log.txt"))
            {
                string s;
                while ((s = r.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }
        }
    }
}
