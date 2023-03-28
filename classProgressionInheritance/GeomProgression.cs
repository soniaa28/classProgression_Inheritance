﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classProgressionInheritance
{
    public class GeomProgression : Progression


    {
        public delegate void ProgressionEventHandler(object sender, EventArgs e);

        public event ProgressionEventHandler ProgressionEvent;
        public void OnProgressionEvent()
        {
            ProgressionEvent?.Invoke(this, EventArgs.Empty);
        }
        public void Pevent() //method for сalling the event Lesson
        {
           OnProgressionEvent();
        }

        public GeomProgression(double _m1, double _increment, int _n) : base(_m1, _increment, _n)
        {
            if(_increment == 1 || increment == -1)
            {
                increment = 2;
                Console.WriteLine("Wrong input of increment in this progression,increment by default will be '2' ");
            }
        }
     
        public override double Inc
        {
            get
            {
                return increment;
            }
            set
            {
                if (value == 0 || value == 1 || value ==-1) 
                {
                    Console.WriteLine("Wrong input of increment in this progression,increment by default will be '2' ");
                    increment = 2; 
                }
                else { increment = value; }
             
            }
        }

        public override int N
        {
            get { return n; }
            set { n = value; OnProgressionEvent(); }
        }
        public override double getN(int _n)
        {
            return m1 * Math.Pow(increment, _n - 1);
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
        public static GeomProgression operator +(GeomProgression left, GeomProgression right)
        {
            double newFirstMember = left.m1 * right.m1;
            double newIncrement = left.increment * right.increment;
            int newN = left.n + right.n;
            return new GeomProgression(newFirstMember, newIncrement, newN);
        }

    
        
     

    }
   
}

