using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            float liczba1, liczba2, wynik = 0;
            try
            {
                liczba1 = float.Parse(txtLiczba1.Text);
                liczba2 = float.Parse(txtLiczba2.Text);

                wynik = liczba1 + liczba2;
                lblEtykieta.Text = wynik.ToString();
            }
            catch (Exception ex)
            {
                lblEtykieta.Text = "Prawdopodobnie nie podałeś liczby lub błędne dane";

            }


        }

        private void btnOdejmij_Click(object sender, EventArgs e)
        {
            float liczba1, liczba2, wynik = 0;
            try
            {
                liczba1 = float.Parse(txtLiczba1.Text);
                liczba2 = float.Parse(txtLiczba2.Text);

                wynik = liczba1 - liczba2;
                lblEtykieta.Text = wynik.ToString();
            }
            catch (Exception ex)
            {
                lblEtykieta.Text = "Prawdopodobnie nie podałeś liczby lub błędne dane";

            }

        }

        private void btnPomnoz_Click(object sender, EventArgs e)
        {
            float liczba1, liczba2, wynik = 0;
            try
            {
                liczba1 = float.Parse(txtLiczba1.Text);
                liczba2 = float.Parse(txtLiczba2.Text);

                wynik = liczba1 * liczba2;
                lblEtykieta.Text = wynik.ToString();
            }
            catch (Exception ex)
            {
                lblEtykieta.Text = "Prawdopodobnie nie podałeś liczby lub błędne dane";

            }
        }

        private void btnPodziel_Click(object sender, EventArgs e)
        {
            float liczba1, liczba2, wynik = 0;
            try
            {
                liczba1 = float.Parse(txtLiczba1.Text);
                liczba2 = float.Parse(txtLiczba2.Text);

                wynik = liczba1 /liczba2;
                lblEtykieta.Text = wynik.ToString();
            }
            catch (Exception ex)
            {
                lblEtykieta.Text = "Prawdopodobnie nie podałeś liczby lub błędne dane";

            }
        }
    }
}