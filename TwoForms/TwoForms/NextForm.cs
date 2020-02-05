using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoForms
{
    public partial class NextForm : Form
    {
      


        public NextForm()
        {
            InitializeComponent();
        }



        private void NextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the next form?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
                showStartForm();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }


        }
        private void backButton_Click(object sender, EventArgs e)
        {
            showStartForm();
        }

        private void showStartForm()
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
            this.Close();
        }
    }
}
