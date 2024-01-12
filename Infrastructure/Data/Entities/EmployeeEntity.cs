using System.Data;

namespace Infrastructure.Data.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string NomPrenom { get; set; }
        public int TarifJounalier { get; set; }
        public EmployeeEntity()
        {

        }
        public EmployeeEntity(DataRow dataRow)
        {
            Id = Convert.ToInt32(dataRow["Id"]);
            NomPrenom = Convert.ToString(dataRow["NomPrenom"]);
            TarifJounalier = Convert.ToInt32(dataRow["TarifJounalier"]);
        }
    }
}