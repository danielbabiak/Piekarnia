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
    public partial class Shops : Form
    {
        private Shops_database database;
        public Shops()
        {
            database = new Shops_database();
            InitializeComponent();
        }

        private void new_shop_button_Click(object sender, EventArgs e)
        {
            Customer new_shop = new Customer(this);
            new_shop.Show();
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            Program.start.Show();
            this.Close();
        }

        private void edit_shop_button_Click(object sender, EventArgs e)
        {
            database.find_to_edit(list_of_shops.GetItemText(list_of_shops.SelectedItem));
            Customer edit_shop = new Customer(true, this);
            edit_shop.Show();
        }

        private void list_of_shops_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_shop_button.Enabled = true;
            delete_button.Enabled = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            database.delete_shop(list_of_shops.GetItemText(list_of_shops.SelectedItem));
            refresh_listBox();
        }
        public void refresh_listBox()
        {
            list_of_shops.Items.Clear();
            database.find_all_shops();
            while (Program.database.Reader.Read())
            {
                list_of_shops.Items.Add(Program.database.Reader["name"]);
            }
            Program.database.closeConnect();
        }
    }
}
