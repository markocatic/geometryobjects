using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskeSlikeVezba.BiznisSloj
{
    public class Krug : GeometrijskaSlika
    {
        private double r = 1;

        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                {
                    this.r = value;
                }
            }
        }

        public override double Obim
        {
            get { return 2 * Math.PI * this.r; }
        }

        public override double Povrsina
        {
            get { return Math.PI * Math.Pow(this.r, 2); }
        }

        public Krug() { }

        public Krug(double r)
        {
            if(r<=0)
                throw new ArgumentException();
            this.r = r;
        }
    }
}
