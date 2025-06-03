using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Width = 150;
            textBox1.Height = 50;
            textBox1.Multiline = true;
            textBox1.BackColor = Color.Blue;
            textBox1.ForeColor= Color.Red;
            textBox1.BorderStyle = BorderStyle.Fixed3D;



            label1.Text = "This is my second Program";
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Image = Image.FromFile(@"F:\Wallpapers\37946.jpg");
            button1.Text = "Click Here";
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
          
    }
}
