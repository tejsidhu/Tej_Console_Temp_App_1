using System;

namespace Console_Temp_App_1
{
    abstract class A
    {
        protected A() { Console.WriteLine("Abstract class constructor"); }
    }
    //Derived class
    class B : A
    {
        public B() { Console.WriteLine("Derived class constructor"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
        }
    }
}
