using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practice_16._1___SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "SELECT Did,name,所屬系別編號,職稱,薪水 FROM doctor WHERE 薪水>150000";
            textBox2.Text = "SELECT TOP 3 Did,name,所屬系別編號,職稱,薪水 FROM doctor ORDER BY 薪水 DESC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = textBox2.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Hospital.mdf;" +
                     "Integrated Security=True";
                //   cn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter daSalary = new SqlDataAdapter(toolStripTextBox1.Text, cn);
                daSalary.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                 //  cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
