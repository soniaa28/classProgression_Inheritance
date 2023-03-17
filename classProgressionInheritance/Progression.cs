using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace classProgressionInheritance
{
    abstract public class Progression
    {
        protected double m1; // first member of progression
        protected double increment;// d or q in progression
        protected int n;//quantity of elements in progression


        public abstract double Inc { get; set; }
        public abstract string Name { get; }
        
        public int N
        {
            get 
            { 
                return n;
            }
            set 
            {
                n = value;
            }
        }
        public Progression(double _m1, double _increment, int _n)
        {
            this.m1 = _m1;
            if (_increment == 0) { increment = 1; }
            else { increment = _increment; }
            this.n = _n;
        }

        public abstract double getN(int _n);
        public abstract double getSumOfN(int _n);
        public abstract double getSumOfAll();

        public static bool operator <(Progression left, Progression right)
        {
            return left.getSumOfAll() < right.getSumOfAll();
        }
        public static bool operator >(Progression left, Progression right)
        {
            return left.getSumOfAll() > right.getSumOfAll();
        }
       



    }
}
