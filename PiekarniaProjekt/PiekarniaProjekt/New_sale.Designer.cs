namespace PiekarniaProjekt
{
    partial class New_sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_sale));
            this.left_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.right_listBox = new System.Windows.Forms.ListBox();
            this.on_the_right_button = new System.Windows.Forms.Button();
            this.on_the_left_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list_of_shops = new System.Windows.Forms.ComboBox();
            this.previous_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // left_listBox
            // 
            this.left_listBox.AllowDrop = true;
            this.left_listBox.BackColor = System.Drawing.SystemColors.Control;
            this.left_listBox.FormattingEnabled = true;
            this.left_listBox.Items.AddRange(new object[] {
            "Bułka przenna",
            "Bułka grahamka"});
            this.left_listBox.Location = new System.Drawing.Point(22, 100);
            this.left_listBox.Name = "left_listBox";
            this.left_listBox.Size = new System.Drawing.Size(200, 316);
            this.left_listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nowy dowód sprzedaży";
            // 
            // right_listBox
            // 
            this.right_listBox.AllowDrop = true;
            this.right_listBox.BackColor = System.Drawing.SystemColors.Control;
            this.right_listBox.FormattingEnabled = true;
            this.right_listBox.Items.AddRange(new object[] {
            "Chleb razowy"});
            this.right_listBox.Location = new System.Drawing.Point(322, 100);
            this.right_listBox.Name = "right_listBox";
            this.right_listBox.Size = new System.Drawing.Size(200, 316);
            this.right_listBox.TabIndex = 8;
            // 
            // on_the_right_button
            // 
            this.on_the_right_button.Location = new System.Drawing.Point(247, 198);
            this.on_the_right_button.Name = "on_the_right_button";
            this.on_the_right_button.Size = new System.Drawing.Size(55, 55);
            this.on_the_right_button.TabIndex = 9;
            this.on_the_right_button.Text = ">>";
            this.on_the_right_button.UseVisualStyleBackColor = true;
            // 
            // on_the_left_button
            // 
            this.on_the_left_button.Location = new System.Drawing.Point(247, 263);
            this.on_the_left_button.Name = "on_the_left_button";
            this.on_the_left_button.Size = new System.Drawing.Size(55, 55);
            this.on_the_left_button.TabIndex = 10;
            this.on_the_left_button.Text = "<<";
            this.on_the_left_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(549, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wybierz sklep:";
            // 
            // list_of_shops
            // 
            this.list_of_shops.BackColor = System.Drawing.SystemColors.Control;
            this.list_of_shops.FormattingEnabled = true;
            this.list_of_shops.Items.AddRange(new object[] {
            "Sklep1",
            "Sklep2",
            "Sklep3",
            "Sklep4",
            "Sklep5",
            "Sklep6",
            "Sklep7",
            "Sklep8"});
            this.list_of_shops.Location = new System.Drawing.Point(549, 81);
            this.list_of_shops.Name = "list_of_shops";
            this.list_of_shops.Size = new System.Drawing.Size(199, 21);
            this.list_of_shops.TabIndex = 13;
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(598, 381);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(120, 35);
            this.previous_button.TabIndex = 14;
            this.previous_button.Text = "Wstecz";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(598, 331);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(120, 35);
            this.Next_button.TabIndex = 15;
            this.Next_button.Text = "Dalej";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // New_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.list_of_shops);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.on_the_left_button);
            this.Controls.Add(this.on_the_right_button);
            this.Controls.Add(this.right_listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.left_listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowy dowód sprzedaży";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox left_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox right_listBox;
        private System.Windows.Forms.Button on_the_right_button;
        private System.Windows.Forms.Button on_the_left_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list_of_shops;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button Next_button;
    }
}