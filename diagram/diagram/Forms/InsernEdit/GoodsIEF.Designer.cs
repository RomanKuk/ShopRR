namespace diagram.Forms.InsernEdit
{
    partial class GoodsIEF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTB = new System.Windows.Forms.TextBox();
            this.makerCB = new System.Windows.Forms.ComboBox();
            this.makersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.revenuePriceNUD = new System.Windows.Forms.NumericUpDown();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.guaranteePeriodNUD = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenuePriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteePeriodNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 45);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(355, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 45);
            this.panel4.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::diagram.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 38);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 45);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Товар";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.modelTB);
            this.panel1.Controls.Add(this.codeTB);
            this.panel1.Controls.Add(this.makerCB);
            this.panel1.Controls.Add(this.categoryCB);
            this.panel1.Controls.Add(this.priceNUD);
            this.panel1.Controls.Add(this.revenuePriceNUD);
            this.panel1.Controls.Add(this.descriptionTB);
            this.panel1.Controls.Add(this.guaranteePeriodNUD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 420);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Період гарантії:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(117, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Опис:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(112, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Дохід:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(122, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ціна:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(76, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Категорія:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Код виробника:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(130, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(99, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Модель:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveBtn.Image = global::diagram.Properties.Resources.save_icon;
            this.saveBtn.Location = new System.Drawing.Point(147, 331);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(97, 77);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // modelTB
            // 
            this.modelTB.BackColor = System.Drawing.Color.Cornsilk;
            this.modelTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Model", true));
            this.modelTB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTB.Location = new System.Drawing.Point(186, 51);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(170, 27);
            this.modelTB.TabIndex = 1;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(diagram.Goods);
            // 
            // codeTB
            // 
            this.codeTB.BackColor = System.Drawing.Color.Cornsilk;
            this.codeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Code", true));
            this.codeTB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTB.Location = new System.Drawing.Point(186, 84);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(170, 27);
            this.codeTB.TabIndex = 2;
            // 
            // makerCB
            // 
            this.makerCB.BackColor = System.Drawing.Color.Cornsilk;
            this.makerCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsBindingSource, "Maker_ID", true));
            this.makerCB.DataSource = this.makersBindingSource;
            this.makerCB.DisplayMember = "Name";
            this.makerCB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makerCB.FormattingEnabled = true;
            this.makerCB.Location = new System.Drawing.Point(186, 117);
            this.makerCB.Name = "makerCB";
            this.makerCB.Size = new System.Drawing.Size(170, 28);
            this.makerCB.TabIndex = 3;
            this.makerCB.ValueMember = "Maker_ID";
            // 
            // makersBindingSource
            // 
            this.makersBindingSource.DataSource = typeof(diagram.Makers);
            // 
            // categoryCB
            // 
            this.categoryCB.BackColor = System.Drawing.Color.Cornsilk;
            this.categoryCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsBindingSource, "Category_ID", true));
            this.categoryCB.DataSource = this.categoriesBindingSource;
            this.categoryCB.DisplayMember = "Name";
            this.categoryCB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(186, 151);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(170, 28);
            this.categoryCB.TabIndex = 4;
            this.categoryCB.ValueMember = "Category_ID";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(diagram.Categories);
            // 
            // priceNUD
            // 
            this.priceNUD.BackColor = System.Drawing.Color.Cornsilk;
            this.priceNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goodsBindingSource, "Price", true));
            this.priceNUD.DecimalPlaces = 2;
            this.priceNUD.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.priceNUD.Location = new System.Drawing.Point(186, 185);
            this.priceNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(170, 27);
            this.priceNUD.TabIndex = 5;
            // 
            // revenuePriceNUD
            // 
            this.revenuePriceNUD.BackColor = System.Drawing.Color.Cornsilk;
            this.revenuePriceNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goodsBindingSource, "RevenuePrice", true));
            this.revenuePriceNUD.DecimalPlaces = 2;
            this.revenuePriceNUD.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenuePriceNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.revenuePriceNUD.Location = new System.Drawing.Point(186, 218);
            this.revenuePriceNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.revenuePriceNUD.Name = "revenuePriceNUD";
            this.revenuePriceNUD.Size = new System.Drawing.Size(170, 27);
            this.revenuePriceNUD.TabIndex = 6;
            // 
            // descriptionTB
            // 
            this.descriptionTB.BackColor = System.Drawing.Color.Cornsilk;
            this.descriptionTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Description", true));
            this.descriptionTB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTB.Location = new System.Drawing.Point(186, 251);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(170, 27);
            this.descriptionTB.TabIndex = 7;
            // 
            // guaranteePeriodNUD
            // 
            this.guaranteePeriodNUD.BackColor = System.Drawing.Color.Cornsilk;
            this.guaranteePeriodNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goodsBindingSource, "GuaranteePeriod", true));
            this.guaranteePeriodNUD.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guaranteePeriodNUD.Location = new System.Drawing.Point(186, 284);
            this.guaranteePeriodNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.guaranteePeriodNUD.Name = "guaranteePeriodNUD";
            this.guaranteePeriodNUD.Size = new System.Drawing.Size(170, 27);
            this.guaranteePeriodNUD.TabIndex = 8;
            // 
            // GoodsIEF
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsIEF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodsIEF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoodsIEF_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenuePriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteePeriodNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.TextBox codeTB;
        private System.Windows.Forms.ComboBox makerCB;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.NumericUpDown revenuePriceNUD;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.NumericUpDown guaranteePeriodNUD;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource makersBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}