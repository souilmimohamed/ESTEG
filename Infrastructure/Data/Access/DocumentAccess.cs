using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace Infrastructure.Data.Access
{
    public class DocumentAccess
    {
        public static int MAX_BATCH_SIZE = 500;
        public static List<Infrastructure.Data.Entities.DocumentEntity> Get()
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Document]";
                var sqlCommand = new OleDbCommand(query, sqlConnection);

                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows.Cast<DataRow>().Select(x => new Infrastructure.Data.Entities.DocumentEntity(x)).ToList();
            }
            else
            {
                return new List<Infrastructure.Data.Entities.DocumentEntity>();
            }
        }
        public static Infrastructure.Data.Entities.DocumentEntity Get(int id)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Document] WHERE Id=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return new Infrastructure.Data.Entities.DocumentEntity(dataTable.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public static int Insert(Infrastructure.Data.Entities.DocumentEntity item)
        {
            int response = int.MinValue;
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                var sqlTransaction = sqlConnection.BeginTransaction();

                string query = "INSERT INTO [Document] ([NumId],[Type],[Num],[DateDocument],[Client],[Adresse],[MF],[TVA],[Timbre],[Projets],[BC]) VALUES (@NumId,@Type,@Num,@DateDocument,@Client,@Adresse,@MF,@TVA,@Timbre,@Projets,@BC); ";

                using (var sqlCommand = new OleDbCommand(query, sqlConnection, sqlTransaction))
                {
                    sqlCommand.Parameters.AddWithValue(parameterName: "NumId", item.NumId == null ? (object)DBNull.Value : item.NumId);
                    sqlCommand.Parameters.AddWithValue("Type", item.Type == null ? (object)DBNull.Value : item.Type);
                    sqlCommand.Parameters.AddWithValue("Num", item.Num == null ? (object)DBNull.Value : item.Num);
                    sqlCommand.Parameters.AddWithValue("DateDocument", item.DateDocument == null ? (object)DBNull.Value : item.DateDocument);
                    sqlCommand.Parameters.AddWithValue("Client", item.Client == null ? (object)DBNull.Value : item.Client);
                    sqlCommand.Parameters.AddWithValue("Adresse", item.Adresse == null ? (object)DBNull.Value : item.Adresse);
                    sqlCommand.Parameters.AddWithValue("MF", item.MF == null ? (object)DBNull.Value : item.MF);
                    sqlCommand.Parameters.AddWithValue("TVA", item.TVA == null ? (object)DBNull.Value : item.TVA);
                    sqlCommand.Parameters.AddWithValue("Timbre", item.Timbre == null ? (object)DBNull.Value : item.Timbre);
                    sqlCommand.Parameters.AddWithValue("Projets", item.Projets == null ? (object)DBNull.Value : item.Projets);
                    sqlCommand.Parameters.AddWithValue("BC", item.BC == null ? (object)DBNull.Value : item.BC);

                    var result = sqlCommand.ExecuteScalar();
                    response = result == null ? int.MinValue : int.TryParse(result.ToString(), out var insertedId) ? insertedId : int.MinValue;
                }
                sqlTransaction.Commit();

                return response;
            }
        }
        public static int Update(Infrastructure.Data.Entities.DocumentEntity item)
        {
            int results = -1;
            using (OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            using (OleDbCommand sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = @"UPDATE [Document] SET Type=@Type,Num=@Num,DateDocument=@DateDocument,Client=@Client,Adresse=@Adresse,MF=@MF,TVA=@TVA,Timbre=@Timbre,Projets=@Projets,BC=@BC WHERE Id=@Id";
                sqlCommand.Parameters.AddWithValue("@Type", item.Type);
                sqlCommand.Parameters.AddWithValue("@Num", item.Num);
                sqlCommand.Parameters.AddWithValue("@DateDocument", item.DateDocument);
                sqlCommand.Parameters.AddWithValue("@Client", item.Client);
                sqlCommand.Parameters.AddWithValue("@Adresse", item.Adresse);
                sqlCommand.Parameters.AddWithValue("@MF", item.MF);
                sqlCommand.Parameters.AddWithValue("@TVA", item.TVA);
                sqlCommand.Parameters.AddWithValue("@Timbre", item.Timbre);
                sqlCommand.Parameters.AddWithValue("@Projets", item.Projets);
                sqlCommand.Parameters.AddWithValue("@BC", item.BC);
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
                string query = "DELETE FROM [Document] WHERE [Id]=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);

                results = sqlCommand.ExecuteNonQuery();
            }

            return results;
        }
        #region Custom Methods
        public static int GetMaxCount(string type)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = $@"SELECT IIf(MAX([NumId]) Is Null, 0, MAX([NumId])) FROM Document where Type=@type";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Type", type);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }
            return Convert.ToInt32(dataTable.Rows[0][0]);
        }
        public static int GetMaxId(string type)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = $@"SELECT MAX(Id) FROM Document WHERE Type=@Type";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Type", type);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }
            return Convert.ToInt32(dataTable.Rows[0][0]);
        }
        #endregion
    }
}