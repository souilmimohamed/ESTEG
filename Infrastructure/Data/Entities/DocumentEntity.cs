using System.Data;


namespace Infrastructure.Data.Entities
{
    public class DocumentEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Num { get; set; }
        public DateTime DateDocument { get; set; }
        public string Client { get; set; }
        public string Adresse { get; set; }
        public string MF { get; set; }
        public int THT { get; set; }
        public int TTVA { get; set; }
        public int TTTC { get; set; }
        public string TVA { get; set; }
        public string Letters { get; set; }
        public int Timbre { get; set; }
        public string Projets { get; set; }
        public string BC { get; set; }
        public DocumentEntity()
        {

        }
        public DocumentEntity(DataRow dataRow)
        {
            Id = Convert.ToInt32(dataRow["Id"]);
            Type = Convert.ToString(dataRow["Type"]);
            Num = Convert.ToString(dataRow["Num"]);
            DateDocument = Convert.ToDateTime(dataRow["DateDocument"]);
            Client = Convert.ToString(dataRow["Client"]);
            Adresse = Convert.ToString(dataRow["Adresse"]);
            MF = Convert.ToString(dataRow["MF"]);
            TVA = Convert.ToString(dataRow["TVA"]);
            Timbre = Convert.ToInt32(dataRow["Timbre"]);
            Projets = Convert.ToString(dataRow["Projets"]);
            BC = Convert.ToString(dataRow["BC"]);
        }
    }
}
