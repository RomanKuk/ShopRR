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
            this.countNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.shopsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsComboBox
            // 
            this.goodsComboBox.DataSource = this.goodsBindingSource;
            this.goodsComboBox.DisplayMember = "Model";
            this.goodsComboBox.FormattingEnabled = true;
            this.goodsComboBox.Location = new System.Drawing.Point(181, 170);
            this.goodsComboBox.Name = "goodsComboBox";
            this.goodsComboBox.Size = new System.Drawing.Size(121, 21);
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
            this.ShopToComboBox.DataSource = this.shopsBindingSource;
            this.ShopToComboBox.DisplayMember = "Code";
            this.ShopToComboBox.FormattingEnabled = true;
            this.ShopToComboBox.Location = new System.Drawing.Point(181, 211);
            this.ShopToComboBox.Name = "ShopToComboBox";
            this.ShopToComboBox.Size = new System.Drawing.Size(121, 21);
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
            this.ShopFromComboBox.DataSource = this.shopsBindingSource1;
            this.ShopFromComboBox.DisplayMember = "Code";
            this.ShopFromComboBox.FormattingEnabled = true;
            this.ShopFromComboBox.Location = new System.Drawing.Point(181, 249);
            this.ShopFromComboBox.Name = "ShopFromComboBox";
            this.ShopFromComboBox.Size = new System.Drawing.Size(121, 21);
            this.ShopFromComboBox.TabIndex = 2;
            this.ShopFromComboBox.ValueMember = "Shop_ID";
            this.ShopFromComboBox.SelectedIndexChanged += new System.EventHandler(this.ShopFromComboBox_SelectedIndexChanged);
            // 
            // countNUD
            // 
            this.countNUD.Location = new System.Drawing.Point(181, 291);
            this.countNUD.Name = "countNUD";
            this.countNUD.Size = new System.Drawing.Size(120, 20);
            this.countNUD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Куди";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Звідки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(127, 342);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(355, 219);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(53, 13);
            this.toLabel.TabIndex = 9;
            this.toLabel.Text = "Кількість";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(355, 257);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(53, 13);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "Кількість";
            // 
            // shopsBindingSource1
            // 
            this.shopsBindingSource1.DataSource = typeof(diagram.Shops);
            // 
            // NewTransportationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countNUD);
            this.Controls.Add(this.ShopFromComboBox);
            this.Controls.Add(this.ShopToComboBox);
            this.Controls.Add(this.goodsComboBox);
            this.Name = "NewTransportationForm";
            this.Text = "NewTransportationForm";
            this.Load += new System.EventHandler(this.NewTransportationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox goodsComboBox;
        private System.Windows.Forms.ComboBox ShopToComboBox;
        private System.Windows.Forms.ComboBox ShopFromComboBox;
        private System.Windows.Forms.NumericUpDown countNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource shopsBindingSource;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.BindingSource shopsBindingSource1;
    }
}