using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pra.HerhalingKlassenFields.CORE;

namespace Pra.HerhalingKlassenFields.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // NIET VERGETEN : referentie maken naar class library (is hier al gebeurd)
        //                 in .Net Core : in je WPF project rechts klikken op Dependencies en kiezen voor Add Reference
        // NIET VERGETEN : using statement (namespace) hier bovenaan voorzien (is hier al gebeurd)
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPMV1_Click(object sender, RoutedEventArgs e)
        {

            // versie 1, die gebruikt maakt van een klassen MET ENKEL VELDEN
            // we gaan 3 personen toevoegen.  Voor elke persoon (= "instantie van de klasse" of gewoon "object")
            // maken we een nieuwe variabele aan
            PersoonMetVelden persoon1 = new PersoonMetVelden();
            persoon1.naam = "Piraat";
            persoon1.voornaam = "Piet";
            persoon1.geboortedatum = DateTime.Parse("1987-05-30");
            persoon1.geslacht = 'M';
            PersoonMetVelden persoon2 = new PersoonMetVelden();
            persoon2.naam = "Taar";
            persoon2.voornaam = "Guy";
            persoon2.geboortedatum = DateTime.Parse("1961-11-03");
            persoon2.geslacht = 'M';
            PersoonMetVelden persoon3 = new PersoonMetVelden();
            persoon3.naam = "Ba";
            persoon3.voornaam = "Sam";
            persoon3.geboortedatum = DateTime.Parse("1012-01-03");
            persoon3.geslacht = 'X';


            lstDisplay.Items.Clear();

            lstDisplay.Items.Add(persoon1.voornaam + " " + persoon1.naam + " (geslacht = " + persoon1.geslacht + ")");
            lstDisplay.Items.Add(persoon2.voornaam + " " + persoon2.naam + " (geslacht = " + persoon2.geslacht + ")");
            lstDisplay.Items.Add($"{persoon3.voornaam} {persoon3.naam} (geslacht = {persoon3.geslacht} )");  // alternatieve schrijfwijze

        }

        private void BtnPMV2_Click(object sender, RoutedEventArgs e)
        {
            // versie 2, die gebruikt maakt van een klassen MET ENKEL VELDEN
            // we gaan 3 personen toevoegen.  
            // we gaan nu slechts 1 veriabele gebruiken maar omdat we telkens een nieuwe instantie
            // maken blijven het wel 3 verschillende OBJECTEN


            lstDisplay.Items.Clear();

            PersoonMetVelden persoon = new PersoonMetVelden();
            persoon.naam = "Piraat";
            persoon.voornaam = "Piet";
            persoon.geboortedatum = DateTime.Parse("1987-05-30");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden();
            persoon.naam = "Taar";
            persoon.voornaam = "Guy";
            persoon.geboortedatum = DateTime.Parse("1961-11-03");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden();
            persoon.naam = "Ba";
            persoon.voornaam = "Sam";
            persoon.geboortedatum = DateTime.Parse("1012-01-03");
            persoon.geslacht = 'X';
            lstDisplay.Items.Add($"{persoon.voornaam} {persoon.naam} (geslacht = {persoon.geslacht} )");  // alternatieve schrijfwijze
        }

        private void BtnPMV3_Click(object sender, RoutedEventArgs e)
        {
            // versie 3, die gebruikt maakt van een klassen MET ENKEL VELDEN
            // we gaan hetzelfde doen als versie 2 maar we voegen die onmiddellijk toe aan een List


            lstDisplay.Items.Clear();

            List<PersoonMetVelden> personen = new List<PersoonMetVelden>();

            PersoonMetVelden persoon = new PersoonMetVelden();
            persoon.naam = "Piraat";
            persoon.voornaam = "Piet";
            persoon.geboortedatum = DateTime.Parse("1987-05-30");
            persoon.geslacht = 'M';
            personen.Add(persoon);

            persoon = new PersoonMetVelden();
            persoon.naam = "Taar";
            persoon.voornaam = "Guy";
            persoon.geboortedatum = DateTime.Parse("1961-11-03");
            persoon.geslacht = 'M';
            personen.Add(persoon);

            persoon = new PersoonMetVelden();
            persoon.naam = "Ba";
            persoon.voornaam = "Sam";
            persoon.geboortedatum = DateTime.Parse("1012-01-03");
            persoon.geslacht = 'X';
            personen.Add(persoon);

            foreach (PersoonMetVelden p in personen)
            {
                lstDisplay.Items.Add($"{p.voornaam} {p.naam} (geslacht = {p.geslacht} )");
            }
        }
        private void BtnPMV4_Click(object sender, RoutedEventArgs e)
        {
            // versie 4, die gebruikt maakt van een klassen MET ENKEL VELDEN 
            // we gaan nu de objecten onmiddellijk in onze list aanmaken


            lstDisplay.Items.Clear();

            List<PersoonMetVelden> personen = new List<PersoonMetVelden>();
            personen.Add(new PersoonMetVelden() { naam = "Piraat", voornaam = "Piet", geboortedatum = DateTime.Parse("1987-05-30"), geslacht = 'M' });
            personen.Add(new PersoonMetVelden() { naam = "Taar", voornaam = "Guy", geboortedatum = DateTime.Parse("1961-11-03"), geslacht = 'M' });
            personen.Add(new PersoonMetVelden() { naam = "Ba", voornaam = "Sam", geboortedatum = DateTime.Parse("1012-01-03"), geslacht = 'X' });

            foreach (PersoonMetVelden p in personen)
            {
                lstDisplay.Items.Add($"{p.voornaam} {p.naam} (geslacht = {p.geslacht} )");
            }
        }
    }
}
