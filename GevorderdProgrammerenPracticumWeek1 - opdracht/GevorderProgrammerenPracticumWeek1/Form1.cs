using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GevorderProgrammerenPracticumWeek1
{
    /// <summary>
    /// Code van het formulier
    /// </summary>
    public partial class formPracticumWeek1 : Form
    {
        private List<Persoon> personen;
        private Persoon selectedPersoon;

        /// <summary>
        /// Constructor
        /// </summary>
        public formPracticumWeek1()
        {
            personen = new List<Persoon>();
            InitializeComponent();
        }
        
        private void buttonAddPersoon_Click(object sender, EventArgs e)
        {
            int leeftijd;
            if (textBoxVoornaam.Text != "" && textBoxAchternaam.Text != "" && int.TryParse(textBoxLeeftijd.Text, out leeftijd))
            {
                personen.Add(new Persoon(textBoxVoornaam.Text, textBoxAchternaam.Text, leeftijd));
                showPersonen();
                clearTextboxenPersoon();
            }
            else
                MessageBox.Show("Er is iets verkeerd ingvoerd", "Error");
        }

        /// <summary>
        /// Laat alle personen zien in de listbox voor personen
        /// </summary>
        private void showPersonen()
        {
            listBoxPersonen.Items.Clear();
            foreach (Persoon p in personen)
            {
                listBoxPersonen.Items.Add(p.getNaam());
            }
        }

        /// <summary>
        /// Haalt de invoer uit de tekstboxen van een persoon weg
        /// </summary>
        private void clearTextboxenPersoon()
        {
            textBoxVoornaam.Text = "";
            textBoxAchternaam.Text = "";
            textBoxLeeftijd.Text = "";
        }

        /// <summary>
        /// Haalt de invoer uit de tekstboxen van een huisdier weg
        /// </summary>
        private void clearTextboxenHuisdier()
        {
            textBoxHuisdierNaam.Text = "";
            textBoxHuisdierSoort.Text = "";
        }

        private void listBoxPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPersoon = personen[listBoxPersonen.SelectedIndex];
            showHuisdieren(selectedPersoon);
            buttonAddHuisdier.Enabled = true;
        }

        /// <summary>
        /// Laat alle huisdieren van de geselecteerde persoon zien in de listbox voor huisdieren
        /// </summary>
        private void showHuisdieren(Persoon p)
        {
            listBoxHuisdieren.Items.Clear();
            foreach (Huisdier hd in p.getHuisdieren())
            {
                listBoxHuisdieren.Items.Add(hd.getBeschrijving());
            }
        }

        private void buttonAddHuisdier_Click(object sender, EventArgs e)
        {
            if (textBoxHuisdierNaam.Text != "" && textBoxHuisdierSoort.Text != "")
            {
                selectedPersoon.addHuisdier(new Huisdier(textBoxHuisdierNaam.Text, textBoxHuisdierSoort.Text));
                showHuisdieren(selectedPersoon);
                clearTextboxenHuisdier();
            }
        }

        private void listBoxHuisdieren_SelectedIndexChanged(object sender, EventArgs e)
        {
            Huisdier h = selectedPersoon.getHuisdieren()[listBoxHuisdieren.SelectedIndex];
            MessageBox.Show(h.getNaam() + " is een " + h.getSoort() + ".\n" + selectedPersoon.getNaam() + " (" + selectedPersoon.getLeeftijd() + " jaar oud) is de eigenaar.", "Info");
        }
    }
}
