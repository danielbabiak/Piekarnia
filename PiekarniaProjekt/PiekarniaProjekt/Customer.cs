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
    public partial class Customer : Form
    {
        private string[] customer_data = new string[14];
        private Customer_database database = new Customer_database();
        private Shops shop;
        private string old_name = "";
        public Customer(Shops shop)
        {
            InitializeComponent();
            this.shop = shop;
        }

        public Customer(bool flag, Shops shop)
        {
            InitializeComponent();
            this.shop = shop;
            if (Program.database.Reader.Read())
            {
                old_name = company_name_textBox.Text = customer_data[0] = (string)Program.database.Reader["name"];
                nip_textBox.Text = customer_data[1] = (string)Program.database.Reader["nip"];
                regon_textBox.Text = customer_data[2] = (string)Program.database.Reader["regon"];
                bank_textBox.Text = customer_data[3] = (string)Program.database.Reader["bank"];
                account_textBox.Text = customer_data[4] = (string)Program.database.Reader["account"];
                street_textBox.Text = customer_data[5] = (string)Program.database.Reader["street"];
                home_nr_textBox.Text = customer_data[6] = (string)Program.database.Reader["streetnumber"];
                local_nr_textBox.Text = customer_data[7] = (string)Program.database.Reader["flatnumber"];
                postcode_textBox.Text = customer_data[8] = (string)Program.database.Reader["zipcode"];
                city_textBox.Text = customer_data[9] = (string)Program.database.Reader["city"];
                phone_textBox.Text = customer_data[10] = (string)Program.database.Reader["phone"];
                email_textBox.Text = customer_data[11] = (string)Program.database.Reader["email"];
                fax_textBox.Text = customer_data[12] = (string)Program.database.Reader["fax"];
                www_textBox.Text = customer_data[13] = (string)Program.database.Reader["www"];
            }
                Program.database.closeConnect();
        }

        private void cancel_customer_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_customer_button_Click(object sender, EventArgs e)
        {
            bool is_find = database.find_to_update(old_name);
            Program.database.closeConnect();
            if (!is_find)
                database.add_customer_to_base(customer_data);
            else
                database.update_customer(customer_data, old_name);
            shop.refresh_listBox();
            this.Close();
        }

        private void company_name_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[0] = company_name_textBox.Text;
        }

        private void nip_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[1] = nip_textBox.Text;
        }

        private void regon_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[2] = regon_textBox.Text;
        }

        private void bank_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[3] = bank_textBox.Text;
        }

        private void account_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[4] = account_textBox.Text;
        }

        private void street_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[5] = street_textBox.Text;
        }

        private void home_nr_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[6] = home_nr_textBox.Text;
        }

        private void local_nr_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[7] = local_nr_textBox.Text;
        }

        private void postcode_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[8] = postcode_textBox.Text;
        }

        private void city_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[9] = city_textBox.Text;
        }

        private void phone_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[10] = phone_textBox.Text;
        }

        private void email_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[11] = email_textBox.Text;
        }

        private void fax_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[12] = fax_textBox.Text;
        }

        private void www_textBox_TextChanged(object sender, EventArgs e)
        {
            customer_data[13] = www_textBox.Text;
        }
    }
}
