using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classProgressionInheritance
{
    abstract public class Progression : IFormattable, ICloneable
    {
        protected double m1; // перший член прогресії
        protected double increment;// d або q 
        protected int n;//кількість елементів в прогресії

        public abstract double Inc { get; set; }
    
        public abstract int N { get; set; }

        public Progression(double _m1, double _increment, int _n)
        {
            this.m1 = _m1;
            if (_increment == 0) { increment = 1; }
            else { increment = _increment; }
            this.n = _n;
        }
       
        public abstract double getN(int _n); //знаходження n-тового члена прогресії
        public abstract double getSumOfN(int _n);//знаходження суми усіх n-членів 
        public abstract double getSumOfAll();//знаходження суми всіх елементів прогресії
        public override string ToString()

        {
            string progression = "";
            for (int i = 1; i <= n; i++)
            {
                progression += string.Format("{0} ", getN(i));
            }
            return progression;
        }
        public string ToString(string? format, IFormatProvider? formatProvider) //реалізація інтерфейсу IFormattable
        {
            if (format == null)
                return ToString();
            string formatUpper = format.ToUpper();
            switch (formatUpper)
            {
                case "ROW":
                    string progression = "";
                    for (int i = 1; i <= n; i++)
                    {
                        progression += string.Format("\n{0} ", getN(i)); //друк в стовпець
                    }
                    return progression;
                case "BYM1":
                    return String.Format("Перший член = {0} , інкремент = {1} , кількість = {2}", m1, increment, n);
                case "STARTEND":
                    return String.Format("Перший член = {0} , останній = {1}", m1, this.getN(n));

                default:
                    return ToString();
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone(); //поверхневе копіюванння
        }

        public static bool operator <(Progression left, Progression right)
        {
            return left.getSumOfAll() < right.getSumOfAll();
        }
        public static bool operator >(Progression left, Progression right)
        {
            return left.getSumOfAll() > right.getSumOfAll();
        }
    }
    //реалізовано інтерфейс IComparer<T> 
    public class ProgressionComparingbyN : IComparer<Progression> 
    {
        public int Compare(Progression? a, Progression? b)
        {
            return a.N.CompareTo(b.N);
        }
    }

    public class ProgressionComparingbyIncrement : IComparer<Progression>
    {
        public int Compare(Progression? a, Progression? b)
        {
            return a.Inc.CompareTo(b.Inc);
        }
    }
}
