using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmdesktop frmdesktop = new frmdesktop();
            this.Hide();
            frmdesktop.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmprinter frmprinter = new frmprinter();
            this.Hide();
            frmprinter.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmlaptop frmlaptop = new frmlaptop();
            this.Hide();
            frmlaptop.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmproizvod frmproizvod = new frmproizvod();
            this.Hide();
            frmproizvod.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
