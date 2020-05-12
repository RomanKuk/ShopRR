namespace diagram.Forms.transportation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.transportationTabPage = new System.Windows.Forms.TabPage();
            this.NewTransportation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transportationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSfromIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodsShopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statisticsTabPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SellerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SellerComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SalesShopChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.transportationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).BeginInit();
            this.statisticsTabPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesShopChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.transportationTabPage);
            this.tabControl1.Controls.Add(this.statisticsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // transportationTabPage
            // 
            this.transportationTabPage.Controls.Add(this.NewTransportation);
            this.transportationTabPage.Controls.Add(this.dataGridView1);
            this.transportationTabPage.Location = new System.Drawing.Point(4, 22);
            this.transportationTabPage.Name = "transportationTabPage";
            this.transportationTabPage.Size = new System.Drawing.Size(768, 400);
            this.transportationTabPage.TabIndex = 0;
            this.transportationTabPage.Text = "Перевезення";
            this.transportationTabPage.UseVisualStyleBackColor = true;
            // 
            // NewTransportation
            // 
            this.NewTransportation.Location = new System.Drawing.Point(590, 78);
            this.NewTransportation.Name = "NewTransportation";
            this.NewTransportation.Size = new System.Drawing.Size(152, 23);
            this.NewTransportation.TabIndex = 1;
            this.NewTransportation.Text = "Заявка на перевезення";
            this.NewTransportation.UseVisualStyleBackColor = true;
            this.NewTransportation.Click += new System.EventHandler(this.NewTransportation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportationIDDataGridViewTextBoxColumn,
            this.gSfromIDDataGridViewTextBoxColumn,
            this.gSinIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transportationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(517, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // transportationIDDataGridViewTextBoxColumn
            // 
            this.transportationIDDataGridViewTextBoxColumn.DataPropertyName = "Transportation_ID";
            this.transportationIDDataGridViewTextBoxColumn.HeaderText = "Transportation_ID";
            this.transportationIDDataGridViewTextBoxColumn.Name = "transportationIDDataGridViewTextBoxColumn";
            this.transportationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transportationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // gSfromIDDataGridViewTextBoxColumn
            // 
            this.gSfromIDDataGridViewTextBoxColumn.DataPropertyName = "GS_from_ID";
            this.gSfromIDDataGridViewTextBoxColumn.DataSource = this.goodsShopsBindingSource;
            this.gSfromIDDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.gSfromIDDataGridViewTextBoxColumn.HeaderText = "GS_from_ID";
            this.gSfromIDDataGridViewTextBoxColumn.Name = "gSfromIDDataGridViewTextBoxColumn";
            this.gSfromIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSfromIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gSfromIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.gSinIDDataGridViewTextBoxColumn.HeaderText = "GS_in_ID";
            this.gSinIDDataGridViewTextBoxColumn.Name = "gSinIDDataGridViewTextBoxColumn";
            this.gSinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSinIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gSinIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gSinIDDataGridViewTextBoxColumn.ValueMember = "GoodsShops_ID";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource1;
            this.employeeIDDataGridViewTextBoxColumn.DisplayMember = "LastName";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeIDDataGridViewTextBoxColumn.ValueMember = "Employee_ID";
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(diagram.Employee);
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
            // transportationBindingSource
            // 
            this.transportationBindingSource.DataSource = typeof(diagram.Transportation);
            // 
            // statisticsTabPage
            // 
            this.statisticsTabPage.Controls.Add(this.tabControl2);
            this.statisticsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statisticsTabPage.Name = "statisticsTabPage";
            this.statisticsTabPage.Size = new System.Drawing.Size(768, 400);
            this.statisticsTabPage.TabIndex = 1;
            this.statisticsTabPage.Text = "Статистика";
            this.statisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(762, 394);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SellerChart);
            this.tabPage1.Controls.Add(this.SellerComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продаж по продавцям";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SellerChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SellerChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SellerChart.Legends.Add(legend1);
            this.SellerChart.Location = new System.Drawing.Point(6, 6);
            this.SellerChart.Name = "SellerChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Продажі";
            this.SellerChart.Series.Add(series1);
            this.SellerChart.Size = new System.Drawing.Size(742, 329);
            this.SellerChart.TabIndex = 1;
            this.SellerChart.Text = "chart1";
            // 
            // SellerComboBox
            // 
            this.SellerComboBox.DataSource = this.employeeBindingSource;
            this.SellerComboBox.DisplayMember = "LastName";
            this.SellerComboBox.FormattingEnabled = true;
            this.SellerComboBox.Location = new System.Drawing.Point(6, 341);
            this.SellerComboBox.Name = "SellerComboBox";
            this.SellerComboBox.Size = new System.Drawing.Size(121, 21);
            this.SellerComboBox.TabIndex = 0;
            this.SellerComboBox.ValueMember = "Employee_ID";
            this.SellerComboBox.SelectedIndexChanged += new System.EventHandler(this.SellerComboBox_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SalesShopChart);
            this.tabPage2.Controls.Add(this.StopDateTimePicker);
            this.tabPage2.Controls.Add(this.StartDateTimePicker);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "продаж по магазинах";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SalesShopChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SalesShopChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SalesShopChart.Legends.Add(legend2);
            this.SalesShopChart.Location = new System.Drawing.Point(6, 6);
            this.SalesShopChart.Name = "SalesShopChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Продаж";
            this.SalesShopChart.Series.Add(series2);
            this.SalesShopChart.Size = new System.Drawing.Size(742, 330);
            this.SalesShopChart.TabIndex = 3;
            this.SalesShopChart.Text = "chart2";
            // 
            // StopDateTimePicker
            // 
            this.StopDateTimePicker.Location = new System.Drawing.Point(402, 342);
            this.StopDateTimePicker.Name = "StopDateTimePicker";
            this.StopDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StopDateTimePicker.TabIndex = 2;
            this.StopDateTimePicker.ValueChanged += new System.EventHandler(this.StopDateTimePicker_ValueChanged);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(81, 342);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDateTimePicker.TabIndex = 1;
            this.StartDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.transportationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).EndInit();
            this.statisticsTabPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SellerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesShopChart)).EndInit();
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
        private System.Windows.Forms.Button NewTransportation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gSfromIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsShopsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn gSinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transportationBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart SellerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesShopChart;
    }
}