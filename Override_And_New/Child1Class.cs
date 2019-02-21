using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_And_New
{
    class Child1Class : FatherClass
    {
        void Hello()
        {
            Console.WriteLine("Hello I am the child");
        }

        public override void Virtual()
        {
            Console.WriteLine("Hello I am the override method from child");
        }

        public new void WhatIsNew()
        {
            Console.WriteLine("I don't know what is father class, i am the child class");
        }
    }
}
