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

namespace WindowsFormsApp71
{
    public partial class Form1 : Form
    {
        public string constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=employee102;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cm = new SqlCommand("select * from emp102",con);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            Form2 f2 = new Form2();
            f2.Show();
            SqlCommand cmd = new SqlCommand("select * from emp102",con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds, "emp102");
            CrystalReport1 crl = new CrystalReport1();
            crl.SetDataSource(ds);
            f2.crystalReportViewer1.ReportSource = crl;
            f2.crystalReportViewer1.Refresh();
            con.Close();

        }
    }
}
