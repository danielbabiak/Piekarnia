namespace PiekarniaProjekt
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.list_of_products = new System.Windows.Forms.ListBox();
            this.edit_product_button = new System.Windows.Forms.Button();
            this.new_product_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_of_products
            // 
            this.list_of_products.BackColor = System.Drawing.SystemColors.Control;
            this.list_of_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_of_products.FormattingEnabled = true;
            this.list_of_products.ItemHeight = 15;
            this.list_of_products.Location = new System.Drawing.Point(94, 73);
            this.list_of_products.Name = "list_of_products";
            this.list_of_products.Size = new System.Drawing.Size(225, 304);
            this.list_of_products.TabIndex = 1;
            this.list_of_products.SelectedIndexChanged += new System.EventHandler(this.list_of_products_SelectedIndexChanged);
            refresh_listBox();
            // 
            // edit_product_button
            // 
            this.edit_product_button.Enabled = false;
            this.edit_product_button.Location = new System.Drawing.Point(379, 282);
            this.edit_product_button.Name = "edit_product_button";
            this.edit_product_button.Size = new System.Drawing.Size(120, 35);
            this.edit_product_button.TabIndex = 3;
            this.edit_product_button.Text = "Edytuj produkt";
            this.edit_product_button.UseVisualStyleBackColor = true;
            this.edit_product_button.Click += new System.EventHandler(this.edit_product_button_Click);
            // 
            // new_product_button
            // 
            this.new_product_button.Location = new System.Drawing.Point(619, 282);
            this.new_product_button.Name = "new_product_button";
            this.new_product_button.Size = new System.Drawing.Size(120, 35);
            this.new_product_button.TabIndex = 4;
            this.new_product_button.Text = "Nowy produkt";
            this.new_product_button.UseVisualStyleBackColor = true;
            this.new_product_button.Click += new System.EventHandler(this.new_product_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(619, 342);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(120, 35);
            this.previous_button.TabIndex = 5;
            this.previous_button.Text = "Wstecz";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(446, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produkty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(94, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lista produktów:";
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Location = new System.Drawing.Point(379, 342);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(120, 35);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "Usuń produkt";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.new_product_button);
            this.Controls.Add(this.edit_product_button);
            this.Controls.Add(this.list_of_products);
            this.Controls.Add(this.delete_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_of_products;
        private System.Windows.Forms.Button edit_product_button;
        private System.Windows.Forms.Button new_product_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_button;
    }
}