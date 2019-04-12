using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{//for some reason only invoices one works like how we want it to
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automotiveCRMDataSet_onForm1_DONTDELETE.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.automotiveCRMDataSet_onForm1_DONTDELETE.Table);
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            Form3Vehicle f3Vehicle = new Form3Vehicle();
            f3Vehicle.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form4Invoices f4invoices = new Form4Invoices();
            f4invoices.Show();
        }


        private void TableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
        }

        public void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(automotiveCRMDataSet_onForm1_DONTDELETE);
            //this.tableTableAdapter.Update(this.automotiveCRMDataSet_onForm1_DONTDELETE);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //this.tableTableAdapter.Fill(this.automotiveCRMDataSet_onForm1_DONTDELETE.Table);
        }
    }
}
