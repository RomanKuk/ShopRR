namespace diagram.Forms.Users.SCEmployee
{
    partial class ServiceCenterEmployeeForm
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
            this.newSTButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ServiceTabPage = new System.Windows.Forms.TabPage();
            this.ServiceTransportationTabPage = new System.Windows.Forms.TabPage();
            this.RepairTabPage = new System.Windows.Forms.TabPage();
            this.repairButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.breakageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTransportationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serviceCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTransportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTransportationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serviceTransportationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.ServiceTabPage.SuspendLayout();
            this.ServiceTransportationTabPage.SuspendLayout();
            this.RepairTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newSTButton
            // 
            this.newSTButton.Location = new System.Drawing.Point(12, 415);
            this.newSTButton.Name = "newSTButton";
            this.newSTButton.Size = new System.Drawing.Size(139, 23);
            this.newSTButton.TabIndex = 5;
            this.newSTButton.Text = "Прийняти заявку";
            this.newSTButton.UseVisualStyleBackColor = true;
            this.newSTButton.Click += new System.EventHandler(this.NewSTButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServiceTabPage);
            this.tabControl1.Controls.Add(this.ServiceTransportationTabPage);
            this.tabControl1.Controls.Add(this.RepairTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 397);
            this.tabControl1.TabIndex = 6;
            // 
            // ServiceTabPage
            // 
            this.ServiceTabPage.Controls.Add(this.dataGridView1);
            this.ServiceTabPage.Location = new System.Drawing.Point(4, 22);
            this.ServiceTabPage.Name = "ServiceTabPage";
            this.ServiceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceTabPage.Size = new System.Drawing.Size(768, 371);
            this.ServiceTabPage.TabIndex = 0;
            this.ServiceTabPage.Text = "ServiceTabPage";
            this.ServiceTabPage.UseVisualStyleBackColor = true;
            // 
            // ServiceTransportationTabPage
            // 
            this.ServiceTransportationTabPage.Controls.Add(this.dataGridView2);
            this.ServiceTransportationTabPage.Location = new System.Drawing.Point(4, 22);
            this.ServiceTransportationTabPage.Name = "ServiceTransportationTabPage";
            this.ServiceTransportationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceTransportationTabPage.Size = new System.Drawing.Size(768, 371);
            this.ServiceTransportationTabPage.TabIndex = 1;
            this.ServiceTransportationTabPage.Text = "ServiceTransportationTabPage";
            this.ServiceTransportationTabPage.UseVisualStyleBackColor = true;
            // 
            // RepairTabPage
            // 
            this.RepairTabPage.Controls.Add(this.dataGridView3);
            this.RepairTabPage.Location = new System.Drawing.Point(4, 22);
            this.RepairTabPage.Name = "RepairTabPage";
            this.RepairTabPage.Size = new System.Drawing.Size(768, 371);
            this.RepairTabPage.TabIndex = 2;
            this.RepairTabPage.Text = "RepairTabPage";
            this.RepairTabPage.UseVisualStyleBackColor = true;
            // 
            // repairButton
            // 
            this.repairButton.Location = new System.Drawing.Point(173, 415);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(134, 23);
            this.repairButton.TabIndex = 4;
            this.repairButton.Text = "процес ремонту";
            this.repairButton.UseVisualStyleBackColor = true;
            this.repairButton.Click += new System.EventHandler(this.RepairButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.breakageIDDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn,
            this.basketIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(521, 238);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTransportationIDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn1,
            this.serviceIDDataGridViewTextBoxColumn1,
            this.sCIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.serviceTransportationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(580, 274);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairIDDataGridViewTextBoxColumn,
            this.serviceTransportationIDDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.repairBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(13, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // breakageIDDataGridViewTextBoxColumn
            // 
            this.breakageIDDataGridViewTextBoxColumn.DataPropertyName = "Breakage_ID";
            this.breakageIDDataGridViewTextBoxColumn.DataSource = this.breakageBindingSource;
            this.breakageIDDataGridViewTextBoxColumn.DisplayMember = "Breakage1";
            this.breakageIDDataGridViewTextBoxColumn.HeaderText = "Breakage_ID";
            this.breakageIDDataGridViewTextBoxColumn.Name = "breakageIDDataGridViewTextBoxColumn";
            this.breakageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.breakageIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.breakageIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.breakageIDDataGridViewTextBoxColumn.ValueMember = "Breakage_ID";
            // 
            // breakageBindingSource
            // 
            this.breakageBindingSource.DataSource = typeof(diagram.Breakage);
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "Status_ID";
            this.statusIDDataGridViewTextBoxColumn.DataSource = this.statusBindingSource;
            this.statusIDDataGridViewTextBoxColumn.DisplayMember = "Status1";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "Status_ID";
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusIDDataGridViewTextBoxColumn.ValueMember = "Status_ID";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(diagram.Status);
            // 
            // basketIDDataGridViewTextBoxColumn
            // 
            this.basketIDDataGridViewTextBoxColumn.DataPropertyName = "Basket_ID";
            this.basketIDDataGridViewTextBoxColumn.DataSource = this.basketBindingSource;
            this.basketIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.basketIDDataGridViewTextBoxColumn.HeaderText = "Basket_ID";
            this.basketIDDataGridViewTextBoxColumn.Name = "basketIDDataGridViewTextBoxColumn";
            this.basketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.basketIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.basketIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.basketIDDataGridViewTextBoxColumn.ValueMember = "Basket_ID";
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataSource = typeof(diagram.Basket);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(diagram.Service);
            // 
            // serviceTransportationIDDataGridViewTextBoxColumn
            // 
            this.serviceTransportationIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceTransportation_ID";
            this.serviceTransportationIDDataGridViewTextBoxColumn.HeaderText = "ServiceTransportation_ID";
            this.serviceTransportationIDDataGridViewTextBoxColumn.Name = "serviceTransportationIDDataGridViewTextBoxColumn";
            this.serviceTransportationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceTransportationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            this.codeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serviceIDDataGridViewTextBoxColumn1
            // 
            this.serviceIDDataGridViewTextBoxColumn1.DataPropertyName = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn1.DataSource = this.serviceBindingSource1;
            this.serviceIDDataGridViewTextBoxColumn1.DisplayMember = "Code";
            this.serviceIDDataGridViewTextBoxColumn1.HeaderText = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn1.Name = "serviceIDDataGridViewTextBoxColumn1";
            this.serviceIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.serviceIDDataGridViewTextBoxColumn1.ValueMember = "Service_ID";
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataSource = typeof(diagram.Service);
            // 
            // sCIDDataGridViewTextBoxColumn
            // 
            this.sCIDDataGridViewTextBoxColumn.DataPropertyName = "SC_ID";
            this.sCIDDataGridViewTextBoxColumn.DataSource = this.serviceCenterBindingSource;
            this.sCIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.sCIDDataGridViewTextBoxColumn.HeaderText = "SC_ID";
            this.sCIDDataGridViewTextBoxColumn.Name = "sCIDDataGridViewTextBoxColumn";
            this.sCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sCIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sCIDDataGridViewTextBoxColumn.ValueMember = "SC_ID";
            // 
            // serviceCenterBindingSource
            // 
            this.serviceCenterBindingSource.DataSource = typeof(diagram.ServiceCenter);
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serviceTransportationBindingSource
            // 
            this.serviceTransportationBindingSource.DataSource = typeof(diagram.ServiceTransportation);
            // 
            // repairIDDataGridViewTextBoxColumn
            // 
            this.repairIDDataGridViewTextBoxColumn.DataPropertyName = "Repair_ID";
            this.repairIDDataGridViewTextBoxColumn.HeaderText = "Repair_ID";
            this.repairIDDataGridViewTextBoxColumn.Name = "repairIDDataGridViewTextBoxColumn";
            this.repairIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.repairIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceTransportationIDDataGridViewTextBoxColumn1
            // 
            this.serviceTransportationIDDataGridViewTextBoxColumn1.DataPropertyName = "ServiceTransportation_ID";
            this.serviceTransportationIDDataGridViewTextBoxColumn1.DataSource = this.serviceTransportationBindingSource1;
            this.serviceTransportationIDDataGridViewTextBoxColumn1.DisplayMember = "Code";
            this.serviceTransportationIDDataGridViewTextBoxColumn1.HeaderText = "ServiceTransportation_ID";
            this.serviceTransportationIDDataGridViewTextBoxColumn1.Name = "serviceTransportationIDDataGridViewTextBoxColumn1";
            this.serviceTransportationIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.serviceTransportationIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceTransportationIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.serviceTransportationIDDataGridViewTextBoxColumn1.ValueMember = "ServiceTransportation_ID";
            // 
            // serviceTransportationBindingSource1
            // 
            this.serviceTransportationBindingSource1.DataSource = typeof(diagram.ServiceTransportation);
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn2
            // 
            this.dateDataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn2.Name = "dateDataGridViewTextBoxColumn2";
            this.dateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataSource = typeof(diagram.Repair);
            // 
            // ServiceCenterEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newSTButton);
            this.Controls.Add(this.repairButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServiceCenterEmployeeForm";
            this.Text = "ServiceCenterEmployeeForm";
            this.Load += new System.EventHandler(this.ServiceCenterForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ServiceTabPage.ResumeLayout(false);
            this.ServiceTransportationTabPage.ResumeLayout(false);
            this.RepairTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newSTButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ServiceTabPage;
        private System.Windows.Forms.TabPage ServiceTransportationTabPage;
        private System.Windows.Forms.TabPage RepairTabPage;
        private System.Windows.Forms.Button repairButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn breakageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource breakageBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn basketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTransportationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceCenterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource serviceTransportationBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceTransportationIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource serviceTransportationBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource repairBindingSource;
    }
}