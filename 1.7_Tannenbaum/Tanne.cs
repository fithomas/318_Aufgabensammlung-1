using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum_mit_Klasse
{
    public class Tanne
    {
        #region fields 

        string _resultat = string.Empty;  // init empty

        #endregion 

        #region properties

        /// <summary>
        /// Gibt die Kronenhöhe der Tanne zurück oder legt diese fest.
        /// </summary>
        public int KronenHoehe
        {
            get;
            set;
        }

        /// <summary>
        /// Gibt die Stammbreite der Tanne zurück oder legt diese fest.
        /// </summary>
        public int StammBreite
        {
            get;
            set;
        }

        /// <summary>
        /// Gibt die Stammhöhe der Tanne zurück oder legt diese fest.
        /// </summary>
        public int StammHoehe
        {
            get;
            set;
        }

        /// <summary>
        /// Gibt die gezeichnete Tanne zurück. 
        /// </summary>
        public string Resultat
        {
            get
            {
                return _resultat;
            }
        }

        #endregion 

        #region constructors

        public Tanne()
        { 
            this.KronenHoehe = 10;
            this.StammBreite = 3;
            this.StammHoehe = 3;
        }
    /// <summary>
    /// Constructor. Erstellt eine neue Instanz der Klasse "Tanne". 
    /// </summary>
    /// <param name="kronenHoehe">Die Höhe der Krone</param>
    /// <param name="stammBreite">Die Breite des Stammes</param>
    /// <param name="stammHoehe">Die Höhe des Stammes</param>
    /// 
    public Tanne(int kronenHoehe, int stammBreite, int stammHoehe)
        {
            this.KronenHoehe = kronenHoehe;
            this.StammBreite = stammBreite;
            this.StammHoehe = stammHoehe;
        }

        #endregion 
        
        #region methods

        /// <summary>
        /// Zeichnet die Tanne.
        /// </summary>
        public void Zeichne()
        {
            ZeichneKrone();
            ZeichneStamm();
        }

        private void ZeichneKrone()
        {
            for (int i = 1; i <= KronenHoehe; ++i)          // Zeichne Kronenhöhe zb i<=5
                ZeichneZeile(KronenHoehe - i, 2 * i - 1);   // Kronenhöhe - linie->enspricht Anfangsspace
        }                                                   // 2 * Linie -1 -> entspricht Stern

        private void ZeichneZeile(int anfang, int breite)
        {   // Kronenhöhe=10
            // 9,1->9<space>,1*
            // 8,3  8<space>,3*
            // 7,5  7<space>,5*
            // 6,7  6<space>,7*
            int i;
            for (i = 1; i <= anfang; ++i)
                _resultat += " ";

            for (i = 1; i <= breite; ++i)
                _resultat += "*";

            _resultat += Environment.NewLine; // Environment.NewLine --> erzeugt \r\n
        }

        private void ZeichneStamm()
        {
            for (int i = 1; i <= StammHoehe; ++i)
                ZeichneZeile((KronenHoehe - (StammBreite / 2)) - 1, StammBreite);
        }

        #endregion 
    }
}
