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
        public delegate void SumEventHandler(object sender, ProgressionEventArgument arg);

        // подія - тоді коли сума елементів більше 200 
        public event SumEventHandler SumEvent;
    

        // диспетчер події
        private void OnSumEvent(double x)
        {
            Console.WriteLine($"Прогресія повідомляє :Сума моїх елементів вже аж {x} !"); ; ;
            if (SumEvent != null)
            {
                ProgressionEventArgument arg = new(x);
                SumEvent(this, arg);
                if (arg.Msg != String.Empty)
                {
                    Console.WriteLine($"Прогресія повідомляє : Через те, що в мене велика сума елементів отримую повідомлення : \"{arg.Msg}\" ");
                }
            }
        }
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

        public override int N { get ; set; }

        public override double getN(int _n)
        {
            return m1 + ((_n - 1) * increment);
        }
       
        public override double getSumOfAll()
        {
            double sum = 0.5 * increment * n * n + (m1 - 0.5 * increment) * n;
            if(sum >200) OnSumEvent(sum);

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
