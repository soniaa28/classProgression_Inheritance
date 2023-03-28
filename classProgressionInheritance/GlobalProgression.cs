using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static classProgressionInheritance.GeomProgression;

namespace classProgressionInheritance
{
    public class GlobalProgression : ArithmeticProgression

    {
        public GlobalProgression(double _m1, double _increment, int _n) : base(_m1 =1 , _increment =1 , _n =100)
        {}
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("ok");
        }
    }
}
