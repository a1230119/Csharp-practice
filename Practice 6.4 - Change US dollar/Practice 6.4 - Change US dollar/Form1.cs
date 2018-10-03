using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6._4___Change_US_dollar
{
    public partial class Form1 : Form
    {
        int money;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getStart();
        }

        private void getStart()
        {
            textBox1.Text = "0";
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                money = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("請輸入正整數!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                getStart();
                return;
            }
            if (money < 0)
            {
                MessageBox.Show("請輸入正整數!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                getStart();
            }
            else
                label3.Text = "可兌換: " + money * 33 + "台幣";
        }
    }
}
