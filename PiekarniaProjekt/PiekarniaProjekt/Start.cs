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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Products_button_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            Program.start.Hide();
        }

        private void Shop_button_Click(object sender, EventArgs e)
        {
            Shops shop = new Shops();
            shop.Show();
            Program.start.Hide();
        }

        private void New_sell_button_Click(object sender, EventArgs e)
        {
            New_sale new_sell = new New_sale();
            new_sell.Show();
            Program.start.Hide();
        }

        private void Archives_button_Click(object sender, EventArgs e)
        {
            Archives arch = new Archives();
            arch.Show();
            Program.start.Hide();
        }
    }
}
