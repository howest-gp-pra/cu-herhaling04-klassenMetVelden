using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.HerhalingKlassenFields.CORE
{
    // NIET VERGETEN: je klassen publiek maken !
    public class PersoonMetVelden
    {
        // we werken hier met velden, nog NIET met properties
        // ter herinnering : velden zijn eigenlijk niets meer dan variabelen die je publiek toegangkelijk maakt
        // ter herinnering : gebruik je velden, schrijf die dan met een kleine letter

        public string naam;
        public string voornaam;
        public DateTime geboortedatum;
        public char geslacht;  // afspraak : M = man, V = vrouw, O = onbekend
    }
}

