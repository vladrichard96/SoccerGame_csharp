using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool SinglePlayer = false;
        public bool MultiPlayer = false;
        private void button1_Click(object sender, EventArgs e)
        {
            SinglePlayer = true;
            Program.f2 = new Form2();
            Program.f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MultiPlayer = true;
        }
    }

}  


