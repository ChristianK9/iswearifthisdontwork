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
{
    public partial class Form4Invoices : Form
    {
        BindingNavigator invoicesBindingNavigator = new BindingNavigator(true);
        BindingSource invoicesBindingSource = new BindingSource();
        public Form4Invoices()
        {
            InitializeComponent();
        }

        private void Form4Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automotiveCRM_InvoicesTableDataSet_Reallydontdelete.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete.Table);//dont delete u need it
                                                                                                       
        }

        private void TableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(automotiveCRM_InvoicesTableDataSet_Reallydontdelete);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
