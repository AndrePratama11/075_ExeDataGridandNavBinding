using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Data_Grid_View().Show();
            this.Hide();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NavBinding().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
