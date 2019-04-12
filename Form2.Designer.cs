namespace FinalProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label invoices__Table_Label;
            System.Windows.Forms.Label vehicle__Table_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label addressLabel1;
            System.Windows.Forms.Label phone_NumberLabel1;
            System.Windows.Forms.Label alt_Phone_NumberLabel1;
            System.Windows.Forms.Label email_AddressLabel1;
            this.automotiveCRMDataSet_onForm1_DONTDELETE = new FinalProject.AutomotiveCRMDataSet_onForm1_DONTDELETE();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new FinalProject.AutomotiveCRMDataSet_onForm1_DONTDELETETableAdapters.TableTableAdapter();
            this.tableAdapterManager = new FinalProject.AutomotiveCRMDataSet_onForm1_DONTDELETETableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox1 = new System.Windows.Forms.TextBox();
            this.alt_Phone_NumberTextBox1 = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            invoices__Table_Label = new System.Windows.Forms.Label();
            vehicle__Table_Label = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            addressLabel1 = new System.Windows.Forms.Label();
            phone_NumberLabel1 = new System.Windows.Forms.Label();
            alt_Phone_NumberLabel1 = new System.Windows.Forms.Label();
            email_AddressLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMDataSet_onForm1_DONTDELETE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoices__Table_Label
            // 
            invoices__Table_Label.AutoSize = true;
            invoices__Table_Label.Location = new System.Drawing.Point(66, 245);
            invoices__Table_Label.Name = "invoices__Table_Label";
            invoices__Table_Label.Size = new System.Drawing.Size(86, 13);
            invoices__Table_Label.TabIndex = 13;
            invoices__Table_Label.Text = "Invoices (Table):";
            // 
            // vehicle__Table_Label
            // 
            vehicle__Table_Label.AutoSize = true;
            vehicle__Table_Label.Location = new System.Drawing.Point(71, 214);
            vehicle__Table_Label.Name = "vehicle__Table_Label";
            vehicle__Table_Label.Size = new System.Drawing.Size(81, 13);
            vehicle__Table_Label.TabIndex = 11;
            vehicle__Table_Label.Text = "Vehicle (Table):";
            // 
            // automotiveCRMDataSet_onForm1_DONTDELETE
            // 
            this.automotiveCRMDataSet_onForm1_DONTDELETE.DataSetName = "AutomotiveCRMDataSet_onForm1_DONTDELETE";
            this.automotiveCRMDataSet_onForm1_DONTDELETE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.automotiveCRMDataSet_onForm1_DONTDELETE;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = FinalProject.AutomotiveCRMDataSet_onForm1_DONTDELETETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.TableBindingNavigatorSaveItem_Click);
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource1;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1048, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.automotiveCRMDataSet_onForm1_DONTDELETE;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Invoices";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Vehicles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(66, 80);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 16;
            nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(168, 77);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 17;
            // 
            // addressLabel1
            // 
            addressLabel1.AutoSize = true;
            addressLabel1.Location = new System.Drawing.Point(66, 106);
            addressLabel1.Name = "addressLabel1";
            addressLabel1.Size = new System.Drawing.Size(48, 13);
            addressLabel1.TabIndex = 18;
            addressLabel1.Text = "Address:";
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(168, 103);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox1.TabIndex = 19;
            // 
            // phone_NumberLabel1
            // 
            phone_NumberLabel1.AutoSize = true;
            phone_NumberLabel1.Location = new System.Drawing.Point(66, 132);
            phone_NumberLabel1.Name = "phone_NumberLabel1";
            phone_NumberLabel1.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel1.TabIndex = 20;
            phone_NumberLabel1.Text = "Phone Number:";
            // 
            // phone_NumberTextBox1
            // 
            this.phone_NumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Phone Number", true));
            this.phone_NumberTextBox1.Location = new System.Drawing.Point(168, 129);
            this.phone_NumberTextBox1.Name = "phone_NumberTextBox1";
            this.phone_NumberTextBox1.Size = new System.Drawing.Size(100, 20);
            this.phone_NumberTextBox1.TabIndex = 21;
            // 
            // alt_Phone_NumberLabel1
            // 
            alt_Phone_NumberLabel1.AutoSize = true;
            alt_Phone_NumberLabel1.Location = new System.Drawing.Point(66, 158);
            alt_Phone_NumberLabel1.Name = "alt_Phone_NumberLabel1";
            alt_Phone_NumberLabel1.Size = new System.Drawing.Size(96, 13);
            alt_Phone_NumberLabel1.TabIndex = 22;
            alt_Phone_NumberLabel1.Text = "Alt Phone Number:";
            // 
            // alt_Phone_NumberTextBox1
            // 
            this.alt_Phone_NumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Alt Phone Number", true));
            this.alt_Phone_NumberTextBox1.Location = new System.Drawing.Point(168, 155);
            this.alt_Phone_NumberTextBox1.Name = "alt_Phone_NumberTextBox1";
            this.alt_Phone_NumberTextBox1.Size = new System.Drawing.Size(100, 20);
            this.alt_Phone_NumberTextBox1.TabIndex = 23;
            // 
            // email_AddressLabel1
            // 
            email_AddressLabel1.AutoSize = true;
            email_AddressLabel1.Location = new System.Drawing.Point(66, 184);
            email_AddressLabel1.Name = "email_AddressLabel1";
            email_AddressLabel1.Size = new System.Drawing.Size(76, 13);
            email_AddressLabel1.TabIndex = 24;
            email_AddressLabel1.Text = "Email Address:";
            // 
            // email_AddressTextBox1
            // 
            this.email_AddressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource1, "Email Address", true));
            this.email_AddressTextBox1.Location = new System.Drawing.Point(168, 181);
            this.email_AddressTextBox1.Name = "email_AddressTextBox1";
            this.email_AddressTextBox1.Size = new System.Drawing.Size(100, 20);
            this.email_AddressTextBox1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.altPhoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(370, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(678, 540);
            this.dataGridView1.TabIndex = 26;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altPhoneNumberDataGridViewTextBoxColumn
            // 
            this.altPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Alt Phone Number";
            this.altPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Alt Phone Number";
            this.altPhoneNumberDataGridViewTextBoxColumn.Name = "altPhoneNumberDataGridViewTextBoxColumn";
            this.altPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(addressLabel1);
            this.Controls.Add(this.addressTextBox1);
            this.Controls.Add(phone_NumberLabel1);
            this.Controls.Add(this.phone_NumberTextBox1);
            this.Controls.Add(alt_Phone_NumberLabel1);
            this.Controls.Add(this.alt_Phone_NumberTextBox1);
            this.Controls.Add(email_AddressLabel1);
            this.Controls.Add(this.email_AddressTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(vehicle__Table_Label);
            this.Controls.Add(invoices__Table_Label);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMDataSet_onForm1_DONTDELETE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutomotiveCRMDataSet_onForm1_DONTDELETE automotiveCRMDataSet_onForm1_DONTDELETE;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AutomotiveCRMDataSet_onForm1_DONTDELETETableAdapters.TableTableAdapter tableTableAdapter;
        private AutomotiveCRMDataSet_onForm1_DONTDELETETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox phone_NumberTextBox1;
        private System.Windows.Forms.TextBox alt_Phone_NumberTextBox1;
        private System.Windows.Forms.TextBox email_AddressTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
    }
}