using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1._3_SelectionSample
{
    public partial class MainForm : Form
    {
        private RadioButton _selectedRadioButton; 


        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            // 3 Lösungs Varianten 
            AuswahlErmitteln_1(); // nicht praktisch bei Erweiterungen der Options, Anpassung Code 
            AuswahlErmitteln_2(); // for each erst nach Benutzerinteraktion --> siehe radioButton_CheckedChanged(..) und Casts
            AuswahlErmitteln_3();  // eleganteste for each
        }

        /// <summary>
        /// Nicht so elegante Lösung...!
        /// </summary>
        private void AuswahlErmitteln_1() 
        { 

            string auswahl = "Ausgewählt sind: " + Environment.NewLine;

            // Check state of RadioButtons in group 1
            if (radioButton1.Checked)
            {
                auswahl += radioButton1.Text + Environment.NewLine; 
            }
            else if (radioButton2.Checked)
            {
                auswahl += radioButton2.Text + Environment.NewLine;
            }
            else if (radioButton3.Checked)
            {
                auswahl += radioButton3.Text + Environment.NewLine;
            }

            // Check state of RadioButtons in group 2
            if (radioButton4.Checked)
            {
                auswahl += radioButton4.Text + Environment.NewLine;
            }
            else if (radioButton5.Checked)
            {
                auswahl += radioButton5.Text + Environment.NewLine;
            }
            else if (radioButton6.Checked)
            {
                auswahl += radioButton6.Text + Environment.NewLine;
            }

            // Check state of check boxes 
            if (checkBox1.Checked)
            {
                auswahl += checkBox1.Text + Environment.NewLine;
            }
            else if (checkBox2.Checked)
            {
                auswahl += checkBox2.Text + Environment.NewLine;
            }
            else if (checkBox3.Checked)
            {
                auswahl += checkBox3.Text + Environment.NewLine;
            }

            MessageBox.Show(auswahl);
        }

        /// <summary>
        /// Beispiel aus MSDN Hilfe.
        /// Ermittlung des selektierten Radiobuttons über radioButton_CheckedChanged Event. 
        /// Nicht so schön an dieser Lösung: _selectedRadioButton wird erst nach einer Benutzer-Interaktion instanziert -> was tun? 
        /// </summary>
        private void AuswahlErmitteln_2()
        {
            if (_selectedRadioButton != null)
            {
                MessageBox.Show("Ausgewählt in Gruppe 1 ist: " + _selectedRadioButton.Text);
            }

            // Erklären--> siehe Feinplanung 1. Tag 12:45 Uhr casts
            //foreach (control ctrl in groupboxoptions1.controls)
            //{
            //    if (ctrl is radiobutton)
            //    {
            //        radiobutton rb = (radiobutton)ctrl; // ctrl as radiobutton
            //        if (rb.checked)
            //        {
            //            messagebox.show("ausgewählt in gruppe 1 ist: " + rb.text);

            //            // we're done 
            //            return;
            //        }
            //    }
            //}

            //foreach (control ctrl in groupboxoptions2.controls)
            //{
            //    if (ctrl is radiobutton)
            //    {
            //        radiobutton rb = (radiobutton)ctrl; // ctrl as radiobutton  casten
            //        if (rb.checked)
            //        {
            //            messagebox.show("ausgewählt in gruppe 2 ist: " + rb.text);

            //            // we're done 
            //           return;
            //        }
            //    }
            //}

            //foreach (Control ctrl in groupBoxCheckboxes.Controls)
            //{
            //    if (ctrl is CheckBox)
            //    {
            //        CheckBox rb = (CheckBox)ctrl; // ctrl as RadioButton
            //        if (rb.Checked)
            //        {
            //            MessageBox.Show("Ausgewählt in Gruppe 2 ist: " + rb.Text);

            //            // we're done 
            //           return;
            //        }
            //    }
            //}

            

        }

        /// <summary>
        /// Eleganteste Lösung. 
        /// </summary>
        private void AuswahlErmitteln_3()
        {
            string auswahl = "Ausgewählt sind: " + Environment.NewLine;

            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    if (radioButton.Checked)
                        auswahl += radioButton.Text + Environment.NewLine;
                }
                foreach (CheckBox checkBox in groupBox.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked)
                        auswahl += checkBox.Text + Environment.NewLine;
                }
            }

            MessageBox.Show(auswahl);
        }

        /// <summary>
        /// Beispiel aus Hilfe MSDN: 
        /// http://msdn.microsoft.com/query/dev10.query?appId=Dev10IDEF1&l=DE-DE&k=k(SYSTEM.WINDOWS.FORMS.RADIOBUTTON);k(RADIOBUTTON);k(SOLUTIONITEMSPROJECT);k(TargetFrameworkMoniker-%22.NETFRAMEWORK%2cVERSION%3dV4.0%22);k(DevLang-CSHARP)&rd=true 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                // sender is not a RadioButton 
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // keep track of the selected RadioButton by saving a reference to it.
                _selectedRadioButton = rb;
            }
        }
    }
}
