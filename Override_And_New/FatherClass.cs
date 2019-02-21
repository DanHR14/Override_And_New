using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_And_New
{
    class FatherClass
    {
        public void Hello()
        {
            Console.WriteLine("Hello I am the father");
        }

        public void Hello(string name)
        {
            Console.WriteLine("Hello {0} I am the overload father's hello method", name);
        }

        public virtual void Virtual()
        {
            Console.WriteLine("Hello I am the virtual method from father class");
        }

        public virtual void WhatIsNew()
        {
            Console.WriteLine("What is new? I am the father");
        }
    }
}
