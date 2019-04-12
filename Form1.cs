using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'automotiveCRM_InvoicesTableDataSet_Reallydontdelete.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete.Table);
            // TODO: This line of code loads data into the 'automotiveCRMDataSet_onForm1_DONTDELETE.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.automotiveCRMDataSet_onForm1_DONTDELETE.Table);
            this.tableTableAdapter.Update(this.automotiveCRMDataSet_onForm1_DONTDELETE.Table);

        }

        private void ValidateRow(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
            BindingSource bindingSource = (BindingSource)dataGridView1.DataSource;
            DataTable changes = (DataTable)bindingSource.DataSource;
            changes.GetChanges();

            if(changes != null)
            {
               
            }

            changes.AcceptChanges();
        }

        private void F2OpenBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void Vehiclebtnf1_Click(object sender, EventArgs e)
        {
            Form3Vehicle f3Vehicle = new Form3Vehicle();
            f3Vehicle.Show();
        }

        private void Invoicesbtnf1_Click(object sender, EventArgs e)
        {
            Form4Invoices f4invoices = new Form4Invoices();
            f4invoices.Show();
        }
        
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
