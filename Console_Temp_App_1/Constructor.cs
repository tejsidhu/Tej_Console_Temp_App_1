using System;

namespace Console_Temp_App_1
{
    class ConstructorDemo
    {
        //Example 1: Constructors        

        public abstract class A
        {
            protected A() { Console.WriteLine("Abstract class constructor"); }
        }

        //Derived class
        public class B : A
        {
            public B() { Console.WriteLine("Derived class constructor"); }
        }
    }
}
