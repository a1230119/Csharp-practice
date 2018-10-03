using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice12._1___KeyboardEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char c = e.
            //int n = e.KeyValue;
            //label1.Text = "你按了" + c + "鍵，鍵碼" + n;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            label2.Text = "按了左鍵於 X: " + x + " Y: " + y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys c = e.KeyCode;
            int n = e.KeyValue;
            label1.Text = "按了 " + c + "鍵，鍵碼:" + n;
            label2.Text = "Press";
            switch (e.KeyCode) {
                case Keys.Left:
                    label1.Left -= 10;
                    break;
                case Keys.Right:
                    label1.Left += 10;
                    break;
                case Keys.Up:
                    label1.Top -= 10;
                    break;
                case Keys.Down:
                    label1.Top += 10;
                    break;
                default:
                    break;
            }
        }
    }
}
