using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submit");
            label4.Text = "id is" + textBox1.Text + "name is" + textBox2.Text + "Age is:" + textBox3.Text;
        }
    }
}
