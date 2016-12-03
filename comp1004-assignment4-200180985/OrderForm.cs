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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication()
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Mark Chipp\nVersion: 0.1.0\nWebsite: http://www.tomorrowshop.ca\nContact: 1-800-123-4567", "About");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your document will print shortly.", "Printing");
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            FinishForm finishForm = new FinishForm();

            finishForm.Show();
            this.Hide();
        }
    }
}