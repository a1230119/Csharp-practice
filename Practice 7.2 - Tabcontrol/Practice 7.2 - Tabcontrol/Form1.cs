using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7._2___Tabcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabPage2.Parent = null;
            tabPage3.Parent = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox2.Text == "0")
            {
                tabPage1.Parent = null;
                tabPage2.Parent = tabControl1;
                tabPage3.Parent = tabControl1;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

    }
}
