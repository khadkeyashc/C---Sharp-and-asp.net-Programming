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
using System.Data.SqlClient;

namespace WindowsFormsApp44
{
    public partial class Form1 : Form
    {
        public string constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=employee91;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String q = "insert into emp22(id,name,Salary)values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added Sucessfully");
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String s = "delete from emp22 where id=" + textBox1.Text.ToString();
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Sucessfully");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String a = "update emp22 set name='" + textBox2.Text.ToString() + "',Salary=" + textBox3.Text.ToString() + " where id=" + textBox1.Text.ToString() + "";
            // in update do not add'""'to int values add""
            SqlCommand cmd = new SqlCommand(a, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Sucessfully");
            textBox1.Clear();
        }
    }
}
