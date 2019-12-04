using System;

using System.Collections.Generic;

namespace Lab2
{
    class A
    {
        protected float x;

        public float solveLin(float a, float b)
        {
            if (a == 0.0f || b == 0.0f)
            {
                return float.NaN;
            }

            x = -b / a;
            return x;
        }
    }

    class B : A
    {
        private float x2;

        public List<float> solveQuad(float a, float b, float c)
        {
            if (a == 0.0f)
            {
                float result = solveLin(b, c);

                if (float.IsNaN(result))
                {
                    return new List<float>();
                }
                else
                {
                    x = result;
                    return new List<float>{ result };
                }
            }

            float disc = calcDisc(a, b, c);

            if (disc < 0)
            {
                return new List<float>();
            }

            List<float> roots = new List<float>();
            roots.Add((-b + (float)Math.Sqrt(disc)) / 2 * a);
            x = roots[0];

            if (disc == 0.0f)
            {
                return roots;
            }

            roots.Add((-b - (float)Math.Sqrt(disc)) / 2 * a);
            x2 = roots[1];

            return roots;
        }

        protected float calcDisc(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B slv = new B();

            List<float> roots = slv.solveQuad(0, 0, 0);

            if (roots.Count == 0)
            {
                Console.WriteLine("Корней нет");
            }
            else
            {
                Console.Write("Корни: ");

                foreach (float root in roots)
                {
                    Console.Write(root.ToString() + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}