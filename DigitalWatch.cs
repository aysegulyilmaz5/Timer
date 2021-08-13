using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hour = 0, minute = 0, second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label3.Text = second.ToString();
            if(second == 60)
            {
                minute++;
                label2.Text = minute.ToString();
                second = 0;
                if(minute == 60)
                {
                    hour++;
                    label1.Text = hour.ToString();
                    minute = 0;
                }
            }
        }
    }
}
