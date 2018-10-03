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

namespace Practice_16._2___SQL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingManagerBase bm;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Hospital.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daDoctor = new SqlDataAdapter("SELECT * FROM doctor", cn);
            daDoctor.Fill(ds, "doctor");
            textBox1.DataBindings.Add("Text", ds, "doctor.name");
            textBox2.DataBindings.Add("Text", ds, "doctor.所屬系別編號");
            textBox3.DataBindings.Add("Text", ds, "doctor.職稱");
            textBox4.DataBindings.Add("Text", ds, "doctor.薪水");
            textBox5.DataBindings.Add("Text", ds, "doctor.Did");
            bm = this.BindingContext[ds, "doctor"];
        }

        private void button1_Click(object sender, EventArgs e)//下一筆
        {
            if (bm.Position < bm.Count - 1)
                bm.Position += 1;
        }

        private void button2_Click(object sender, EventArgs e)//上一筆
        {
            if (bm.Position > 0)
                bm.Position -= 1;
        }

        private void button3_Click(object sender, EventArgs e)//第一筆
        {
            bm.Position = 0;
        }

        private void button4_Click(object sender, EventArgs e)//最末筆
        {
            bm.Position = bm.Count - 1;
        }

        private void button5_Click(object sender, EventArgs e)//新增
        {
            Edit("INSERT INTO doctor(Did,name,所屬系別編號,職稱,薪水)VALUES(" +
                textBox5.Text + ",'" +
                textBox1.Text + "'," +
                textBox2.Text + ",'" +
                textBox3.Text + "'," +
                textBox4.Text + ")");
            DataBindingsClear();
            Form1_Load(sender, e);           
        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Hospital.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DataBindingsClear()
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
        }
    }
}
