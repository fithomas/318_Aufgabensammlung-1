using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _1._5_PictureSample
{
    public partial class MainForm : Form
    {
       

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // save directory that was browsed last in settings 
                Properties.Settings.Default.LastOpenedDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                Properties.Settings.Default.Save();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // only allow browsing for bmp, jpg and png files 
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            // set initial directory for openfile dialog 
            if (string.IsNullOrEmpty(Properties.Settings.Default.LastOpenedDirectory))
                openFileDialog.InitialDirectory = Application.StartupPath; 
            else
                openFileDialog.InitialDirectory = Properties.Settings.Default.LastOpenedDirectory;

            // load initial pic from resources
            pictureBox.Image = Properties.Resources.Blume;
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox.ImageLocation = openFileDialog.FileName;
        }

    }
}
