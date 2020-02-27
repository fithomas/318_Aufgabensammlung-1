using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum_mit_Klasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Tanne t=null;

            //Tanne t = new Tanne();
            //t.KronenHoehe = 8;
            //t.StammBreite = 3;
            //t.StammHoehe = 3;
            //t.Zeichne();
            //textBoxOutput.Text = t.Resultat;
            if (textBoxKronenhoehe.Text != string.Empty && textBoxStammbreite.Text != string.Empty && textBoxStammhoehe.Text != string.Empty)
            {
                t = new Tanne(Convert.ToInt32(textBoxKronenhoehe.Text)
                    , Convert.ToInt32(textBoxStammbreite.Text)
                    , Convert.ToInt32(textBoxStammhoehe.Text));

            }
            else
            {
                t = new Tanne();

            }

            // 
            //            Tanne t = new Tanne(Convert.ToInt32(textBoxKronenhoehe.Text)
            //                    , Convert.ToInt32(textBoxStammbreite.Text)
            //                    , Convert.ToInt32(textBoxStammhoehe.Text));
            // zeichnet die Tanne 
            t.Zeichne();
            // frägt resultat des Zeichnen ab 
            textBoxOutput.Text = t.Resultat;
        }

        private void textBoxKronenHoehe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // nur Zahlen und Backspace-Taste zulassen 
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
                e.Handled = true;
        }
    }
}
