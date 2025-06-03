using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "hii fucker";
            this.BackColor = Color.Yellow;
            this.Size = new Size(300, 500);
            this.Location = new Point(400, 400);
            this.MaximizeBox = false;
        }
    }
}
