namespace FinalProject
{
    partial class Form1
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
            this.automotiveCRMDataSet_onForm1_DONTDELETE = new FinalProject.AutomotiveCRMDataSet_onForm1_DONTDELETE();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new FinalProject.AutomotiveCRMDataSet_onForm1_DONTDELETETableAdapters.TableTableAdapter();
            this.f2OpenBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoicesbtnf1 = new System.Windows.Forms.Button();
            this.vehiclebtnf1 = new System.Windows.Forms.Button();
            this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete = new FinalProject.AutomotiveCRM_InvoicesTableDataSet_Reallydontdelete();
            this.automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new FinalProject.AutomotiveCRM_InvoicesTableDataSet_ReallydontdeleteTableAdapters.TableTableAdapter();
            this.automotiveCRMDataSetonForm1DONTDELETEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMDataSet_onForm1_DONTDELETE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMDataSetonForm1DONTDELETEBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // f2OpenBtn
            // 
            this.f2OpenBtn.Location = new System.Drawing.Point(90, 370);
            this.f2OpenBtn.Name = "f2OpenBtn";
            this.f2OpenBtn.Size = new System.Drawing.Size(164, 94);
            this.f2OpenBtn.TabIndex = 1;
            this.f2OpenBtn.Text = "Add Info";
            this.f2OpenBtn.UseVisualStyleBackColor = true;
            this.f2OpenBtn.Click += new System.EventHandler(this.F2OpenBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.altPhoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(5, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // invoicesbtnf1
            // 
            this.invoicesbtnf1.Location = new System.Drawing.Point(554, 61);
            this.invoicesbtnf1.Name = "invoicesbtnf1";
            this.invoicesbtnf1.Size = new System.Drawing.Size(75, 36);
            this.invoicesbtnf1.TabIndex = 2;
            this.invoicesbtnf1.Text = "Invoices";
            this.invoicesbtnf1.UseVisualStyleBackColor = true;
            this.invoicesbtnf1.Click += new System.EventHandler(this.Invoicesbtnf1_Click);
            // 
            // vehiclebtnf1
            // 
            this.vehiclebtnf1.Location = new System.Drawing.Point(554, 19);
            this.vehiclebtnf1.Name = "vehiclebtnf1";
            this.vehiclebtnf1.Size = new System.Drawing.Size(75, 36);
            this.vehiclebtnf1.TabIndex = 3;
            this.vehiclebtnf1.Text = "Vehicle";
            this.vehiclebtnf1.UseVisualStyleBackColor = true;
            this.vehiclebtnf1.Click += new System.EventHandler(this.Vehiclebtnf1_Click);
            // 
            // automotiveCRM_InvoicesTableDataSet_Reallydontdelete
            // 
            this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete.DataSetName = "AutomotiveCRM_InvoicesTableDataSet_Reallydontdelete";
            this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource
            // 
            this.automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource.DataSource = this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete;
            this.automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource.Position = 0;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.automotiveCRMDataSet_onForm1_DONTDELETE;
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // automotiveCRMDataSetonForm1DONTDELETEBindingSource
            // 
            this.automotiveCRMDataSetonForm1DONTDELETEBindingSource.DataSource = this.automotiveCRMDataSet_onForm1_DONTDELETE;
            this.automotiveCRMDataSetonForm1DONTDELETEBindingSource.Position = 0;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altPhoneNumberDataGridViewTextBoxColumn
            // 
            this.altPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Alt Phone Number";
            this.altPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Alt Phone Number";
            this.altPhoneNumberDataGridViewTextBoxColumn.Name = "altPhoneNumberDataGridViewTextBoxColumn";
            this.altPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 519);
            this.Controls.Add(this.vehiclebtnf1);
            this.Controls.Add(this.invoicesbtnf1);
            this.Controls.Add(this.f2OpenBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMDataSet_onForm1_DONTDELETE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRM_InvoicesTableDataSet_Reallydontdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotiveCRMDataSetonForm1DONTDELETEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AutomotiveCRMDataSet_onForm1_DONTDELETE automotiveCRMDataSet_onForm1_DONTDELETE;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AutomotiveCRMDataSet_onForm1_DONTDELETETableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button f2OpenBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicesTableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTableDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button invoicesbtnf1;
        private System.Windows.Forms.Button vehiclebtnf1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private AutomotiveCRM_InvoicesTableDataSet_Reallydontdelete automotiveCRM_InvoicesTableDataSet_Reallydontdelete;
        private System.Windows.Forms.BindingSource automotiveCRMInvoicesTableDataSetReallydontdeleteBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private AutomotiveCRM_InvoicesTableDataSet_ReallydontdeleteTableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.BindingSource automotiveCRMDataSetonForm1DONTDELETEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
    }
}

