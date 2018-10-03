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

namespace Practice_15._1___DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|Hospital.mdf;" +
            "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);

            DataSet ds = new DataSet();
            SqlDataAdapter daHospital = new SqlDataAdapter("SELECT * FROM 系科別", cn);
            daHospital.Fill(ds, "系科別");
            SqlDataAdapter daDoctor = new SqlDataAdapter("SELECT * FROM doctor", cn);
            daDoctor.Fill(ds, "doctor");

            ds.Relations.Add("FK_系科別_doctor", ds.Tables["系科別"].Columns["Pid"], ds.Tables["doctor"].Columns["所屬系別編號"]);
            dataGridView1.Dock = DockStyle.Top;     //dataGridView1停駐在上方
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "系科別";
            dataGridView2.Dock = DockStyle.Fill;    //dataGridView2整個填滿畫面
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "系科別.FK_系科別_doctor";
        }
    }
}
