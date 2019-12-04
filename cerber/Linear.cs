using System;
using System.Collections.Generic;
using System.Text;
using Lab.core;

namespace Lab.cerber
{
    class Linear
    {
        protected float x;

        public float SolveLin(float a, float b)
        {
            if (a == 0.0f || b == 0.0f)
            {
                return float.NaN;
            }

            x = -b / a;
            return x;
        }
    }
}
