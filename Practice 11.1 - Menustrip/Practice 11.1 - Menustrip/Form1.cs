using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practice_11._1___Menustrip
{
    public partial class Form1 : Form
    {
        FileInfo finfo = new FileInfo("file.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = finfo.CreateText();
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void read_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("file.txt");
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("新細明體", 10, FontStyle.Regular);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("新細明體", 20, FontStyle.Regular);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("新細明體", 30, FontStyle.Regular);
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }

        private void green_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void red_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            finfo.Delete();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
