using System;
using System.Collections.Generic;
using System.Text;
using Lab.core;
using Lab.cerber;

namespace Lab.cerber
{
    class Quadratic : cerber.Linear, core.EquationInterface
    {
        private float x2;

        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0.0f)
            {
                float result = SolveLin(b, c);

                if (float.IsNaN(result))
                {
                    return new List<float>();
                }
                else
                {
                    x = result;
                    return new List<float> { result };
                }
            }

            float disc = CalcDisc(a, b, c);

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

        protected float CalcDisc(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }
    }
}
