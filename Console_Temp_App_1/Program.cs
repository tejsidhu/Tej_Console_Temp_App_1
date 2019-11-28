using System;

namespace Console_Temp_App_1
{
    class Program
    {
        static void Main()
        {
            //1. Constructor class demo
            //ConstructorDemo.B objBClass = new ConstructorDemo.B();

            //2. Delegate Class demo
            /*
            Delegate dgate = new Delegate();
            dgate.CallDelegate();
            */

            //3. USING statement demo on file IO operations
            /*
            FileIO_With_USING_Directive fileIO = new FileIO_With_USING_Directive();
            fileIO.CreateAndReadFile();
            */

            //4. String Manipulation
            //StringManipulation sm = new StringManipulation();
            //Console.WriteLine(sm.SubString("quick", 0, 2));
            //Console.WriteLine(sm.SubString("brown", 2, 1));
            //Console.WriteLine(sm.SubString("fox", 1, 9));
            //Console.WriteLine(sm.SubString("jumped", -1, 4));
            //Console.WriteLine(sm.SubString("lazy", 3, 0));
            //Console.WriteLine(sm.SubString("dog", 1, 1));

            //5. Check Digit
            CheckDigit cd = new CheckDigit();
            //Console.WriteLine("The check Digit of 111 is: " + cd.FindCheckDigit(111));
            //Console.WriteLine("The check Digit of 876 is: " + cd.FindCheckDigit(876));            
        }
    }
}
