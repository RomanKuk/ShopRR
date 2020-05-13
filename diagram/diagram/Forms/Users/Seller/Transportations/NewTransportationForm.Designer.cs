namespace diagram.Forms.Users.Seller.Transportations
{
    partial class NewTransportationForm
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
            this.goodsComboBox = new System.Windows.Forms.ComboBox();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopToComboBox = new System.Windows.Forms.ComboBox();
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopFromComboBox = new System.Windows.Forms.ComboBox();
            this.shopsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsComboBox
            // 
            this.goodsComboBox.BackColor = System.Drawing.Color.Cornsilk;
            this.goodsComboBox.DataSource = this.goodsBindingSource;
            this.goodsComboBox.DisplayMember = "Model";
            this.goodsComboBox.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsComboBox.FormattingEnabled = true;
            this.goodsComboBox.Location = new System.Drawing.Point(225, 89);
            this.goodsComboBox.Name = "goodsComboBox";
            this.goodsComboBox.Size = new System.Drawing.Size(170, 28);
            this.goodsComboBox.TabIndex = 0;
            this.goodsComboBox.ValueMember = "Good_ID";
            this.goodsComboBox.SelectedIndexChanged += new System.EventHandler(this.GoodsComboBox_SelectedIndexChanged);
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(diagram.Goods);
            // 
            // ShopToComboBox
            // 
            this.ShopToComboBox.BackColor = System.Drawing.Color.Cornsilk;
            this.ShopToComboBox.DataSource = this.shopsBindingSource;
            this.ShopToComboBox.DisplayMember = "Code";
            this.ShopToComboBox.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopToComboBox.FormattingEnabled = true;
            this.ShopToComboBox.Location = new System.Drawing.Point(225, 133);
            this.ShopToComboBox.Name = "ShopToComboBox";
            this.ShopToComboBox.Size = new System.Drawing.Size(170, 28);
            this.ShopToComboBox.TabIndex = 1;
            this.ShopToComboBox.ValueMember = "Shop_ID";
            this.ShopToComboBox.SelectedIndexChanged += new System.EventHandler(this.ShopToComboBox_SelectedIndexChanged);
            // 
            // shopsBindingSource
            // 
            this.shopsBindingSource.DataSource = typeof(diagram.Shops);
            // 
            // ShopFromComboBox
            // 
            this.ShopFromComboBox.BackColor = System.Drawing.Color.Cornsilk;
            this.ShopFromComboBox.DataSource = this.shopsBindingSource1;
            this.ShopFromComboBox.DisplayMember = "Code";
            this.ShopFromComboBox.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopFromComboBox.FormattingEnabled = true;
            this.ShopFromComboBox.Location = new System.Drawing.Point(225, 176);
            this.ShopFromComboBox.Name = "ShopFromComboBox";
            this.ShopFromComboBox.Size = new System.Drawing.Size(170, 28);
            this.ShopFromComboBox.TabIndex = 2;
            this.ShopFromComboBox.ValueMember = "Shop_ID";
            this.ShopFromComboBox.SelectedIndexChanged += new System.EventHandler(this.ShopFromComboBox_SelectedIndexChanged);
            // 
            // shopsBindingSource1
            // 
            this.shopsBindingSource1.DataSource = typeof(diagram.Shops);
            // 
            // countNUD
            // 
            this.countNUD.BackColor = System.Drawing.Color.Cornsilk;
            this.countNUD.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countNUD.Location = new System.Drawing.Point(225, 220);
            this.countNUD.Name = "countNUD";
            this.countNUD.Size = new System.Drawing.Size(170, 27);
            this.countNUD.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Нове перевезення";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Location = new System.Drawing.Point(127, 342);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = true;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(55, 265);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(168, 21);
            this.toLabel.TabIndex = 9;
            this.toLabel.Text = "В наявності (куди):";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(55, 302);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(183, 21);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "В наявності (звідки):";
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
            this.panel2.Size = new System.Drawing.Size(445, 45);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(400, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 45);
            this.panel4.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::diagram.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.panel3.Size = new System.Drawing.Size(445, 45);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.toLabel);
            this.panel1.Controls.Add(this.fromLabel);
            this.panel1.Controls.Add(this.goodsComboBox);
            this.panel1.Controls.Add(this.ShopFromComboBox);
            this.panel1.Controls.Add(this.ShopToComboBox);
            this.panel1.Controls.Add(this.countNUD);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 420);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(92, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Товар:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(55, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Кількість:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(76, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Звідки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(92, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Куди:";
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
            this.saveBtn.Image = global::diagram.Properties.Resources.check;
            this.saveBtn.Location = new System.Drawing.Point(155, 340);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 77);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Відправити";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // NewTransportationForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(445, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTransportationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTransportationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewTransportationForm_FormClosing);
            this.Load += new System.EventHandler(this.NewTransportationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox goodsComboBox;
        private System.Windows.Forms.ComboBox ShopToComboBox;
        private System.Windows.Forms.ComboBox ShopFromComboBox;
        private System.Windows.Forms.NumericUpDown countNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource shopsBindingSource;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.BindingSource shopsBindingSource1;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}