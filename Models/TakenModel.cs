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
    public class TakenModel
    {
        public int TaakId { get; set; }   // Primary Key
        public string Taaknaam { get; set; }
        public string Omschrijving { get; set; }
        public DateTime Startdatum { get; set; }
        public DateTime Inleverdatum { get; set; }
        public string Status { get; set; }
        public ModuleModel Module { get; set; }
    }
}
