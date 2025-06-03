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

namespace WindowsFormsApp52
{
    public partial class Form1 : Form
    {
        public string constr = "Data Source=LAPTOP-R5EN8901;Initial Catalog=employee31;Integrated Security=True";
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
            String q = "insert into emp30(id,name)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Sucessfully");
        }
    }
}
