using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6._2___WindowStyleChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
            label2.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            textBox1.BackColor = Color.White;
            button3.TextAlign = ContentAlignment.BottomRight;
            pictureBox1.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("新細明體", 18, FontStyle.Underline);
            label2.Font = new Font("新細明體", 14, FontStyle.Italic);
            textBox1.BackColor = Color.Brown;
            button3.TextAlign = ContentAlignment.MiddleRight;
            pictureBox1.BackColor = Color.Blue;
        }
    }
}
