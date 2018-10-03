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

namespace Practice13._2___binary
{
    public partial class Form1 : Form
    {
        string filename, movepath, bfilename;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filename = "myFile.txt";
            FileInfo finfo = new FileInfo(filename);
            StreamWriter sw = finfo.CreateText();
            sw.Close();
            MessageBox.Show("創建成功", "Warning");
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo(filename);
            if (finfo.Exists)// 若來源檔案存在，顯示訊息
            {
                StreamWriter sw = finfo.CreateText();
                sw.WriteLine(textBox1.Text);
                sw.Flush();
                sw.Close();
                textBox3.Enabled = true;
                button3.Enabled = true;
                MessageBox.Show("已存檔", "Warning");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                FileInfo SourceInfo = new FileInfo(filename);
                FileInfo DestInfo = new FileInfo(textBox3.Text);
                movepath = DestInfo.DirectoryName;
                if (!Directory.Exists(movepath))          // 若指定的目的檔案資料夾不存在
                    Directory.CreateDirectory(movepath);   // 則建立該資料夾
                if (DestInfo.Exists)                   // 若目的檔案存在
                    DestInfo.Delete();
                if (SourceInfo.Exists)
                {
                    SourceInfo.MoveTo(textBox3.Text);
                    textBox3.Text = "";
                }
                else
                    MessageBox.Show("檔案不存在，請先建立檔案", "Warning");
            }
            else
                MessageBox.Show("路徑不可為空", "Warning");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            bfilename = "myFile.bin";
            FileInfo finfo = new FileInfo(bfilename);
            FileStream fsOut = new FileStream(bfilename, FileMode.Create);  // 建立檔案串流
            BinaryWriter bw = new BinaryWriter(fsOut);
            bw.Write(textBox1.Text);///
            bw.Flush();                         // 清除緩衝區
            bw.Close();                         // 關閉資料串流
            fsOut.Close();                      // 關閉檔案串流
            button5.Enabled = true;             // 讀取檔案按鈕有效
            MessageBox.Show("已寫入二進位檔", "Warning");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fsIn = new FileStream(bfilename, FileMode.Open); // 開啟檔案輸入串流
            BinaryReader br = new BinaryReader(fsIn);
            textBox2.Text = br.ReadString();
            br.Close();
            fsIn.Close();
        }
    }
}
