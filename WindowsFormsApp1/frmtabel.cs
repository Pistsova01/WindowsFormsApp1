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
    public partial class frmtabel : Form
    {
        public frmtabel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmtabel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st26DataSet.sabaka". При необходимости она может быть перемещена или удалена.
            this.sabakaTableAdapter.Fill(this.st26DataSet.sabaka);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn Col;
        private void button5_Click(object sender, EventArgs e)
        {
            Col = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
            }
            if (radioButton1.Checked)
                sabakaDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                sabakaDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sabakaBindingSource.Filter = "Name='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sabakaBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)

        {
            for (int i = 0; i < sabakaDataGridView.ColumnCount - 1; i++)
            {
                for (int j=0; j<sabakaDataGridView.RowCount-1;j++)
            }
            {
                sabakaDataGridView[i, j].Style.BackColor = Color.White;
                sabakaDataGridView[i, j].Style.BackColor = Color.Black;
            }
            
                for (int i=0; i<sabakaDataGridView.ColumnCount-1;i++)
            
            
                for (int j=0; j<sabakaDataGridView.RowCount-1;j++)


                 if (sabakaDataGridView[i,j]).val
            
       
        }

          
            

            

        
    }
}
