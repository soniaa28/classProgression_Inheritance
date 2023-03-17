using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classProgressionInheritance
{
    public class ArithmeticProgression : Progression
    {


        public ArithmeticProgression(double _m1, double _increment, int _n) : base(_m1, _increment, _n) { }

        public override double Inc
        {
            get
            {
                return increment;
            }
            set
            {
                if (value == 0) 
                {
                    Console.WriteLine("Wrong input of increment in this progression , increment by default will be '1' ");
                    increment =1;
                }
                else { increment = value; }
            }
        }

       
        public override string Name
        {
            get
            {
                return "Арифметична";
            }
        }
        public override double getN(int _n)
        {
            return m1 + ((_n - 1) * increment);
        }
        public override string ToString()

        {
            string progression = "";
            for (int i = 1; i <=n; i++)
            {
                progression += string.Format("{0} ",getN(i));
            }
            return progression;
        }
     

        public override double getSumOfAll()
        {
            double sum = 0.5 * increment * n * n + (m1 - 0.5 * increment) * n;
            return sum;
        }

        public override double getSumOfN(int _n)
        {
            double sum = 0.5 * increment * _n * _n + (m1 - 0.5 * increment) * _n;
            return sum;
        }

        public static ArithmeticProgression operator +(ArithmeticProgression left, ArithmeticProgression right)
        {
            double newFirstMember = left.m1 + right.m1;
            double newIncrement = left.increment + right.increment;
            int newN=left.n + right.n;
            return new ArithmeticProgression(newFirstMember, newIncrement,newN);
        }
    }
}
