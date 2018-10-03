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
    public partial class Form2 : Form
    {
        int num = 0;
        string[,] data = new string[0, 4];

        public static void arrayresize(ref string[,] oldarray, int a)//a為增減資料的數目
        {
            int l0 = oldarray.GetLength(0);
            int l1 = oldarray.GetLength(1);
            string[,] newarray = new string[l0 + a, l1];
            if (a >= 0)
                Array.Copy(oldarray, newarray, l0 * l1);
            else
                Array.Copy(oldarray, newarray, (l0 + a) * l1);
            oldarray = newarray;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            label6.Visible = false;
            //一次控制多個label, textbox
            Label[] lb = { label1, label2, label3, label4 };
            for (int i = 0; i < lb.Length; i++)
                lb[i].Visible = true;
            TextBox[] tb = { textBox1, textBox2, textBox3, textBox4 };
            for (int i = 0; i < tb.Length; i++)
            {
                tb[i].Visible = true;
                tb[i].Clear();
            }
            button5.Visible = true;
        }//新增

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label5.Text = "各欄位不能為空，請重新輸入";
                label5.Visible = true;
            }
            else
            {
                num += 1;
                arrayresize(ref data, 1);
                data[num - 1, 0] = textBox1.Text;
                data[num - 1, 1] = textBox2.Text;
                data[num - 1, 2] = textBox3.Text;
                data[num - 1, 3] = textBox4.Text;
                TextBox[] tb = { textBox1, textBox2, textBox3, textBox4 };
                for (int i = 0; i < tb.Length; i++)
                    tb[i].Clear();
                label5.Text ="資料已輸入\n目前已有" + num + "筆資料!!";
                label5.Visible = true;
            }
        }//新增確認

        private void button2_Click(object sender, EventArgs e)
        {
            Label[] lb = { label1, label2, label3, label4, label5, label6 };
            TextBox[] tb = { textBox1, textBox2, textBox3, textBox4 };
            if (data.GetLength(0) == 0)//沒有資料的話不顯示
            {
                button6.Visible = false;
                for (int i = 0; i < lb.Length; i++)
                    lb[i].Visible = false;
                for (int i = 0; i < tb.Length; i++)
                    tb[i].Visible = false;
            }
            else
            {
                for (int i = 1; i < lb.Length; i++)
                    lb[i].Visible = false;
                for (int i = 1; i < tb.Length; i++)
                    tb[i].Visible = false;
                button5.Visible = false;
                button6.Visible = true;
                button6.Text = "搜尋";
            }
        }//搜尋

        private void button3_Click(object sender, EventArgs e)
        {
            Label[] lb = { label1, label2, label3, label4, label5, label6 };
            TextBox[] tb = { textBox1, textBox2, textBox3, textBox4 };
            if (data.GetLength(0) == 0)//沒有資料的話不顯示
            {
                button6.Visible = false;
                for (int i = 0; i < lb.Length; i++)
                    lb[i].Visible = false;
                for (int i = 0; i < tb.Length; i++)
                    tb[i].Visible = false;
            }
            else
            {
                for (int i = 1; i < lb.Length; i++)
                    lb[i].Visible = false;
                for (int i = 1; i < tb.Length; i++)
                    tb[i].Visible = false;
                button5.Visible = false;
                button6.Visible = true;
                button6.Text = "確認刪除?";
            }
        }//刪除

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox[] tb = { textBox2, textBox3, textBox4 };
            Label[] lb = { label2, label3, label4 };
            int i = 0, j = 0;
            bool bl = true;
            if (button6.Text == "搜尋")
            {
                if (textBox1.Text == "")
                {
                    label6.Visible = true;
                    label6.Text = "欄位不能為空!";
                }
                else
                {
                    while (bl == true && i < data.GetLength(0))
                    {
                        if (textBox1.Text == data[i, 0])
                        {
                            bl = false;
                            label6.Visible = false;
                            j = i;
                        }
                        i++;
                    }
                    if (bl == true)
                    {
                        label6.Text = "無此筆資料";
                        label6.Visible = true;
                        for (int k = 0; k < tb.Length; k++)
                        {
                            tb[k].Visible = false;
                            lb[k].Visible = false;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < tb.Length; k++)
                        {
                            tb[k].Visible = true;
                            tb[k].Text = data[j, k + 1];
                            lb[k].Visible = true;
                        }
                    }
                }
            }
            else//button6.Text == "確認刪除?"
            {
                while (bl == true && i < data.GetLength(0))
                {
                    if (textBox1.Text == data[i, 0])
                    {
                        bl = false;
                        label6.Visible = false;
                        j = i;
                    }
                    i++;
                }
                if (bl == true)
                    label6.Visible = false;
                else
                {
                    if (j == data.GetLength(0) - 1)
                        arrayresize(ref data, -1);
                    else
                    {
                        for (int m = j; m < data.GetLength(0) - 1; m++)
                            for (int k = 0; k < 4; k++)
                                data[m, k] = data[m + 1, k];//清空資料
                        arrayresize(ref data, -1);
                    }
                    num--;
                    label6.Visible = true;
                    label6.Text = "刪除成功!!";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//登出
    }
}
