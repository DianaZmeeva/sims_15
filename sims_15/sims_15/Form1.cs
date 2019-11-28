using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dt, dhr, dur, air, drr, r;
        double t = 0;
        double [] uor = new double[2];
        double[] iar = new double[2];
        double[] str = new double[2];
        double[] nir = new double[2];
        double[] ssr = new double[2];
        double[] dfr = new double[2];
        double[] idr = new double[2];
        double[] rsr = new double[2];

        int i = 1;

        private void button_start_Click(object sender, EventArgs e)
        {
            dt = (double)numericUpDown_dt.Value;
            dhr = (double)numericUpDown_dhr.Value;
            dur = (double)numericUpDown_dur.Value;
            air = (double)numericUpDown_air.Value;
            drr = (double)numericUpDown_drr.Value;
            button_start.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            write();
            t += dt;
            uor[i] = uor[i - 1] + dt * (rrr(t) - ssr[i-1]);
            iar[i] = iar[i - 1] + dt * (srr(t)- ssr[i - 1]);
            nir[i] = iar[i] / dt;
            rsr[i] = rsr[i - 1] + dt * (1 / drr) * (rrr(t) - rsr[i - 1]);
            idr[i] = air * rsr[i];
            dfr[i] = dhr + dur * (idr[i] / iar[i]);
            str[i] = uor[i] / dfr[i];
            if (nir[i] >= str[i])
                ssr[i] = str[i];
            else
                ssr[i] = nir[i];

            update();
        }

        private double srr(double t)
        {
            return Math.Cos(t - dt / 2) + 1.5;
        }

        private double rrr(double t)
        {
            r = Math.Sin(0.25 * t - dt / 2) + 1.5;
            return r;
        }

        private void update()
        {
            uor[i - 1] = uor[i];
            iar[i - 1] = iar[i];
            str[i - 1] = str[i];
            nir[i - 1] = nir[i];
            ssr[i - 1] = ssr[i];
            dfr[i - 1] = dfr[i];
            idr[i - 1] = idr[i];
            rsr[i - 1] = rsr[i];
        }

        private void write()
        {
            label_time.Text = "Time: " + t;
            label_rrr.Text = "RRR: " + Math.Round(r,3);
            label_ssr.Text = "SSR: " + Math.Round(ssr[i - 1], 3);
            label_uor.Text = "UOR: " + Math.Round(uor[i - 1], 3);
            label_iar.Text = "IAR: " + Math.Round(iar[i - 1], 3); 

        }
    }
}
