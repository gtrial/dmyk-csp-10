using System;

namespace task2
{
    internal static class Program
    {
        private static void Main()
        {
            var myClass1 = new MyClass1();
            myClass1.Method1();
            var myClass0 = (MyClass0) myClass1;
            myClass0.Method1();
        }
    }

    internal class MyClass0
    {
        public virtual void Method1()
        {
            Console.WriteLine("MyClass0.Method1");
        }
    }

    internal class MyClass1 : MyClass0
    {
        public override void Method1()
        {
            Console.WriteLine("MyClass1.Method1");
        }
    }
}