 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1._4_ListSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonRemove.Enabled =  false;
        }

        private void AddToList()
        {
            // falls kein Eintrag ausgewählt wurde
            if (comboBoxFood.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wähle etwas für das Frühstück aus.");
                return;
            }

            // add selected food to breakfast list 
            listBoxBreakfast.Items.Add(comboBoxFood.SelectedItem);

            // remove food from the combobox 
            comboBoxFood.Items.Remove(comboBoxFood.SelectedItem);

            if (comboBoxFood.Items.Count == 0)
            {
                // disable adding since there's nothing to choose anymore 
                buttonAdd.Enabled = false;
            }

            // enable removing since now we have at least one item in the list 
            buttonRemove.Enabled = true;
        }

        private void RemoveFromList()
        {
            // save index of selected item 
            int selectedIndex = listBoxBreakfast.SelectedIndex;

            if (selectedIndex > -1)
            {
                // add the selected food to the combobox again... 
                comboBoxFood.Items.Add(listBoxBreakfast.SelectedItem);

                // ...then remove it from the breakfast list 
                listBoxBreakfast.Items.Remove(listBoxBreakfast.SelectedItem);

                // select the item below (or the last one if there is nothing below anymore) 
                // Explanation: 
                //                  Item 1 []   -> Index = 0 
                //                  Item 2 []   -> Index = 1
                //                  Item 3 []   -> Index = 2        
                //
                // situation after Item 2 (Index = 1)  has been removed: 
                //                  Item 1 []   -> Index = 0 
                //                  Item 3 []   -> Index = 1
                if (selectedIndex >= listBoxBreakfast.Items.Count)
                    selectedIndex = listBoxBreakfast.Items.Count - 1;

                if (selectedIndex != -1)
                    listBoxBreakfast.SelectedIndex = selectedIndex;
                       
                // enable adding since now we have at least one item in the combobox 
                buttonAdd.Enabled = true;
            }

            if (listBoxBreakfast.Items.Count == 0)
            {   
                // disable removing since there's nothing to remove anymore 
                buttonRemove.Enabled = false;
            }
        }

        private void InitializeComboBox()
        {
            comboBoxFood.Items.Add("Eine Tasse Kaffe");
            comboBoxFood.Items.Add("Eine Scheibe Brot");
            comboBoxFood.Items.Add("Einen Apfel");
            comboBoxFood.Items.Add("Rührei mit Speck");
            comboBoxFood.Items.Add("Eine Tasse Tee");
            comboBoxFood.Items.Add("Ein Gipfeli");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddToList();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveFromList();
        }

        private void listBoxBreakfast_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoveFromList();
        }

        private void listBoxBreakfast_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = buttonRemove;
        }

        private void comboBoxFood_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = buttonAdd;
        }


    }
}
