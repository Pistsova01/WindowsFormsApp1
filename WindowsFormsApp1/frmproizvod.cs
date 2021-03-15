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
    public partial class frmproizvod : Form
    {
        public frmproizvod()
        {
            InitializeComponent();
        }

        private void laptopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st26DataSet);

        }

        private void frmproizvod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st26DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st26DataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st26DataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st26DataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st26DataSet.PC". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st26DataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st26DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st26DataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st26DataSet.Laptop". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st26DataSet.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveFirst();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st26DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st26DataSet);
        }
    }
}
