namespace diagram.Forms.Users.Expeditor
{
    partial class NewServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalesComboBox = new System.Windows.Forms.ComboBox();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GoodsComboBox = new System.Windows.Forms.ComboBox();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BreakageComboBox = new System.Windows.Forms.ComboBox();
            this.breakageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер продажу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип поломки";
            // 
            // SalesComboBox
            // 
            this.SalesComboBox.DataSource = this.salesBindingSource;
            this.SalesComboBox.DisplayMember = "SalesCode";
            this.SalesComboBox.FormattingEnabled = true;
            this.SalesComboBox.Location = new System.Drawing.Point(229, 63);
            this.SalesComboBox.Name = "SalesComboBox";
            this.SalesComboBox.Size = new System.Drawing.Size(121, 21);
            this.SalesComboBox.TabIndex = 3;
            this.SalesComboBox.ValueMember = "Sales_ID";
            this.SalesComboBox.SelectedIndexChanged += new System.EventHandler(this.SalesComboBox_SelectedIndexChanged);
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(diagram.Sales);
            // 
            // GoodsComboBox
            // 
            this.GoodsComboBox.DataSource = this.goodsBindingSource;
            this.GoodsComboBox.DisplayMember = "Model";
            this.GoodsComboBox.FormattingEnabled = true;
            this.GoodsComboBox.Location = new System.Drawing.Point(229, 87);
            this.GoodsComboBox.Name = "GoodsComboBox";
            this.GoodsComboBox.Size = new System.Drawing.Size(121, 21);
            this.GoodsComboBox.TabIndex = 4;
            this.GoodsComboBox.ValueMember = "Good_ID";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(diagram.Goods);
            // 
            // BreakageComboBox
            // 
            this.BreakageComboBox.DataSource = this.breakageBindingSource;
            this.BreakageComboBox.DisplayMember = "Breakage1";
            this.BreakageComboBox.FormattingEnabled = true;
            this.BreakageComboBox.Location = new System.Drawing.Point(229, 118);
            this.BreakageComboBox.Name = "BreakageComboBox";
            this.BreakageComboBox.Size = new System.Drawing.Size(121, 21);
            this.BreakageComboBox.TabIndex = 5;
            this.BreakageComboBox.ValueMember = "Breakage_ID";
            // 
            // breakageBindingSource
            // 
            this.breakageBindingSource.DataSource = typeof(diagram.Breakage);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(195, 167);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "прийняти";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // NewServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.BreakageComboBox);
            this.Controls.Add(this.GoodsComboBox);
            this.Controls.Add(this.SalesComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewServiceForm";
            this.Text = "NewServiceForm";
            this.Load += new System.EventHandler(this.NewServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SalesComboBox;
        private System.Windows.Forms.ComboBox GoodsComboBox;
        private System.Windows.Forms.ComboBox BreakageComboBox;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource breakageBindingSource;
    }
}