using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7._1___Polygonal
{
    public partial class Form1 : Form
    {
        int current;
        public Form1()
        {
            InitializeComponent();
        }

        private void FigShow()
        {
            pictureBox1.Image = Image.FromFile("p" + current.ToString() + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current = 1;
            FigShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (current == 6)
                    pictureBox1.Image = Image.FromFile("p6.png");
                else
                    current++;
                FigShow();
            }      
            if (radioButton2.Checked)
            {
                if (current == 1)
                    pictureBox1.Image = Image.FromFile("p1.png");
                else
                    current--;
                FigShow();
            }
        }
    }
}
