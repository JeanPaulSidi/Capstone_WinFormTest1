using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_WinFormTest1
{
    public partial class Form1 : Form
    {
        Combination Combi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Combi = new Combination();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Combi.Give();
            label1.Text = Combi.GetCombination();
            label1.Visible = true;
        }
    }
}
