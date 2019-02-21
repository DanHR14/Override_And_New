using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_And_New
{
    class Program
    {
        static void Main(string[] args)
        {
            FatherClass FC = new FatherClass();
            Child1Class CC = new Child1Class();

            FC.Hello();
            FC.Hello("Dàniel");
            CC.Hello();
            FC.Virtual();
            CC.Virtual();
            FC.WhatIsNew();
            CC.WhatIsNew();
            Console.Read();

        }
    }
}
