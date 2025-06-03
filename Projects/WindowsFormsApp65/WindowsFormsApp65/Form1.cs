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

namespace WindowsFormsApp65
{
    public partial class Form1 : Form
    {
        public string Constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=empolyee101;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(Constr);
            con.Open();
            Form2 f2=new Form2();
            f2.Show();
            SqlCommand cmd = new SqlCommand("Select * from emp101", con);
            SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            Adpt.Fill(ds, "emp101");
            CrystalReport1 crl=new CrystalReport1();
            crl.SetDataSource(ds);
            f2.crystalReportViewer1.ReportSource= crl;
            f2.crystalReportViewer1.Refresh();


        }
    }
}
