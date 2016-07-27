namespace PiekarniaProjekt
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.New_sell_button = new System.Windows.Forms.Button();
            this.Archives_button = new System.Windows.Forms.Button();
            this.Products_button = new System.Windows.Forms.Button();
            this.Shop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_sell_button
            // 
            this.New_sell_button.Location = new System.Drawing.Point(40, 35);
            this.New_sell_button.Name = "New_sell_button";
            this.New_sell_button.Size = new System.Drawing.Size(160, 36);
            this.New_sell_button.TabIndex = 0;
            this.New_sell_button.Text = "Nowy dowód sprzedaży";
            this.New_sell_button.UseVisualStyleBackColor = true;
            this.New_sell_button.Click += new System.EventHandler(this.New_sell_button_Click);
            // 
            // Archives_button
            // 
            this.Archives_button.Location = new System.Drawing.Point(40, 100);
            this.Archives_button.Name = "Archives_button";
            this.Archives_button.Size = new System.Drawing.Size(160, 36);
            this.Archives_button.TabIndex = 1;
            this.Archives_button.Text = "Archiwum";
            this.Archives_button.UseVisualStyleBackColor = true;
            this.Archives_button.Click += new System.EventHandler(this.Archives_button_Click);
            // 
            // Products_button
            // 
            this.Products_button.Location = new System.Drawing.Point(314, 35);
            this.Products_button.Name = "Products_button";
            this.Products_button.Size = new System.Drawing.Size(160, 36);
            this.Products_button.TabIndex = 2;
            this.Products_button.Text = "Produkty";
            this.Products_button.UseVisualStyleBackColor = true;
            this.Products_button.Click += new System.EventHandler(this.Products_button_Click);
            // 
            // Shop_button
            // 
            this.Shop_button.Location = new System.Drawing.Point(587, 35);
            this.Shop_button.Name = "Shop_button";
            this.Shop_button.Size = new System.Drawing.Size(160, 36);
            this.Shop_button.TabIndex = 3;
            this.Shop_button.Text = "Sklepy";
            this.Shop_button.UseVisualStyleBackColor = true;
            this.Shop_button.Click += new System.EventHandler(this.Shop_button_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Shop_button);
            this.Controls.Add(this.Products_button);
            this.Controls.Add(this.Archives_button);
            this.Controls.Add(this.New_sell_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piekarnia „Stępień”";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_sell_button;
        private System.Windows.Forms.Button Archives_button;
        private System.Windows.Forms.Button Products_button;
        private System.Windows.Forms.Button Shop_button;
    }
}

