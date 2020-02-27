using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotResponding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            waiting = true;
            while (waiting)
            {
                // do nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // try to stop waiting
            // will not work of course, because this event can never be handled,
            // as long as the other one is still "working"/waiting

            waiting = false;
        }

        private bool waiting;
    }
}
