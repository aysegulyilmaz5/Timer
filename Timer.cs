using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int timer= 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            label1.Text = timer.ToString();
            if(timer == 5)
            {
                this.BackColor = Color.BlueViolet;
            }
            if(timer == 10)
            {
                this.BackColor = Color.OrangeRed;
            }
            if(timer == 15)
            {
                this.BackColor = Color.LightGreen;
            }
            if(timer == 20)
            {
                this.BackColor = Color.LightPink;
            }
            if(timer == 25)
            {
                timer = 0;
            }
        }
    }
}
