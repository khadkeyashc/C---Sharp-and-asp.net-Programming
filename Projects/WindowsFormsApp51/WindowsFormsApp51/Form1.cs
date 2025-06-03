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

namespace WindowsFormsApp51
{
    public partial class Form1 : Form
    {
        public string constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=employee32;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection(constr);
            
            con.Open();
            Form2 f2 = new Form2();
            f2.Show();
            SqlCommand cmd = new SqlCommand("select * from emp31", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds,"emp31");
            CrystalReport1 cr1=new CrystalReport1();
            cr1.SetDataSource(ds);
            f2.crystalReportViewer1.ReportSource= cr1;
            f2.crystalReportViewer1.Refresh();
            con.Close();




        }
    }
}
