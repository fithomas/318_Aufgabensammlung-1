using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Heapoverflow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // out of memory
            const int count = 100000;
            Buffer[] buffers = new Buffer[count];

            // try to allocate 100'000 buffers
            for (int i = 0; i < count; ++i)
            {
                // a buffer allocates one megabyte
                buffers[i] = new Buffer();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // out of memory
            const int count = 100000;
            char[,] chars = new char[count, count];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // not a heap overflow but an arithmetic one (number doesn't fit into int anymore)
            //char[] chars = new char[100000000000];

            try
            {
                string myNumber = null;
                int extractedNumber = int.Parse(myNumber);
                MessageBox.Show("Number: " + extractedNumber.ToString());
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Null argument");
            }
            catch
            {
                MessageBox.Show("Unknown error");
            }




            /*
            int extractedNumber;
            bool success = int.TryParse("123a", out extractedNumber);
            if (success)
                MessageBox.Show("Number: " + extractedNumber.ToString());
            else
                MessageBox.Show("Could not extract the number");
             * */


            /*
            try
            {
                char[] chars = new char[1000000000];
            }
            catch (OverflowException overFlow)
            {
                MessageBox.Show("Too large number!" + Environment.NewLine + overFlow.Message);
            }
            catch (OutOfMemoryException outOfMemory)
            {
                MessageBox.Show("Not enough memory!" + Environment.NewLine + outOfMemory.Message);
            }
            catch
            {
                MessageBox.Show("Unknown error!" + Environment.NewLine);
            }
            */
        }
    }
}
