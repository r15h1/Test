using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface I
    {
        void DoSomething();
    }
    public class MyClass : I
    {
        public void DoSomething()
        {
            Console.WriteLine("in my class");
        }
    }
}
