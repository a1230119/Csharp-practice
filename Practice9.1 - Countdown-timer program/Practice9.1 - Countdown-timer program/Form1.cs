using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice9._1___Countdown_timer_program
{
    public partial class Form1 : Form
    {
        int sec;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.Minimum = 0;
        }

        private void reset()
        {
            textBox1.Text = "";
            textBox1.Focus();
            progressBar1.Value = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sec = int.Parse(textBox1.Text);
            }
            catch
            {
                reset();
                return;
            }
            if (sec < 0)
                reset();
            else
                progressBar1.Maximum = sec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text = progressBar1.Value + " 秒";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                label2.Text = "Time's up!";
                timer1.Enabled = false;		// 計時器停止
            }
        }
    }
}
