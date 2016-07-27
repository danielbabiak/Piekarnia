using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiekarniaProjekt
{
    public partial class Product : Form
    {
        private string[] product_data = new string[6];
        private Product_database database = new Product_database();
        private Products products;
        private string old_name = "";
        public Product(Products products)
        {
            InitializeComponent();
            this.products = products;
        }
        public Product(bool flag, Products products)
        {
            InitializeComponent();
            this.products = products;
            if (Program.database.Reader.Read())
            {
                old_name = name_textBox.Text = product_data[0] = (string)Program.database.Reader["name"];
                pkwiu_textBox.Text = product_data[1] = (string)Program.database.Reader["pkwiu"];
                price_textBox.Text = product_data[2] = Convert.ToString(Program.database.Reader["price"]);
                unit_comboBox.Text = product_data[3] = (string)Program.database.Reader["unit"];
                vat_comboBox.Text = product_data[4] = Convert.ToString(Program.database.Reader["vat"]);
                currency_comboBox.Text = product_data[5] = (string)Program.database.Reader["currency"];
            }
            Program.database.closeConnect();
        }

        private void cancel_product_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_product_button_Click(object sender, EventArgs e)
        {
            bool is_find = database.find_to_update(old_name);
            Program.database.closeConnect();
            if (!is_find)
                database.add_product_to_base(product_data);
            else
                database.update_product(product_data, old_name);
            products.refresh_listBox();
            this.Close();
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            product_data[0] = name_textBox.Text;
        }

        private void pkwiu_textBox_TextChanged(object sender, EventArgs e)
        {
            product_data[1] = pkwiu_textBox.Text;
        }

        private void price_textBox_TextChanged(object sender, EventArgs e)
        {
            product_data[2] = price_textBox.Text;
        }

        private void unit_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_data[3] = unit_comboBox.Text;
        }

        private void vat_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_data[4] = vat_comboBox.Text;
        }

        private void currency_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_data[5] = currency_comboBox.Text;
        }
    }
}
