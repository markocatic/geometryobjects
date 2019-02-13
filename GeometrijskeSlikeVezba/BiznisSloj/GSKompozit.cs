using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskeSlikeVezba.BiznisSloj
{
    class GSKompozit : GeometrijskaSlika
    {
        private List<GeometrijskaSlika> lista = new List<GeometrijskaSlika>();


        public override double Obim
        {
            get
            {
                double obimTmp = 0;
                foreach (var item in this.lista)
                {
                    obimTmp += item.Obim;
                }

                return obimTmp;
            }
        }

        public override double Povrsina
        {
            get
            {
                double povrsina =
                    (from i in this.lista
                        select i.Povrsina).Sum();
                return povrsina;
            }
        }

        public void dodaj(GeometrijskaSlika g)
        {
            if (g == null)
                return;
            lista.Add(g);
        }

        public void izbaci(GeometrijskaSlika g)
        {
            if (g == null)
                return;
            this.lista.Remove(g);
        }

        public void izbaciSve()
        {
            this.lista.Clear();
        }
    }
}
