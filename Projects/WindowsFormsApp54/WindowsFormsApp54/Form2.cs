using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp54
{
    public partial class Form2 : Form
    {
        public String constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=student2;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();


            String q = "insert into stud3(cid,cname) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucess");


            SqlCommand cm = new SqlCommand("select * from stud3", con);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cm = new SqlCommand("select * from stud3", con);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
