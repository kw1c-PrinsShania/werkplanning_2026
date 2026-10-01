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
    public class ModuleModel
    {
        public int ModuleId { get; set; }
        public string ModuleNaam { get; set; }
        public ThemaModel Thema { get; set; }
        public DocentModel Docent { get; set; }
    }
}
