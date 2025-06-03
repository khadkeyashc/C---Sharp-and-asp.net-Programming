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

namespace WindowsFormsApp58
{
    public partial class Form1 : Form
    {
        public string constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=employee35;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String u = "update emp53 set Name='" + textBox2.Text.ToString() + "',Salary=" + textBox3.Text.ToString() + "Where id=" + textBox1.Text.ToString() + "";
            SqlCommand cmd = new SqlCommand(u, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Sucessfully");
            SqlCommand c=new SqlCommand("select * from emp53", con);
            DataTable dt=new DataTable();
            dt.Load(c.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String q = "insert into emp53(id,Name,Salary)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added Sucessfully");
            SqlCommand cm=new SqlCommand("select * from emp53",con); cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String s = "delete from emp53 where id=" + textBox1.Text.ToString();
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Sucessfully");
            SqlCommand M = new SqlCommand("select * from emp53", con);
            DataTable dt=new DataTable();
            dt.Load(M.ExecuteReader());
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from emp53",con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            Form2 f2 = new Form2();
            f2.Show();
            SqlCommand cmd = new SqlCommand("select * from emp53",con);
            SqlDataAdapter adpt=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds, "emp53");
            CrystalReport1 crl = new CrystalReport1();
            crl.SetDataSource(ds);
            f2.crystalReportViewer1.ReportSource=crl;
            f2.crystalReportViewer1.Refresh();



        }
    }
}
