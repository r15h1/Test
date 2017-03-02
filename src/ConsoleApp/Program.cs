using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            I i = new MyClass();
            MyClass m = new MyClass();

            CallInterface(i);
            CallInterface(m);
            CallMyClass(i as MyClass);
            CallMyClass(m);
        }

        public static void CallInterface(I i)
        {
            i.DoSomething();
        }

        public static void CallMyClass(MyClass m)
        {
            m.DoSomething();
        }
    }
}
