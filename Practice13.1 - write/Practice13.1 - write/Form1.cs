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

namespace Practice13._1___write
{
    public partial class Form1 : Form
    {
        string path, movepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path = "myFile.txt";
            FileInfo finfo = new FileInfo(path);
            StreamWriter sw = finfo.CreateText();
            sw.Close();
            MessageBox.Show("創建成功", "Warning");
            button2.Enabled = true;
            button3.Enabled = true;
            richTextBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            richTextBox1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo(path);
            if (finfo.Exists)// 若來源檔案存在，顯示訊息
            {
                StreamWriter sw = finfo.CreateText();
                sw.WriteLine(richTextBox1.Text);
                sw.Flush();
                sw.Close();
                richTextBox1.Text = "";
                textBox1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo SourceInfo = new FileInfo("myFile.txt");
            FileInfo DestInfo = new FileInfo(textBox1.Text);
            movepath = DestInfo.DirectoryName;
            if (!Directory.Exists(movepath))          // 若指定的目的檔案資料夾不存在
                Directory.CreateDirectory(movepath);   // 則建立該資料夾
            if (DestInfo.Exists)                   // 若目的檔案存在
                DestInfo.Delete();
            SourceInfo.MoveTo(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
