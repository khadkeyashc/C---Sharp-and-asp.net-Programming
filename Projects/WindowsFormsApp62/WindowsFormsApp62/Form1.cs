using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("WednesDay");
            comboBox1.Items.Add("Thursday");
            comboBox1.Items.Add("Friday");
            comboBox1.SelectedIndex = comboBox1.FindStringExact("Sunday");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var;
            var = comboBox1.Text;
            MessageBox.Show(var);
        }
    }
}
