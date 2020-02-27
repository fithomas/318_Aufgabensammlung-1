using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1._6_TimerSample
{
    public partial class MainForm : Form
    {
        int _timerStartValue = 10;
        int _timerCurrentValue = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // multi-purpose button 
            Button b = (Button)sender;              
            // oder: Button b = sender as Button;
            
            switch (b.Text)
            {
                case "Start":
                    b.Text = "Stop";
                    StartCountdown();
                    break;
               
                case "Stop":
                    timer.Stop();
                    b.Text = "Continue";
                    break;
               
                case "Reset":
                    b.Text = "Start";
                    ResetCountdown();
                    break;
             
                case "Continue":
                    timer.Start();
                    b.Text = "Stop";
                    break;
                
                default:
                    // do nothing 
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            textBoxCountdown.Text = (--_timerCurrentValue).ToString();
            if (_timerCurrentValue.Equals(0))
            {
                timer.Stop();
                buttonStart.Text = "Reset";
            }

        }

         private void MainForm_Load(object sender, EventArgs e)
        {
            // set initial start value of the timer 
            textBoxCountdown.Text = _timerStartValue.ToString();
        }


        private void StartCountdown()
        {
            if (!int.TryParse(textBoxCountdown.Text, out _timerStartValue))
            {
                MessageBox.Show("Ungültige Eingabe. Nur Ganzzahl erlaubt.");
                textBoxCountdown.SelectAll();
                return;
            }

            _timerCurrentValue = _timerStartValue;
            textBoxCountdown.Enabled = false;
            timer.Start();
        }

        private void ResetCountdown()
        {
            textBoxCountdown.Enabled = true;
            textBoxCountdown.Text = _timerStartValue.ToString();
        }
    }
}
