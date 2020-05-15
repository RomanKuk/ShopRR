namespace diagram.Forms.Users.Expeditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.backToHomeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DeliveryTabPage = new System.Windows.Forms.TabPage();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.deliverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provideOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.provideOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advancedDataSet = new diagram.advancedDataSet();
            this.ShipmentTabPage = new System.Windows.Forms.TabPage();
            this.advancedDataGridView2 = new Zuby.ADGV.AdvancedDataGridView();
            this.deliveryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsShopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.newShipmentBtn = new System.Windows.Forms.Button();
            this.newServiceBtn = new System.Windows.Forms.Button();
            this.newProvideOrder = new System.Windows.Forms.Button();
            this.deliveryTableAdapter = new diagram.advancedDataSetTableAdapters.DeliveryTableAdapter();
            this.shipmentTableAdapter = new diagram.advancedDataSetTableAdapters.ShipmentTableAdapter();
            this.shipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsShopsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DeliveryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataSet)).BeginInit();
            this.ShipmentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 45);
            this.panel2.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(383, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(499, 45);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Controls.Add(this.minimizeBtn);
            this.panel4.Controls.Add(this.backToHomeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(882, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 45);
            this.panel4.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::diagram.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(79, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 38);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackgroundImage = global::diagram.Properties.Resources.minimize_icon;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(40, 4);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(38, 38);
            this.minimizeBtn.TabIndex = 12;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backToHomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backToHomeBtn.FlatAppearance.BorderSize = 0;
            this.backToHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHomeBtn.Image = global::diagram.Properties.Resources.home_icon;
            this.backToHomeBtn.Location = new System.Drawing.Point(1, 4);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(38, 38);
            this.backToHomeBtn.TabIndex = 13;
            this.backToHomeBtn.UseVisualStyleBackColor = true;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.formTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 45);
            this.panel3.TabIndex = 1;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTitle.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Purple;
            this.formTitle.Location = new System.Drawing.Point(0, 0);
            this.formTitle.Margin = new System.Windows.Forms.Padding(3);
            this.formTitle.Name = "formTitle";
            this.formTitle.Padding = new System.Windows.Forms.Padding(6);
            this.formTitle.Size = new System.Drawing.Size(311, 42);
            this.formTitle.TabIndex = 4;
            this.formTitle.Text = "Менеджер-експедитор";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 555);
            this.panel1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DeliveryTabPage);
            this.tabControl1.Controls.Add(this.ShipmentTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // DeliveryTabPage
            // 
            this.DeliveryTabPage.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeliveryTabPage.Controls.Add(this.advancedDataGridView1);
            this.DeliveryTabPage.Location = new System.Drawing.Point(4, 36);
            this.DeliveryTabPage.Name = "DeliveryTabPage";
            this.DeliveryTabPage.Size = new System.Drawing.Size(992, 414);
            this.DeliveryTabPage.TabIndex = 0;
            this.DeliveryTabPage.Text = "Поставки";
            this.DeliveryTabPage.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.advancedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.ColumnHeadersHeight = 30;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliverIDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.goodIDDataGridViewTextBoxColumn,
            this.provideOrderIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.deliveryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView1.Size = new System.Drawing.Size(990, 412);
            this.advancedDataGridView1.TabIndex = 0;
            // 
            // deliverIDDataGridViewTextBoxColumn
            // 
            this.deliverIDDataGridViewTextBoxColumn.DataPropertyName = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.HeaderText = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.deliverIDDataGridViewTextBoxColumn.Name = "deliverIDDataGridViewTextBoxColumn";
            this.deliverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.deliverIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код товару";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // goodIDDataGridViewTextBoxColumn
            // 
            this.goodIDDataGridViewTextBoxColumn.DataPropertyName = "Good_ID";
            this.goodIDDataGridViewTextBoxColumn.DataSource = this.goodsBindingSource;
            this.goodIDDataGridViewTextBoxColumn.DisplayMember = "Model";
            this.goodIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.goodIDDataGridViewTextBoxColumn.HeaderText = "Код товару";
            this.goodIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.goodIDDataGridViewTextBoxColumn.Name = "goodIDDataGridViewTextBoxColumn";
            this.goodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goodIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.provideOrderIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.provideOrderIDDataGridViewTextBoxColumn.HeaderText = "Код загального замовлення (партії)";
            this.provideOrderIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.provideOrderIDDataGridViewTextBoxColumn.Name = "provideOrderIDDataGridViewTextBoxColumn";
            this.provideOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.provideOrderIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.provideOrderIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.provideOrderIDDataGridViewTextBoxColumn.ValueMember = "ProvideOrder_ID";
            // 
            // provideOrderBindingSource
            // 
            this.provideOrderBindingSource.DataSource = typeof(diagram.ProvideOrder);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.advancedDataSet;
            // 
            // advancedDataSet
            // 
            this.advancedDataSet.DataSetName = "advancedDataSet";
            this.advancedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShipmentTabPage
            // 
            this.ShipmentTabPage.BackColor = System.Drawing.Color.Transparent;
            this.ShipmentTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShipmentTabPage.Controls.Add(this.advancedDataGridView2);
            this.ShipmentTabPage.Location = new System.Drawing.Point(4, 36);
            this.ShipmentTabPage.Name = "ShipmentTabPage";
            this.ShipmentTabPage.Size = new System.Drawing.Size(992, 414);
            this.ShipmentTabPage.TabIndex = 1;
            this.ShipmentTabPage.Text = "Відвантаження";
            this.ShipmentTabPage.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AllowUserToAddRows = false;
            this.advancedDataGridView2.AllowUserToDeleteRows = false;
            this.advancedDataGridView2.AutoGenerateColumns = false;
            this.advancedDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView2.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.advancedDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.advancedDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView2.ColumnHeadersHeight = 30;
            this.advancedDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipmentIDDataGridViewTextBoxColumn,
            this.deliverIDDataGridViewTextBoxColumn1,
            this.goodsShopsIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1});
            this.advancedDataGridView2.DataSource = this.shipmentBindingSource;
            this.advancedDataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView2.FilterAndSortEnabled = true;
            this.advancedDataGridView2.GridColor = System.Drawing.Color.LightSkyBlue;
            this.advancedDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.ReadOnly = true;
            this.advancedDataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView2.RowHeadersVisible = false;
            this.advancedDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView2.Size = new System.Drawing.Size(990, 412);
            this.advancedDataGridView2.TabIndex = 0;
            // 
            // deliveryBindingSource1
            // 
            this.deliveryBindingSource1.DataSource = typeof(diagram.Delivery);
            // 
            // goodsShopsBindingSource
            // 
            this.goodsShopsBindingSource.DataSource = typeof(diagram.GoodsShops);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.advancedDataSet;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.newShipmentBtn);
            this.panel7.Controls.Add(this.newServiceBtn);
            this.panel7.Controls.Add(this.newProvideOrder);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 454);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1000, 101);
            this.panel7.TabIndex = 13;
            // 
            // newShipmentBtn
            // 
            this.newShipmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.newShipmentBtn.BackgroundImage = global::diagram.Properties.Resources.add;
            this.newShipmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newShipmentBtn.FlatAppearance.BorderSize = 0;
            this.newShipmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newShipmentBtn.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newShipmentBtn.Location = new System.Drawing.Point(502, 19);
            this.newShipmentBtn.Name = "newShipmentBtn";
            this.newShipmentBtn.Size = new System.Drawing.Size(267, 46);
            this.newShipmentBtn.TabIndex = 7;
            this.newShipmentBtn.Text = "Нове відвантаження";
            this.newShipmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newShipmentBtn.UseVisualStyleBackColor = false;
            this.newShipmentBtn.Click += new System.EventHandler(this.NewShipment_Click);
            // 
            // newServiceBtn
            // 
            this.newServiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.newServiceBtn.BackgroundImage = global::diagram.Properties.Resources.repair;
            this.newServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newServiceBtn.FlatAppearance.BorderSize = 0;
            this.newServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newServiceBtn.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newServiceBtn.Location = new System.Drawing.Point(234, 19);
            this.newServiceBtn.Name = "newServiceBtn";
            this.newServiceBtn.Size = new System.Drawing.Size(226, 46);
            this.newServiceBtn.TabIndex = 6;
            this.newServiceBtn.Text = "Товар в ремонт";
            this.newServiceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newServiceBtn.UseVisualStyleBackColor = false;
            this.newServiceBtn.Click += new System.EventHandler(this.NewService_Click);
            // 
            // newProvideOrder
            // 
            this.newProvideOrder.BackColor = System.Drawing.Color.Transparent;
            this.newProvideOrder.BackgroundImage = global::diagram.Properties.Resources.check;
            this.newProvideOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newProvideOrder.FlatAppearance.BorderSize = 0;
            this.newProvideOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProvideOrder.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProvideOrder.Location = new System.Drawing.Point(796, 19);
            this.newProvideOrder.Name = "newProvideOrder";
            this.newProvideOrder.Size = new System.Drawing.Size(272, 59);
            this.newProvideOrder.TabIndex = 7;
            this.newProvideOrder.Text = "Зробити загальне \r\nзамовлення (партію)";
            this.newProvideOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newProvideOrder.UseVisualStyleBackColor = false;
            this.newProvideOrder.Click += new System.EventHandler(this.NewProvideOrder_Click);
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // shipmentIDDataGridViewTextBoxColumn
            // 
            this.shipmentIDDataGridViewTextBoxColumn.DataPropertyName = "Shipment_ID";
            this.shipmentIDDataGridViewTextBoxColumn.HeaderText = "Shipment_ID";
            this.shipmentIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.shipmentIDDataGridViewTextBoxColumn.Name = "shipmentIDDataGridViewTextBoxColumn";
            this.shipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shipmentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.shipmentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliverIDDataGridViewTextBoxColumn1
            // 
            this.deliverIDDataGridViewTextBoxColumn1.DataPropertyName = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn1.DataSource = this.deliveryBindingSource1;
            this.deliverIDDataGridViewTextBoxColumn1.DisplayMember = "Code";
            this.deliverIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.deliverIDDataGridViewTextBoxColumn1.HeaderText = "Код поставки";
            this.deliverIDDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.deliverIDDataGridViewTextBoxColumn1.Name = "deliverIDDataGridViewTextBoxColumn1";
            this.deliverIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.deliverIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deliverIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.deliverIDDataGridViewTextBoxColumn1.ValueMember = "Deliver_ID";
            // 
            // goodsShopsIDDataGridViewTextBoxColumn
            // 
            this.goodsShopsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsShops_ID";
            this.goodsShopsIDDataGridViewTextBoxColumn.DataSource = this.goodsShopsBindingSource;
            this.goodsShopsIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.goodsShopsIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.goodsShopsIDDataGridViewTextBoxColumn.HeaderText = "Код товар/магазин";
            this.goodsShopsIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.goodsShopsIDDataGridViewTextBoxColumn.Name = "goodsShopsIDDataGridViewTextBoxColumn";
            this.goodsShopsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsShopsIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsShopsIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.goodsShopsIDDataGridViewTextBoxColumn.ValueMember = "GoodsShops_ID";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
            this.employeeIDDataGridViewTextBoxColumn.DisplayMember = "LastName";
            this.employeeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Працівник";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.employeeIDDataGridViewTextBoxColumn.ValueMember = "Employee_ID";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ExpeditorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpeditorForm";
            this.Text = "ExpeditorForm";
            this.Load += new System.EventHandler(this.ExpeditorForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.DeliveryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataSet)).EndInit();
            this.ShipmentTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button backToHomeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;

        private System.Windows.Forms.Button newProvideOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DeliveryTabPage;
        private System.Windows.Forms.TabPage ShipmentTabPage;
        private System.Windows.Forms.Button newServiceBtn;
        private System.Windows.Forms.Button newShipmentBtn;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView2;
        private advancedDataSet advancedDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private advancedDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource provideOrderBindingSource;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private advancedDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource1;
        private System.Windows.Forms.BindingSource goodsShopsBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn goodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn provideOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn deliverIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn goodsShopsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
    }
}