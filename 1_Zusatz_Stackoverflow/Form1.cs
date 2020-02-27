using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stackoverflow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // generate stack overflow by recursively calling the method again
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // generate stack overflow by calling another recursive method
            callStack(0);
        }

        private void callStack(int level)
        {
            // the level tells us in the end, how many times the function could be called recursively before the stack became too large
            callStack(level + 1);
        }
    }
}
