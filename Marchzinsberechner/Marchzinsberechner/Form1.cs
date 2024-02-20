using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Marchzinsberechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bestaetigungs_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kunde_Name.Text) || string.IsNullOrEmpty(kunde_Guthaben.Text) ||
        string.IsNullOrEmpty(marchzins_txt.Text) || string.IsNullOrEmpty(bonuszins_txt.Text))
             {
                MessageBox.Show("Bitte füllen Sie alle Felder aus", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             if (!IsNumeric(kunde_Guthaben.Text) || !IsNumeric(marchzins_txt.Text) || !IsNumeric(bonuszins_txt.Text))
            {
                MessageBox.Show("Fehleingabe, überprüfen Sie, ob in jeder Zeile der richtige Wert steht", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Marchzinsberechner mzb = new Marchzinsberechner(Convert.ToDouble(kunde_Guthaben.Text), Convert.ToDouble(marchzins_txt.Text), Convert.ToDouble(bonuszins_txt.Text), Convert.ToInt32(geburtstags_m.Value), kunde_Name.Text, Convert.ToInt32(geburtstags_t.Value));
         
 
            this.Hide();
            Marchzinsberechnungsform Mfrom = new Marchzinsberechnungsform(mzb);
            Mfrom.Show();
        }
        private void geburtstags_m_scroll(object sender, EventArgs e)
        {
            int selectedValue = geburtstags_m.Value;  
            g_txt.Text = selectedValue.ToString(); 
                      

        }
        private void geburtstags_t_scroll(object sender, EventArgs e)
        {
            int selectedValue = geburtstags_t.Value;
            gt_txt.Text = selectedValue.ToString();
        }

        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _); 
        }

        private void kunde_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
