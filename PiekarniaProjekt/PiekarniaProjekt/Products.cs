using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiekarniaProjekt
{
    public partial class Products : Form
    {
        Products_database database;
        public Products()
        {
            database = new Products_database();
            InitializeComponent();
        }

        private void new_product_button_Click(object sender, EventArgs e)
        {
            Product new_product = new Product(this);
            new_product.Show();
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            Program.start.Show();
            this.Close();
        }

        private void edit_product_button_Click(object sender, EventArgs e)
        {
            database.find_to_edit(list_of_products.GetItemText(list_of_products.SelectedItem));
            Product edit_product = new Product(true, this);
            edit_product.Show();
        }

        public void refresh_listBox()
        {
            list_of_products.Items.Clear();
            database.find_all_products();
            while (Program.database.Reader.Read())
            {
                list_of_products.Items.Add(Program.database.Reader["name"]);
            }
            Program.database.closeConnect();
        }

        private void list_of_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_product_button.Enabled = true;
            delete_button.Enabled = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            database.delete_product(list_of_products.GetItemText(list_of_products.SelectedItem));
            refresh_listBox();
        }
    }
}
