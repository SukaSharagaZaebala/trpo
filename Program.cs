using System;

namespace Lab1
{
    class A
    {

    }

    class B : A
    {
        private A a;
        private A b;

        public B(A a, A b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new B(new A(), new B(new A(), new A()));
        }
    }
}