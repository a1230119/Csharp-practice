using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_8._1___WinChkLstBx
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int[] array = new int[6];
        int[] arraycheck = new int[6];
        string str;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 49; i++)
            {
                checkedListBox1.Items.Add(i);
                checkedListBox1.CheckOnClick = true;
            }
            label1.Text = "not drawing the winning numbers of Lottery in current period";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int right = 0;
            int count = 0, k = 0;
            array[0] = rnd.Next(1, 50);
            for (int i = 1; i < 6; i++)
            {
                array[i] = rnd.Next(1, 50);//亂數產生，亂數產生的範圍是1~49
                for (int j = 0; j < i; j++)
                    if (array[j] == array[i])//檢查是否與前面產生的數值發生重複，如果有就重新產生
                        i--;
            }
            for (int i = 1; i <= 49; i++)
            {
                if (checkedListBox1.GetItemChecked(i - 1) == true)
                {
                    count++;
                    if (k < 6)
                        arraycheck[k] = i;
                    k++;
                }
            }
            if (count == 6)
            {
                for (int i = 0; i < 6; i++)
                    str += array[i].ToString() + ", ";
                label1.Text = "The current Lotto numbers are as follows:\n" + str + "\n";
                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 6; j++)
                        if (arraycheck[i] == array[j])
                            right++;
                if (right == 6)
                    label1.Text += "Congratulations on winning your big prize...";
                else
                    label1.Text += "Tough luck!Please keep it up...";
                str = "";
            }
            else
                label1.Text = "Please select 6 numbers!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 49; i++)
                checkedListBox1.SetItemChecked(i, false); //設定為未勾選
            label1.Text = "";
            str = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
