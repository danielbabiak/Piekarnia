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
    public partial class New_sale : Form
    {
        public New_sale()
        {
            InitializeComponent();
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            Program.start.Show();
            this.Close();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {

        }
    }
}
