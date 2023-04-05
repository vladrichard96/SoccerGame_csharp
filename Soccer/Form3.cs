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
    public partial class Form3 : Form
    {
        public Form3()
        {
            Program.f2.home.Goals = Program.f2.away.Goals = 0;
            InitializeComponent();
            label1.Text = Convert.ToString(Program.f2.MatchTime*60);
            label2.Text = Program.f2.home.Name;
            label3.Text = Program.f2.away.Name;
            label4.Text = Convert.ToString(Program.f2.home.Goals);
            label5.Text = Convert.ToString(Program.f2.away.Goals);
        }
    }
}
