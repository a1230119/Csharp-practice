using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6._3___System_Input_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0000" && textBox2.Text == "0000")
            {
                this.Visible = false;
                Form2 f2 = new Form2();
                f2.Visible = true;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
