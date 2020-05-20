namespace diagram.Forms.Users.Seller.Transportations
{
    partial class ManagerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.transportationTabPage = new System.Windows.Forms.TabPage();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.transportationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSfromIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsShopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advancedDataSet = new diagram.advancedDataSet();
            this.panel6 = new System.Windows.Forms.Panel();
            this.newTransportationBtn = new System.Windows.Forms.Button();
            this.statisticsTabPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SellerComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SellerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalesShopChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.changeUserBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.backToHomeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transportationTableAdapter = new diagram.advancedDataSetTableAdapters.TransportationTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.newServiceBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.transportationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            this.statisticsTabPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesShopChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.transportationTabPage);
            this.tabControl1.Controls.Add(this.statisticsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // transportationTabPage
            // 
            this.transportationTabPage.Controls.Add(this.advancedDataGridView1);
            this.transportationTabPage.Controls.Add(this.panel6);
            this.transportationTabPage.Location = new System.Drawing.Point(4, 36);
            this.transportationTabPage.Name = "transportationTabPage";
            this.transportationTabPage.Size = new System.Drawing.Size(992, 515);
            this.transportationTabPage.TabIndex = 0;
            this.transportationTabPage.Text = "Перевезення";
            this.transportationTabPage.UseVisualStyleBackColor = true;
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
            this.transportationIDDataGridViewTextBoxColumn,
            this.gSfromIDDataGridViewTextBoxColumn,
            this.gSinIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.transportationBindingSource1;
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
            this.advancedDataGridView1.Size = new System.Drawing.Size(992, 456);
            this.advancedDataGridView1.TabIndex = 0;
            // 
            // transportationIDDataGridViewTextBoxColumn
            // 
            this.transportationIDDataGridViewTextBoxColumn.DataPropertyName = "Transportation_ID";
            this.transportationIDDataGridViewTextBoxColumn.HeaderText = "Transportation_ID";
            this.transportationIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.transportationIDDataGridViewTextBoxColumn.Name = "transportationIDDataGridViewTextBoxColumn";
            this.transportationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transportationIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.transportationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // gSfromIDDataGridViewTextBoxColumn
            // 
            this.gSfromIDDataGridViewTextBoxColumn.DataPropertyName = "GS_from_ID";
            this.gSfromIDDataGridViewTextBoxColumn.DataSource = this.goodsShopsBindingSource;
            this.gSfromIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.gSfromIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.gSfromIDDataGridViewTextBoxColumn.HeaderText = "Код товар/магазин (звідки)";
            this.gSfromIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.gSfromIDDataGridViewTextBoxColumn.Name = "gSfromIDDataGridViewTextBoxColumn";
            this.gSfromIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSfromIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gSfromIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gSfromIDDataGridViewTextBoxColumn.ValueMember = "GoodsShops_ID";
            // 
            // goodsShopsBindingSource
            // 
            this.goodsShopsBindingSource.DataSource = typeof(diagram.GoodsShops);
            // 
            // gSinIDDataGridViewTextBoxColumn
            // 
            this.gSinIDDataGridViewTextBoxColumn.DataPropertyName = "GS_in_ID";
            this.gSinIDDataGridViewTextBoxColumn.DataSource = this.goodsShopsBindingSource;
            this.gSinIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.gSinIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.gSinIDDataGridViewTextBoxColumn.HeaderText = "Код товар/магазин (куди)";
            this.gSinIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.gSinIDDataGridViewTextBoxColumn.Name = "gSinIDDataGridViewTextBoxColumn";
            this.gSinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSinIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gSinIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gSinIDDataGridViewTextBoxColumn.ValueMember = "GoodsShops_ID";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource1;
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
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(diagram.Employee);
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
            // transportationBindingSource1
            // 
            this.transportationBindingSource1.DataMember = "Transportation";
            this.transportationBindingSource1.DataSource = this.advancedDataSet;
            // 
            // advancedDataSet
            // 
            this.advancedDataSet.DataSetName = "advancedDataSet";
            this.advancedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Controls.Add(this.newServiceBtn);
            this.panel6.Controls.Add(this.newTransportationBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 456);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(992, 59);
            this.panel6.TabIndex = 1;
            // 
            // newTransportationBtn
            // 
            this.newTransportationBtn.BackgroundImage = global::diagram.Properties.Resources.add;
            this.newTransportationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newTransportationBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newTransportationBtn.FlatAppearance.BorderSize = 0;
            this.newTransportationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newTransportationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newTransportationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTransportationBtn.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTransportationBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newTransportationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newTransportationBtn.Location = new System.Drawing.Point(546, 7);
            this.newTransportationBtn.Name = "newTransportationBtn";
            this.newTransportationBtn.Size = new System.Drawing.Size(244, 45);
            this.newTransportationBtn.TabIndex = 8;
            this.newTransportationBtn.Text = "Нове перевезення";
            this.newTransportationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newTransportationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newTransportationBtn.UseVisualStyleBackColor = true;
            this.newTransportationBtn.Click += new System.EventHandler(this.NewTransportation_Click);
            // 
            // statisticsTabPage
            // 
            this.statisticsTabPage.Controls.Add(this.tabControl2);
            this.statisticsTabPage.Location = new System.Drawing.Point(4, 36);
            this.statisticsTabPage.Name = "statisticsTabPage";
            this.statisticsTabPage.Size = new System.Drawing.Size(992, 515);
            this.statisticsTabPage.TabIndex = 1;
            this.statisticsTabPage.Text = "Статистика";
            this.statisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(10, 10);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(992, 515);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SellerComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SellerChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продаж за продавцями";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SellerComboBox
            // 
            this.SellerComboBox.BackColor = System.Drawing.Color.Cornsilk;
            this.SellerComboBox.DataSource = this.employeeBindingSource;
            this.SellerComboBox.DisplayMember = "LastName";
            this.SellerComboBox.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerComboBox.FormattingEnabled = true;
            this.SellerComboBox.Location = new System.Drawing.Point(141, 1);
            this.SellerComboBox.Name = "SellerComboBox";
            this.SellerComboBox.Size = new System.Drawing.Size(170, 28);
            this.SellerComboBox.TabIndex = 0;
            this.SellerComboBox.ValueMember = "Employee_ID";
            this.SellerComboBox.SelectedIndexChanged += new System.EventHandler(this.SellerComboBox_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Продавець: ";
            // 
            // SellerChart
            // 
            this.SellerChart.BackColor = System.Drawing.Color.Transparent;
            this.SellerChart.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.SellerChart.ChartAreas.Add(chartArea1);
            this.SellerChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.SellerChart.Legends.Add(legend1);
            this.SellerChart.Location = new System.Drawing.Point(3, 3);
            this.SellerChart.Name = "SellerChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Продажі";
            this.SellerChart.Series.Add(series1);
            this.SellerChart.Size = new System.Drawing.Size(978, 469);
            this.SellerChart.TabIndex = 1;
            this.SellerChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.StartDateTimePicker);
            this.tabPage2.Controls.Add(this.StopDateTimePicker);
            this.tabPage2.Controls.Add(this.SalesShopChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продаж за магазинами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Кінець: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Початок: ";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.BackColor = System.Drawing.Color.Cornsilk;
            this.StartDateTimePicker.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTimePicker.Location = new System.Drawing.Point(97, 0);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(170, 27);
            this.StartDateTimePicker.TabIndex = 1;
            this.StartDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // StopDateTimePicker
            // 
            this.StopDateTimePicker.BackColor = System.Drawing.Color.Cornsilk;
            this.StopDateTimePicker.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopDateTimePicker.Location = new System.Drawing.Point(383, 0);
            this.StopDateTimePicker.Name = "StopDateTimePicker";
            this.StopDateTimePicker.Size = new System.Drawing.Size(170, 27);
            this.StopDateTimePicker.TabIndex = 2;
            this.StopDateTimePicker.ValueChanged += new System.EventHandler(this.StopDateTimePicker_ValueChanged);
            // 
            // SalesShopChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SalesShopChart.ChartAreas.Add(chartArea2);
            this.SalesShopChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.SalesShopChart.Legends.Add(legend2);
            this.SalesShopChart.Location = new System.Drawing.Point(3, 3);
            this.SalesShopChart.Name = "SalesShopChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Продаж";
            this.SalesShopChart.Series.Add(series2);
            this.SalesShopChart.Size = new System.Drawing.Size(978, 469);
            this.SalesShopChart.TabIndex = 3;
            this.SalesShopChart.Text = "chart2";
            // 
            // transportationBindingSource
            // 
            this.transportationBindingSource.DataSource = typeof(diagram.Transportation);
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
            this.panel5.Location = new System.Drawing.Point(360, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(468, 45);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.changeUserBtn);
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Controls.Add(this.minimizeBtn);
            this.panel4.Controls.Add(this.backToHomeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(828, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 45);
            this.panel4.TabIndex = 1;
            // 
            // changeUserBtn
            // 
            this.changeUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.changeUserBtn.FlatAppearance.BorderSize = 0;
            this.changeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUserBtn.Image = global::diagram.Properties.Resources.user;
            this.changeUserBtn.Location = new System.Drawing.Point(0, 2);
            this.changeUserBtn.Name = "changeUserBtn";
            this.changeUserBtn.Size = new System.Drawing.Size(45, 42);
            this.changeUserBtn.TabIndex = 14;
            this.toolTip1.SetToolTip(this.changeUserBtn, "Змінити користувача");
            this.changeUserBtn.UseVisualStyleBackColor = true;
            this.changeUserBtn.Click += new System.EventHandler(this.changeUserBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::diagram.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(134, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 44);
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
            this.minimizeBtn.Location = new System.Drawing.Point(95, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(38, 44);
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
            this.backToHomeBtn.Location = new System.Drawing.Point(51, 2);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(38, 42);
            this.backToHomeBtn.TabIndex = 13;
            this.toolTip1.SetToolTip(this.backToHomeBtn, "Домашня сторінка");
            this.backToHomeBtn.UseVisualStyleBackColor = true;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.formTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 45);
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
            this.formTitle.Size = new System.Drawing.Size(485, 42);
            this.formTitle.TabIndex = 4;
            this.formTitle.Text = "Менеджер з продажів та перевезень";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 555);
            this.panel1.TabIndex = 11;
            // 
            // transportationTableAdapter
            // 
            this.transportationTableAdapter.ClearBeforeFill = true;
            // 
            // newServiceBtn
            // 
            this.newServiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.newServiceBtn.BackgroundImage = global::diagram.Properties.Resources.repair;
            this.newServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newServiceBtn.FlatAppearance.BorderSize = 0;
            this.newServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newServiceBtn.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newServiceBtn.Location = new System.Drawing.Point(251, 0);
            this.newServiceBtn.Name = "newServiceBtn";
            this.newServiceBtn.Size = new System.Drawing.Size(230, 59);
            this.newServiceBtn.TabIndex = 9;
            this.newServiceBtn.Text = "Прийняти товар \r\nвід покупця";
            this.newServiceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newServiceBtn.UseVisualStyleBackColor = false;
            this.newServiceBtn.Click += new System.EventHandler(this.newServiceBtn_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.transportationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.statisticsTabPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesShopChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage transportationTabPage;
        private System.Windows.Forms.TabPage statisticsTabPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox SellerComboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DateTimePicker StopDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.BindingSource goodsShopsBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource transportationBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart SellerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesShopChart;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newTransportationBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button backToHomeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private advancedDataSet advancedDataSet;
        private System.Windows.Forms.BindingSource transportationBindingSource1;
        private advancedDataSetTableAdapters.TransportationTableAdapter transportationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gSfromIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gSinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button changeUserBtn;
        private System.Windows.Forms.Button newServiceBtn;
    }
}