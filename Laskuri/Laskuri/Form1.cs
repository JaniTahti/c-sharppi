using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float lasku = 0;
            float luku1 = float.Parse(LukuYksiTB.Text);
            float luku2 = float.Parse(LukuKaksiTB.Text);
            string merkki = LaskeBT.Text;
            switch(merkki)
            {
                case "+":
                    lasku = luku1 + luku2;
                    break;
                case "-":
                    lasku = luku1 - luku2;
                    break;
                case "*":
                    lasku = luku1 * luku2;
                    break;
                case "/":
                    if(luku2 == 0)
                    {
                        VastausLB.Text = "Nollalla ei voi jakaa";
                        goto Hyppy;
                    }
                    else
                    {
                        lasku = luku1 / luku2;
                    }
                    break;
                    
            }
            VastausLB.Text = lasku + "";
            Hyppy:
            VastausLB.Visible = true;
        }
    }
}
