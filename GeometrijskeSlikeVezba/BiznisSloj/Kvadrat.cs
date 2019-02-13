using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskeSlikeVezba.BiznisSloj
{
    public class Kvadrat : GeometrijskaSlika
    {
        private double a = 1;

        public double A
        {
            get { return this.a; }
            set
            {
                if (a > 0)
                    this.a = value;
            }
        }

        public override double Obim
        {
            get { return 4 * this.a; }
        }

        public override double Povrsina
        {
            get { return Math.Pow(this.a, 2); }
        }

        public Kvadrat(double a)
        {
            if(a<=0) 
                throw new ArgumentException();
            this.a = a;
        }

        public Kvadrat(Kvadrat k)
        {
            this.a = k.a;
        }

        public Kvadrat()
        {
        }
    }
}
