using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_assignment4_200180985
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void ComputersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectionTextBox.Text = ComputersDataGridView.SelectedRows[0].Cells[2].Value.ToString() + " " + ComputersDataGridView.SelectedRows[0].Cells[3].Value.ToString() + " Priced at: " + ComputersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
