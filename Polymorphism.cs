using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS_in_C_Sharp
{
    /* Compile time ploymorphism /  Early binding / Method overloading / Static Binding  */
    /* Same method but different signatures in same class */
    public class Arithmetic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b;
        }
    }


    /* Runtime polymorphism / Late binding / Method overriding / Dynamic Binding */
    /* Same method with same signatures but in different class */
    public class Calc
    {
        public virtual void display() {
            Console.WriteLine("Throws the basic method");
        }
    }
    public class DerivedClac : Calc {
        public override void display() {
            Console.WriteLine("Throws the derived class method");
        }
    }
}
