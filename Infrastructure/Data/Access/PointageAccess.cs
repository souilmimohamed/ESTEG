using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace Infrastructure.Data.Access
{
    public class PointageAccess
    {
        public static int MAX_BATCH_SIZE = 500;
        public static List<Infrastructure.Data.Entities.PointageEntity> Get()
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Pointage]";
                var sqlCommand = new OleDbCommand(query, sqlConnection);

                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows.Cast<DataRow>().Select(x => new Infrastructure.Data.Entities.PointageEntity(x)).ToList();
            }
            else
            {
                return new List<Infrastructure.Data.Entities.PointageEntity>();
            }
        }
        public static Infrastructure.Data.Entities.PointageEntity Get(int id)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Pointage] WHERE Id=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return new Infrastructure.Data.Entities.PointageEntity(dataTable.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public static int Insert(Infrastructure.Data.Entities.PointageEntity item)
        {
            int response = int.MinValue;
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                var sqlTransaction = sqlConnection.BeginTransaction();

                string query = "INSERT INTO [Pointage] ([IdEmployee],[Mois],[Jour],[Annee],[Presence],[Avance],[Lieu],[Divers]) VALUES (@IdEmployee,@Mois,@Jour,@Annee,@Presence,@Avance,@Lieu,@Divers); ";

                using (var sqlCommand = new OleDbCommand(query, sqlConnection, sqlTransaction))
                {

                    sqlCommand.Parameters.AddWithValue("IdEmployee", item.IdEmployee == null ? (object)DBNull.Value : item.IdEmployee);
                    sqlCommand.Parameters.AddWithValue("Mois", item.Mois == null ? (object)DBNull.Value : item.Mois);
                    sqlCommand.Parameters.AddWithValue("Jour", item.Jour == null ? (object)DBNull.Value : item.Jour);
                    sqlCommand.Parameters.AddWithValue("Annee", item.Annee == null ? (object)DBNull.Value : item.Annee);
                    sqlCommand.Parameters.AddWithValue("Presence", item.Presence == null ? (object)DBNull.Value : item.Presence);
                    sqlCommand.Parameters.AddWithValue("Avance", item.Avance == null ? (object)DBNull.Value : item.Avance);
                    sqlCommand.Parameters.AddWithValue("Lieu", item.Lieu == null ? (object)DBNull.Value : item.Lieu);
                    sqlCommand.Parameters.AddWithValue("Divers", item.Divers == null ? (object)DBNull.Value : item.Divers);

                    var result = sqlCommand.ExecuteScalar();
                    response = result == null ? int.MinValue : int.TryParse(result.ToString(), out var insertedId) ? insertedId : int.MinValue;
                }
                sqlTransaction.Commit();

                return response;
            }
        }
        public static int Update(Infrastructure.Data.Entities.PointageEntity item)
        {
            int results = -1;
            using (OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            using (OleDbCommand sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = @"UPDATE [Pointage] SET IdEmployee=@IdEmployee,Mois=@Mois,Jour=@Jour,Annee=@Annee,Presence=@Presence,Avance=@Avance,Lieu=@Lieu,Divers=@Divers WHERE Id=@Id";
                sqlCommand.Parameters.AddWithValue("@IdEmployee", item.IdEmployee);
                sqlCommand.Parameters.AddWithValue("@Mois", item.Mois);
                sqlCommand.Parameters.AddWithValue("@Jour", item.Jour);
                sqlCommand.Parameters.AddWithValue("@Annee", item.Annee);
                sqlCommand.Parameters.AddWithValue("@Presence", item.Presence);
                sqlCommand.Parameters.AddWithValue("@Avance", item.Avance);
                sqlCommand.Parameters.AddWithValue("@Lieu", item.Lieu);
                sqlCommand.Parameters.AddWithValue("@Divers", item.Divers);
                sqlCommand.Parameters.AddWithValue("@Id", item.Id);

                sqlConnection.Open();
                results = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return results;
        }
        public static int Delete(int id)
        {
            int results = -1;
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "DELETE FROM [Pointage] WHERE [Id]=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);

                results = sqlCommand.ExecuteNonQuery();
            }

            return results;
        }
        #region Custom Methods
        public static List<Infrastructure.Data.Entities.PointageEntity> GetByEmployeeIdAndYear(int IdEmployee, int annee)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Pointage] WHERE [IdEmployee]=@IdEmployee AND [Annee]=@Annee";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("IdEmployee", IdEmployee);
                sqlCommand.Parameters.AddWithValue("Annee", annee);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows.Cast<DataRow>().Select(x => new Infrastructure.Data.Entities.PointageEntity(x)).ToList();
            }
            else
            {
                return new List<Infrastructure.Data.Entities.PointageEntity>();
            }
        }
        #endregion
    }
}