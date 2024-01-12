using System.Data;


namespace Infrastructure.Data.Entities
{
    public class PointageEntity
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int Mois { get; set; }
        public int Jour { get; set; }
        public int Annee { get; set; }
        public bool Presence { get; set; }
        public int Avance { get; set; }
        public string Lieu { get; set; }
        public string Divers { get; set; }
        public PointageEntity()
        {

        }
        public PointageEntity(DataRow dataRow)
        {
            Id = Convert.ToInt32(dataRow["Id"]);
            IdEmployee = Convert.ToInt32(dataRow["IdEmployee"]);
            Mois = Convert.ToInt32(dataRow["Mois"]);
            Jour = Convert.ToInt32(dataRow["Jour"]);
            Annee = Convert.ToInt32(dataRow["Annee"]);
            Presence = Convert.ToBoolean(dataRow["Presence"]);
            Avance = Convert.ToInt32(dataRow["Avance"]);
            Lieu = Convert.ToString(dataRow["Lieu"]);
            Divers = Convert.ToString(dataRow["Divers"]);
        }
    }
}