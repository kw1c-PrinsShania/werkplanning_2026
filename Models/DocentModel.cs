using System;
using System.Collections.Generic;
using System.Text;

/*
    Author:     Shania Prins
    Datum:      20-05-2026

    Subject:    Een werkplanning voor schoolopdrachten
*/

namespace T8_Opdracht_Shania_Prins.Models
{
    public class DocentModel
    {
        public int DocentId { get; set; }
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public string Afbeelding { get; set; }
    }
}
