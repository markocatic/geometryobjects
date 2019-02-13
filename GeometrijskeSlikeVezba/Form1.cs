using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometrijskeSlikeVezba.BiznisSloj;

namespace GeometrijskeSlikeVezba
{
    public partial class Form1 : Form
    {
        private GSKompozit gsKompozit = new GSKompozit();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonObim_Click(object sender, EventArgs e)
        {
            this.gsKompozit.izbaciSve();
            this.gsKompozit.dodaj(new Krug());
            GSKompozit novaGrupa = new GSKompozit();
            novaGrupa.dodaj(new Kvadrat());
            novaGrupa.dodaj(new Krug(5));
            this.gsKompozit.dodaj(novaGrupa);
            double ukupanObim = this.gsKompozit.Obim;

            GSKompozit novaGrupa2 = new GSKompozit();
            novaGrupa2.dodaj(new Krug(2));
            novaGrupa2.dodaj(new Krug(3));
            novaGrupa2.dodaj(new Kvadrat(2));
            this.gsKompozit.dodaj(novaGrupa2);
            GSKompozit novaGrupa3 = new GSKompozit();
            novaGrupa3.dodaj(new Krug(4));
            novaGrupa3.dodaj(new Kvadrat(4));
            novaGrupa2.dodaj(novaGrupa3);
            ukupanObim = this.gsKompozit.Obim;
            double ukupnaPovrsina = this.gsKompozit.Povrsina;

        }
    }
}
