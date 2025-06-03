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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = "Data Source=LAPTOP-R5EN8901;Initial Catalog=STUDENT;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("insert into student_detail values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "')", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Saved...");
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("delete from student_detail where roll_no = " + textBox2.Text + " ", conn);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Deleted...");
                textBox3.Clear();
                textBox4.Clear();
                textBox2.Clear();
                textBox1.Clear();
                textBox1.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(" Not Deleted" + x.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("select * from student_detail where roll_no = " + textBox1.Text + " ", conn);
            try
            {
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    textBox2.Text = dreader[1].ToString();
                    textBox3.Text = dreader[2].ToString();
                    textBox4.Text = dreader[3].ToString();
                }
                else
                {
                    MessageBox.Show(" No Record");
                }
                dreader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" No Record");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("update student_detail set s_name= '" + textBox2.Text + "', age= " + textBox3.Text + " , course=' " + textBox4.Text + "' where roll_no =     "+textBox1.Text+" ", conn);  
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Updated..");
            }
            catch (Exception)
            {
                MessageBox.Show(" Not Updated");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
