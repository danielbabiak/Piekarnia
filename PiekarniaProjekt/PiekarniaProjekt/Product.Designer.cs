namespace PiekarniaProjekt
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.pkwiu_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.unit_comboBox = new System.Windows.Forms.ComboBox();
            this.vat_comboBox = new System.Windows.Forms.ComboBox();
            this.currency_comboBox = new System.Windows.Forms.ComboBox();
            this.add_product_button = new System.Windows.Forms.Button();
            this.cancel_product_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa produktu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PKWiU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jednostka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(30, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(30, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "VAT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(30, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Waluta:";
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.name_textBox.Location = new System.Drawing.Point(135, 25);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(200, 20);
            this.name_textBox.TabIndex = 6;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // pkwiu_textBox
            // 
            this.pkwiu_textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pkwiu_textBox.Location = new System.Drawing.Point(135, 55);
            this.pkwiu_textBox.Name = "pkwiu_textBox";
            this.pkwiu_textBox.Size = new System.Drawing.Size(200, 20);
            this.pkwiu_textBox.TabIndex = 7;
            this.pkwiu_textBox.TextChanged += new System.EventHandler(this.pkwiu_textBox_TextChanged);
            // 
            // price_textBox
            // 
            this.price_textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.price_textBox.Location = new System.Drawing.Point(135, 85);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(200, 20);
            this.price_textBox.TabIndex = 8;
            this.price_textBox.TextChanged += new System.EventHandler(this.price_textBox_TextChanged);
            // 
            // unit_comboBox
            // 
            this.unit_comboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.unit_comboBox.FormattingEnabled = true;
            this.unit_comboBox.Items.AddRange(new object[] {
            "szt.",
            "kg."});
            this.unit_comboBox.Location = new System.Drawing.Point(135, 115);
            this.unit_comboBox.Name = "unit_comboBox";
            this.unit_comboBox.Size = new System.Drawing.Size(70, 21);
            this.unit_comboBox.TabIndex = 10;
            this.unit_comboBox.SelectedIndexChanged += new System.EventHandler(this.unit_comboBox_SelectedIndexChanged);
            // 
            // vat_comboBox
            // 
            this.vat_comboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.vat_comboBox.FormattingEnabled = true;
            this.vat_comboBox.Items.AddRange(new object[] {
            "5",
            "8",
            "23"});
            this.vat_comboBox.Location = new System.Drawing.Point(135, 145);
            this.vat_comboBox.Name = "vat_comboBox";
            this.vat_comboBox.Size = new System.Drawing.Size(70, 21);
            this.vat_comboBox.TabIndex = 11;
            this.vat_comboBox.SelectedIndexChanged += new System.EventHandler(this.vat_comboBox_SelectedIndexChanged);
            // 
            // currency_comboBox
            // 
            this.currency_comboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.currency_comboBox.FormattingEnabled = true;
            this.currency_comboBox.Items.AddRange(new object[] {
            "PLN",
            "CZK"});
            this.currency_comboBox.Location = new System.Drawing.Point(135, 175);
            this.currency_comboBox.Name = "currency_comboBox";
            this.currency_comboBox.Size = new System.Drawing.Size(70, 21);
            this.currency_comboBox.TabIndex = 12;
            this.currency_comboBox.SelectedIndexChanged += new System.EventHandler(this.currency_comboBox_SelectedIndexChanged);
            // 
            // add_product_button
            // 
            this.add_product_button.Location = new System.Drawing.Point(165, 245);
            this.add_product_button.Name = "add_product_button";
            this.add_product_button.Size = new System.Drawing.Size(80, 25);
            this.add_product_button.TabIndex = 13;
            this.add_product_button.Text = "Dodaj";
            this.add_product_button.UseVisualStyleBackColor = true;
            this.add_product_button.Click += new System.EventHandler(this.add_product_button_Click);
            // 
            // cancel_product_button
            // 
            this.cancel_product_button.Location = new System.Drawing.Point(260, 245);
            this.cancel_product_button.Name = "cancel_product_button";
            this.cancel_product_button.Size = new System.Drawing.Size(80, 25);
            this.cancel_product_button.TabIndex = 14;
            this.cancel_product_button.Text = "Anuluj";
            this.cancel_product_button.UseVisualStyleBackColor = true;
            this.cancel_product_button.Click += new System.EventHandler(this.cancel_product_button_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_product_button);
            this.Controls.Add(this.add_product_button);
            this.Controls.Add(this.currency_comboBox);
            this.Controls.Add(this.vat_comboBox);
            this.Controls.Add(this.unit_comboBox);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.pkwiu_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox pkwiu_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.ComboBox unit_comboBox;
        private System.Windows.Forms.ComboBox vat_comboBox;
        private System.Windows.Forms.ComboBox currency_comboBox;
        private System.Windows.Forms.Button add_product_button;
        private System.Windows.Forms.Button cancel_product_button;
    }
}