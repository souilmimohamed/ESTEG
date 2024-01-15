using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Entities
{
    public class PointageSommaire
    {
        public string NomPrenom { get; set; }
        public string Mois { get; set; }
        public int Annee { get; set; }
        public int TarifJournalier { get; set; }
        public int NombreJoursTravailee { get; set; }
        public int TotalParMois { get; set; }
        public int TotalAvance { get; set; }
        public int TotalAPayer { get; set; }
    }
    public class PointageDetails
    {
        public string Date { get; set; }
        public int Avance { get; set; }
        public string Lieu { get; set; }
        public string Divers { get; set; }
    }
}
