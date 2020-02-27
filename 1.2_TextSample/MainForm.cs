using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _1._2_TextSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!string.IsNullOrWhiteSpace(textBoxEingabe.Text))
            {
                listBoxResultat.Items.Add(listBoxResultat.Items.Count + 1 + ": " + textBoxEingabe.Text);

                // clear the text box 
                textBoxEingabe.Clear();

                // set focus to the text box again, such that the user doesn't have to click into the control again
                textBoxEingabe.Focus();
            }
            else
            {
                // wrong input
                MessageBox.Show("Please insert a text into the text box.");
            }

            Cursor.Current = Cursors.Default;
        }

        private void textBoxEingabe_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxEingabe.Text))
            {
                // enable button, since we have an input text 
                buttonHinzufuegen.Enabled = true;
            }
            else
            {
                // disable button since there is no input text 
                buttonHinzufuegen.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // add-button shall be disabled by default 
            buttonHinzufuegen.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxResultat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listBoxResultat.SelectedItem == null)
                    return;

                listBoxResultat.Items.Remove(listBoxResultat.SelectedItem);
            }
        }
    }
}
