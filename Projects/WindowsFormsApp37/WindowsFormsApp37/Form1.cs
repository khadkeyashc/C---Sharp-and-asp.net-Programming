using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sunday");
            listBox1.Items.Add("Monday");
            listBox1.Items.Add("TuesDay");
            listBox1.Items.Add("Wednesday");
            listBox1.Items.Add("Thursday");
            listBox1.Items.Add("Friday");
            listBox1.Items.Add("SaturDay");
            listBox1.SelectionMode = SelectionMode.MultiSimple;






        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Object obj in listBox1.SelectedItems)
            {
                MessageBox.Show(obj.ToString())
;            }
        }
    }

}
