using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice12._2___OOXX
{
    public partial class Form1 : Form
    {
        bool player = true;
        public Form1()
        {
            InitializeComponent();
            button2.Click += new System.EventHandler(button1_Click);
            button3.Click += new System.EventHandler(button1_Click);
            button4.Click += new System.EventHandler(button1_Click);
            button5.Click += new System.EventHandler(button1_Click);
            button6.Click += new System.EventHandler(button1_Click);
            button7.Click += new System.EventHandler(button1_Click);
            button8.Click += new System.EventHandler(button1_Click);
            button9.Click += new System.EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "";
            btn.Font = new Font("新細明體", 18);
            if (player)
            {
                btn.Text = "O";
                player = false;
            }
            else {
                btn.Text = "X";
                player = true;
            }
            btn.Enabled = false;
            Button[] btnarray = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show(button1.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }  
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show(button4.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show(button7.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show(button1.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show(button2.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show(button3.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show(button1.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show(button3.Text + " win!", "OK!", MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                {
                    btnarray[i].Text = "";
                    btnarray[i].Enabled = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button[] btnarray = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            for (int i = 0; i < 9; i++)
            {
                btnarray[i].Text = "";
                btnarray[i].Enabled = true;
            }
        }
    }
}
