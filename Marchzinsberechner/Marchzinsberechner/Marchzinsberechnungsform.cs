using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marchzinsberechner
{
    public partial class Marchzinsberechnungsform : Form
    {
        Marchzinsberechner zinsberechner;
        public Marchzinsberechnungsform(Marchzinsberechner mazibe)
        {
            InitializeComponent();
            zinsberechner = (Marchzinsberechner) mazibe;
            
              }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
         }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zinsberechner.marchzinsberechnung(tagvon.Value, monatvon.Value, tagbis.Value, monatbis.Value, zinsberechner.geburtagsmonat, zinsberechner.gtag));

        }
        private void vontag_scroll(object sender, EventArgs e)
        {
            int selectedValue = tagvon.Value;
            tagvon_txt.Text = "Tag: " + selectedValue.ToString();


        }
        private void vonmonat_scroll(object sender, EventArgs e)
        {
            int selectedValue = monatvon.Value;
            monatvon_txt.Text = "Monat: " + selectedValue.ToString();


        }
        private void bistag_scroll(object sender, EventArgs e)
        {
            int selectedValue = tagbis.Value;
            tagbis_txt.Text = "Tag: " + selectedValue.ToString();


        }
        private void bismonat_scroll(object sender, EventArgs e)
        {
            int selectedValue = monatbis.Value;
            monatbis_txt.Text = "Monat: "+ selectedValue.ToString();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Der Zins welcher " + zinsberechner.kunde_name + " auf seinem Konto mit " + Math.Round(zinsberechner.kunde_guthaben, 2) + " Fr. erhält beläuft sich auf " + Math.Round(zinsberechner.kompletezinsberechnung(), 2) + " Fr. \n Nettozins 65%: " + Math.Round(zinsberechner.kompletezinsberechnung() / 100 * 65, 2)
            + "\n Verrechnungssteuer Total 35%:" + Math.Round(zinsberechner.kompletezinsberechnung() / 100 * 35, 2)
            + "\nAnteil Normaler Zins: " + Math.Round(zinsberechner.zins_ohne_bonus, 2)
            + "\n Normaler Zins Aufteilung: \n Verrechnungssteuer 35% = " + Math.Round(zinsberechner.zins_ohne_bonus / 100 * 35, 2)
            + "\n Netto Normaler Zins 65% =" + Math.Round(zinsberechner.zins_ohne_bonus / 100 * 65, 2)
            + "\n Anteil Bonuszins: " + Math.Round(zinsberechner.bonuszins, 2)
            + "\n Bonuszins Aufteilung: \n Verrechnungssteuer 35% = " + Math.Round(zinsberechner.bonuszins / 100 * 35, 2)
            + " \n Netto Bonuszins 65% = " + Math.Round(zinsberechner.bonuszins / 100 * 65, 2)
            + "\n Zinssatz Normaler Zins = " + Math.Round(zinsberechner.marchzins, 2)
            + " \n Zinssatz Bonus Zin = " + Math.Round(zinsberechner.bonuszinssatzz, 2));
        }
    }
}
