using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classProgressionInheritance
{
    public class GeomProgression : Progression
    {

        public GeomProgression(double _m1, double _increment, int _n) : base(_m1, _increment, _n) { }
        public override double getN(int _n)
        {
            return m1 * Math.Pow(increment, _n - 1);
        }
        public override string ToString()

        {
            string progression = "";
            for (int i = 1; i <= n; i++)
            {
                progression += string.Format("{0} ", getN(i));
            }
            return progression;
        }


        public override double getSumOfAll()
        {
            double sum = m1 * (1 - Math.Pow(increment, n)) / (1 - increment);
            return sum;
        }

        public override double getSumOfN(int _n)
        {
            double sum = m1*(1-Math.Pow(increment, _n))/(1-increment);
            return sum;
        }
    }
}

