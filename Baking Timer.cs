using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baking_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if(progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Red;
            }
            if(progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Yellow;
            }
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
           

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        progressBar2.Value += 5;
        if (progressBar2.Value % 10 == 0)
        {
            label2.BackColor = Color.White;
        }
        if (progressBar2.Value % 10 == 5)
        {
            label2.BackColor = Color.Red;
        }
        if (progressBar2.Value == 100)
        {
            timer2.Stop();
            timer3.Start();
        }
    }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 3;
            if (progressBar3.Value % 10 == 0)
            {
                label3.BackColor = Color.Green;
            }
            if (progressBar3.Value % 10 == 5)
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 30;
            if (progressBar3.Value % 10 == 0)
            {
                label3.BackColor = Color.Orange;
            }
            if (progressBar3.Value % 10 == 5)
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Cake is ready");

            }
        }
    }
