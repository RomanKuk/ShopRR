namespace diagram.Forms.expeditor
{
    partial class ExpeditorForm
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
            this.newProvideOrder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DeliveryTabPage = new System.Windows.Forms.TabPage();
            this.DeliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.deliverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provideOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.provideOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShipmentTabPage = new System.Windows.Forms.TabPage();
            this.ShipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.shipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsShopsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsShopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newShipment = new System.Windows.Forms.Button();
            this.newService = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.DeliveryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.ShipmentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newProvideOrder
            // 
            this.newProvideOrder.Location = new System.Drawing.Point(12, 415);
            this.newProvideOrder.Name = "newProvideOrder";
            this.newProvideOrder.Size = new System.Drawing.Size(169, 23);
            this.newProvideOrder.TabIndex = 0;
            this.newProvideOrder.Text = "Зробити замовлення";
            this.newProvideOrder.UseVisualStyleBackColor = true;
            this.newProvideOrder.Click += new System.EventHandler(this.NewProvideOrder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DeliveryTabPage);
            this.tabControl1.Controls.Add(this.ShipmentTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // DeliveryTabPage
            // 
            this.DeliveryTabPage.Controls.Add(this.DeliveryDataGridView);
            this.DeliveryTabPage.Location = new System.Drawing.Point(4, 22);
            this.DeliveryTabPage.Name = "DeliveryTabPage";
            this.DeliveryTabPage.Size = new System.Drawing.Size(768, 362);
            this.DeliveryTabPage.TabIndex = 0;
            this.DeliveryTabPage.Text = "Доставки";
            this.DeliveryTabPage.UseVisualStyleBackColor = true;
            // 
            // DeliveryDataGridView
            // 
            this.DeliveryDataGridView.AllowUserToAddRows = false;
            this.DeliveryDataGridView.AllowUserToDeleteRows = false;
            this.DeliveryDataGridView.AutoGenerateColumns = false;
            this.DeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliverIDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.goodIDDataGridViewTextBoxColumn,
            this.provideOrderIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.DeliveryDataGridView.DataSource = this.deliveryBindingSource;
            this.DeliveryDataGridView.Location = new System.Drawing.Point(34, 35);
            this.DeliveryDataGridView.Name = "DeliveryDataGridView";
            this.DeliveryDataGridView.ReadOnly = true;
            this.DeliveryDataGridView.Size = new System.Drawing.Size(283, 207);
            this.DeliveryDataGridView.TabIndex = 0;
            // 
            // deliverIDDataGridViewTextBoxColumn
            // 
            this.deliverIDDataGridViewTextBoxColumn.DataPropertyName = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.HeaderText = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.Name = "deliverIDDataGridViewTextBoxColumn";
            this.deliverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodIDDataGridViewTextBoxColumn
            // 
            this.goodIDDataGridViewTextBoxColumn.DataPropertyName = "Good_ID";
            this.goodIDDataGridViewTextBoxColumn.DataSource = this.goodsBindingSource;
            this.goodIDDataGridViewTextBoxColumn.DisplayMember = "Model";
            this.goodIDDataGridViewTextBoxColumn.HeaderText = "Good_ID";
            this.goodIDDataGridViewTextBoxColumn.Name = "goodIDDataGridViewTextBoxColumn";
            this.goodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goodIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.goodIDDataGridViewTextBoxColumn.ValueMember = "Good_ID";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(diagram.Goods);
            // 
            // provideOrderIDDataGridViewTextBoxColumn
            // 
            this.provideOrderIDDataGridViewTextBoxColumn.DataPropertyName = "ProvideOrder_ID";
            this.provideOrderIDDataGridViewTextBoxColumn.DataSource = this.provideOrderBindingSource;
            this.provideOrderIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.provideOrderIDDataGridViewTextBoxColumn.HeaderText = "ProvideOrder_ID";
            this.provideOrderIDDataGridViewTextBoxColumn.Name = "provideOrderIDDataGridViewTextBoxColumn";
            this.provideOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.provideOrderIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.provideOrderIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.provideOrderIDDataGridViewTextBoxColumn.ValueMember = "ProvideOrder_ID";
            // 
            // provideOrderBindingSource
            // 
            this.provideOrderBindingSource.DataSource = typeof(diagram.ProvideOrder);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(diagram.Delivery);
            // 
            // ShipmentTabPage
            // 
            this.ShipmentTabPage.Controls.Add(this.ShipmentDataGridView);
            this.ShipmentTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShipmentTabPage.Name = "ShipmentTabPage";
            this.ShipmentTabPage.Size = new System.Drawing.Size(768, 362);
            this.ShipmentTabPage.TabIndex = 1;
            this.ShipmentTabPage.Text = "Відвантаження";
            this.ShipmentTabPage.UseVisualStyleBackColor = true;
            // 
            // ShipmentDataGridView
            // 
            this.ShipmentDataGridView.AllowUserToAddRows = false;
            this.ShipmentDataGridView.AllowUserToDeleteRows = false;
            this.ShipmentDataGridView.AutoGenerateColumns = false;
            this.ShipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipmentIDDataGridViewTextBoxColumn,
            this.deliverIDDataGridViewTextBoxColumn1,
            this.goodsShopsIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1});
            this.ShipmentDataGridView.DataSource = this.shipmentBindingSource;
            this.ShipmentDataGridView.Location = new System.Drawing.Point(18, 15);
            this.ShipmentDataGridView.Name = "ShipmentDataGridView";
            this.ShipmentDataGridView.ReadOnly = true;
            this.ShipmentDataGridView.Size = new System.Drawing.Size(582, 253);
            this.ShipmentDataGridView.TabIndex = 0;
            // 
            // shipmentIDDataGridViewTextBoxColumn
            // 
            this.shipmentIDDataGridViewTextBoxColumn.DataPropertyName = "Shipment_ID";
            this.shipmentIDDataGridViewTextBoxColumn.HeaderText = "Shipment_ID";
            this.shipmentIDDataGridViewTextBoxColumn.Name = "shipmentIDDataGridViewTextBoxColumn";
            this.shipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shipmentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliverIDDataGridViewTextBoxColumn1
            // 
            this.deliverIDDataGridViewTextBoxColumn1.DataPropertyName = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn1.DataSource = this.deliveryBindingSource;
            this.deliverIDDataGridViewTextBoxColumn1.DisplayMember = "Code";
            this.deliverIDDataGridViewTextBoxColumn1.HeaderText = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn1.Name = "deliverIDDataGridViewTextBoxColumn1";
            this.deliverIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.deliverIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deliverIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deliverIDDataGridViewTextBoxColumn1.ValueMember = "Deliver_ID";
            // 
            // goodsShopsIDDataGridViewTextBoxColumn
            // 
            this.goodsShopsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsShops_ID";
            this.goodsShopsIDDataGridViewTextBoxColumn.DataSource = this.goodsShopsBindingSource;
            this.goodsShopsIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.goodsShopsIDDataGridViewTextBoxColumn.HeaderText = "GoodsShops_ID";
            this.goodsShopsIDDataGridViewTextBoxColumn.Name = "goodsShopsIDDataGridViewTextBoxColumn";
            this.goodsShopsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsShopsIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsShopsIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.goodsShopsIDDataGridViewTextBoxColumn.ValueMember = "GoodsShops_ID";
            // 
            // goodsShopsBindingSource
            // 
            this.goodsShopsBindingSource.DataSource = typeof(diagram.GoodsShops);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
            this.employeeIDDataGridViewTextBoxColumn.DisplayMember = "LastName";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeIDDataGridViewTextBoxColumn.ValueMember = "Employee_ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataSource = typeof(diagram.Shipment);
            // 
            // newShipment
            // 
            this.newShipment.Location = new System.Drawing.Point(231, 415);
            this.newShipment.Name = "newShipment";
            this.newShipment.Size = new System.Drawing.Size(162, 23);
            this.newShipment.TabIndex = 2;
            this.newShipment.Text = "Прийом товару";
            this.newShipment.UseVisualStyleBackColor = true;
            this.newShipment.Click += new System.EventHandler(this.NewShipment_Click);
            // 
            // newService
            // 
            this.newService.Location = new System.Drawing.Point(451, 415);
            this.newService.Name = "newService";
            this.newService.Size = new System.Drawing.Size(146, 23);
            this.newService.TabIndex = 3;
            this.newService.Text = "Товар в ремонт";
            this.newService.UseVisualStyleBackColor = true;
            this.newService.Click += new System.EventHandler(this.NewService_Click);
            // 
            // ExpeditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newService);
            this.Controls.Add(this.newShipment);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.newProvideOrder);
            this.Name = "ExpeditorForm";
            this.Text = "ExpeditorForm";
            this.Load += new System.EventHandler(this.ExpeditorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.DeliveryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ShipmentTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newProvideOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DeliveryTabPage;
        private System.Windows.Forms.TabPage ShipmentTabPage;
        private System.Windows.Forms.Button newShipment;
        private System.Windows.Forms.DataGridView DeliveryDataGridView;
        private System.Windows.Forms.DataGridView ShipmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn goodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn provideOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource provideOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn deliverIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn goodsShopsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsShopsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private System.Windows.Forms.Button newService;
    }
}