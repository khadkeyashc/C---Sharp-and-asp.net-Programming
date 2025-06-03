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

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=student1;Integrated Security=True";
       
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from stu",con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            Form2 f2= new Form2();
            f2.Show();
           // if(con.State!=ConnectionState.Open())
            //{
               // con.Open();
            //}
            SqlCommand cmd = new SqlCommand("Select * from stu", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            adap.Fill(ds,"stu");
            CrystalReport1 crl = new CrystalReport1();
            crl.SetDataSource(ds);
            f2.crystalReportViewer1.ReportSource = crl;
            f2.crystalReportViewer1.Refresh();
            con.Close();    
        }
    }
}
