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
    public partial class Form3Vehicle : Form
    {
        BindingNavigator vehicleBindingNavigator = new BindingNavigator(true);
        BindingSource vehicleBindingSource = new BindingSource();
        public Form3Vehicle()
        {
            InitializeComponent();
        }

        private void Form3Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.ThisOneIsTheVehicleTable' table. You can move, or remove it, as needed.
            //this.thisOneIsTheVehicleTableTableAdapter.Fill(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.ThisOneIsTheVehicleTable);
            this.tableTableAdapter1.Fill(this.automotiveCRMDataSet_onForm1_DONTDELETE.Table);
            //this.tableTableAdapter.Fill(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.Table);//dont delete

        }

        private void VehicleTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thisOneIsTheVehicleTableBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE);
            //(automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE);

            //this.thisOneIsTheVehicleTableTableAdapter.Update(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.ThisOneIsTheVehicleTable);

            //try
            {
                //this.Validate();
                //this.thisOneIsTheVehicleTableBindingSource1.EndEdit();
                {
                    //this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.EnforceConstraints = false;
                }
                //this.thisOneIsTheVehicleTableTableAdapter.Update(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.ThisOneIsTheVehicleTable);
                //MessageBox.Show("Update Successful");
                //this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.AcceptChanges();
                {
                    //this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.EnforceConstraints = true;
                }
                //this.thisOneIsTheVehicleTableTableAdapter.Adapter.Fill(automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE);
            }
            //catch
            {
                //MessageBox.Show("ERROR");
            }
            

            //this.thisOneIsTheVehicleTableTableAdapter.Update(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE);

            //this.tableAdapterManager.UpdateAll(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE);
            //this.tableAdapterManager.ThisOneIsTheVehicleTableTableAdapter.Update(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE);
            //this.thisOneIsTheVehicleTableTableAdapter.Update(this.automotiveCRM_VehicleTableDataSet_onForm3_DONTDELETE.ThisOneIsTheVehicleTable);
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
