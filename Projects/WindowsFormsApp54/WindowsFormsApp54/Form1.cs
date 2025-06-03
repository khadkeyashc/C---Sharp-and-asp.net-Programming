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

namespace WindowsFormsApp54
{
    public partial class Form1 : Form
    {
        public String constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=student2;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cm = new SqlCommand("select * from stud2", con);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
           
            
                String q = "insert into stud2(id,name) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucess");
           
            
            SqlCommand cm = new SqlCommand("select * from stud2", con);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            dataGridView1.DataSource = dt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            Form3 f3=new Form3();
            f3.Show();
            SqlCommand cmd = new SqlCommand("Select * from stud2", con);
            SqlCommand c = new SqlCommand("Select * from stud3", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            SqlDataAdapter ada = new SqlDataAdapter(c);
            DataSet ds = new DataSet();
            DataSet d = new DataSet();
            adap.Fill(ds, "stud2");
            ada.Fill(d, "stud3");

            CrystalReport1 crl = new CrystalReport1();
            crl.SetDataSource(ds);
            crl.SetDataSource(d);
            f3.crystalReportViewer1.ReportSource = crl;
           // f3.crystalReportViewer1.Refresh();
            con.Close();

        }
    }
}
