
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_krzyzyk_p4_zaliczenie
{
    public partial class Wyniki : Form
    {
        public Wyniki()
        {
            InitializeComponent();
        }

        private void Wyniki_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = dataTable1TableAdapter1.GetData();
        }

        private void btnSortuj_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataTable1TableAdapter1.SortujDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataTable1TableAdapter1.SzukajGracz(textBoxGr.Text);
           
           
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            dataTable1TableAdapter1.Delete1(row);

            dataGridView1.DataSource = dataTable1TableAdapter1.GetData();
            textBoxGr.Text = "";
            numericUpDown1.Value = 0;
        }
    }
}
