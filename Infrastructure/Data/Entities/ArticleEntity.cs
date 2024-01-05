using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Entities
{
    public class ArticleEntity
    {
        public int Id { get; set; }
        public int IdFacture { get; set; }
        public int Quantite { get; set; }
        public string Designation { get; set; }
        public string Unite { get; set; }
        public int PUHT { get; set; }
        public string TVA { get; set; }
        public int PTHT { get; set; }
        public ArticleEntity()
        {

        }
        public ArticleEntity(DataRow dataRow)
        {
            Id = Convert.ToInt32(dataRow["Id"]);
            IdFacture = Convert.ToInt32(dataRow["IdFacture"]);
            Quantite = Convert.ToInt32(dataRow["Qte"]);
            Designation = Convert.ToString(dataRow["Designation"]);
            Unite = Convert.ToString(dataRow["Unite"]);
            PUHT = Convert.ToInt32(dataRow["Puht"]);
            TVA = Convert.ToString(dataRow["Tva"]);
            PTHT = Convert.ToInt32(dataRow["Ptht"]);
        }
    }
}
