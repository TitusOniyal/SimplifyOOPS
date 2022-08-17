using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS_in_C_Sharp
{

    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic _polyCompile = new Arithmetic();
            _polyCompile.Add(5, 10);
            _polyCompile.Add(5, 10, 15);

            Calc _polyRuntime = new DerivedClac();
            _polyRuntime.display();
            Console.ReadLine();

        }
    }
       
}
