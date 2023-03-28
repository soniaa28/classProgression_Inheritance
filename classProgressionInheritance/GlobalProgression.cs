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
        public void HandleEvent(object sender, ProgressionEventArgument arg)
        {
            GeomProgression gp = sender as GeomProgression;
            if(gp.Inc < 5 )
            {
                gp.N += 10;
                arg.Msg += "Позичаю тобі ще 10 елементів, тому що в тебе мале значення інкременту !";
            }
            else
            {
                if(gp.N > 5)
                {
                    gp.N -= 5;
                    arg.Msg += "Забираю в тебе 5 елементів, тому що в тебе завелике значення інкременту !";
                }
                else
                {
                    arg.Msg += "Ні дав, ні забрав !";
                }
               
            }
            
           
            
        }
    }
}
