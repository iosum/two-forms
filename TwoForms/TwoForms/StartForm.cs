using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoForms
{
    public partial class StartForm : Form
    {


        public StartForm()
        {
            InitializeComponent();
        }

        // This method will show the message "click me" after the button got clicked

        private void clickMeButton_Click(object sender, EventArgs e)
        {
        
                if(messageLabel.Text == "Hello")
                {
                    messageLabel.Text = "Bye";
                }
                else
                {
                    messageLabel.Text = "Hello";
                }
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            //Hide this form!
            this.Hide();
            //Instantiate the Next Form
            NextForm nextForm = new NextForm();
            //Save a reference to the current form in a property of the nextForm
            nextForm.ShowDialog();
            this.Close();
            
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the start form?", "Exit", MessageBoxButtons.YesNo);
            
            if(dialogResult == DialogResult.Yes)
            {
                System.Environment.Exit(0);

            }
            else if(dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
