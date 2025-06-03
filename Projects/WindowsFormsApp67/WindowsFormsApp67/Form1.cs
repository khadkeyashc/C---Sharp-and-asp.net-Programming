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

namespace WindowsFormsApp67
{
    public partial class Form1 : Form
    {
        public string constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=employee102;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(constr);
            con.Open();
            String q = "insert into emp102(id,name,salary)values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added Sucessfully");
     
            SqlCommand cms = new SqlCommand("select * from emp102", con);
            DataTable dt = new DataTable();
            dt.Load(cms.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(constr);
            con.Open();
            String s = "delete from emp102 where id=" + textBox1.Text.ToString();
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Sucessfully");
           
            
            SqlCommand c = new SqlCommand("select * from emp102", con);
            DataTable dt = new DataTable();
            dt.Load(c.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String u = "update emp102 set name='" + textBox2.Text.ToString() + "',salary=" + textBox3.Text.ToString() + "where id=" + textBox1.Text.ToString() + "";
            SqlCommand cmd=new SqlCommand(u, con);
            cmd.ExecuteNonQuery();
            
            SqlCommand cm = new SqlCommand("select * from emp102", con);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from emp102",con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

        }
    }
}
