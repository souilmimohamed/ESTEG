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

                string query = "INSERT INTO [Document] ([Type],[Num],[DateDocument],[Client],[Adresse],[MF],[TVA],[Timbre],[Projets],[BC]) VALUES (@Type,@Num,@DateDocument,@Client,@Adresse,@MF,@TVA,@Timbre,@Projets,@BC); ";

                using (var sqlCommand = new OleDbCommand(query, sqlConnection, sqlTransaction))
                {

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
        public static int Insert(List<Infrastructure.Data.Entities.DocumentEntity> items)
        {
            if (items != null && items.Count > 0)
            {
                int maxParamsNumber = MAX_BATCH_SIZE / 30; // Nb params per query
                int results = 0;
                if (items.Count <= maxParamsNumber)
                {
                    results = insert(items);
                }
                else
                {
                    int batchNumber = items.Count / maxParamsNumber;
                    for (int i = 0; i < batchNumber; i++)
                    {
                        results += insert(items.GetRange(i * maxParamsNumber, maxParamsNumber));
                    }
                    results += insert(items.GetRange(batchNumber * maxParamsNumber, items.Count - batchNumber * maxParamsNumber));
                }
                return results;
            }

            return -1;
        }
        private static int insert(List<Infrastructure.Data.Entities.DocumentEntity> items)
        {
            if (items != null && items.Count > 0)
            {
                int results = -1;
                using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
                {
                    sqlConnection.Open();
                    string query = "";
                    var sqlCommand = new OleDbCommand(query, sqlConnection);

                    int i = 0;
                    foreach (var item in items)
                    {
                        i++;
                        query += " INSERT INTO [Document] ([Type],[Num],[DateDocument],[Client],[Adresse],[MF],[TVA],[Timbre],[Projets],[BC]) VALUES ( "

                            + "@Type" + i + ","
                            + "@Num" + i + ","
                            + "@DateDocument" + i + ","
                            + "@Client" + i + ","
                            + "@Adresse" + i + ","
                            + "@TVA" + i + ","
                            + "@MF" + i + ","
                            + "@Timbre" + i + ","
                            + "@Projets" + i + ","
                            + "@BC" + i
                            + "); ";

                        sqlCommand.Parameters.AddWithValue("Type", item.Type == null ? (object)DBNull.Value : item.Type);
                        sqlCommand.Parameters.AddWithValue("Num" + i, item.Num == null ? (object)DBNull.Value : item.Num);
                        sqlCommand.Parameters.AddWithValue("DateDocument" + i, item.DateDocument == null ? (object)DBNull.Value : item.DateDocument);
                        sqlCommand.Parameters.AddWithValue("Client" + i, item.Client == null ? (object)DBNull.Value : item.Client);
                        sqlCommand.Parameters.AddWithValue("Adresse" + i, item.Adresse == null ? (object)DBNull.Value : item.Adresse);
                        sqlCommand.Parameters.AddWithValue("MF" + i, item.MF == null ? (object)DBNull.Value : item.MF);
                        sqlCommand.Parameters.AddWithValue("TVA" + i, item.TVA == null ? (object)DBNull.Value : item.TVA);
                        sqlCommand.Parameters.AddWithValue("Timbre" + i, item.Timbre == null ? (object)DBNull.Value : item.Timbre);
                        sqlCommand.Parameters.AddWithValue("Projets" + i, item.Projets == null ? (object)DBNull.Value : item.Projets);
                        sqlCommand.Parameters.AddWithValue("BC" + i, item.BC == null ? (object)DBNull.Value : item.BC);
                    }

                    sqlCommand.CommandText = query;

                    results = sqlCommand.ExecuteNonQuery();
                }

                return results;
            }

            return -1;
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
        public static int Update(List<Infrastructure.Data.Entities.DocumentEntity> items)
        {
            if (items != null && items.Count > 0)
            {
                int maxParamsNumber = MAX_BATCH_SIZE / 30; // Nb params per query
                int results = 0;
                if (items.Count <= maxParamsNumber)
                {
                    results = update(items);
                }
                else
                {
                    int batchNumber = items.Count / maxParamsNumber;
                    for (int i = 0; i < batchNumber; i++)
                    {
                        results += update(items.GetRange(i * maxParamsNumber, maxParamsNumber));
                    }
                    results += update(items.GetRange(batchNumber * maxParamsNumber, items.Count - batchNumber * maxParamsNumber));
                }

                return results;
            }

            return -1;
        }
        private static int update(List<Infrastructure.Data.Entities.DocumentEntity> items)
        {
            if (items != null && items.Count > 0)
            {
                int results = -1;
                using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
                {
                    sqlConnection.Open();
                    string query = "";
                    var sqlCommand = new OleDbCommand(query, sqlConnection);

                    int i = 0;
                    foreach (var item in items)
                    {
                        i++;
                        query += " UPDATE [Document] SET "

                            + "[Type]=@Type" + i + ","
                            + "[Num]=@Num" + i + ","
                            + "[DateDocument]=@DateDocument" + i + ","
                            + "[Client]=@Client" + i + ","
                            + "[Adresse]=@Adresse" + i + ","
                            + "[TVA]=@TVA" + i + ","
                            + "[Timbre]=@Timbre" + i + ","
                            + "[Projets]=@Projets" + i + ","
                            + "[BC]=@BC" + i + ","
                            + "[MF]=@MF" + i + " WHERE [Id]=@Id" + i
                            + "; ";

                        sqlCommand.Parameters.AddWithValue("Id" + i, item.Id);
                        sqlCommand.Parameters.AddWithValue("Type" + i, item.Type == null ? (object)DBNull.Value : item.Type);
                        sqlCommand.Parameters.AddWithValue("Num" + i, item.Num == null ? (object)DBNull.Value : item.Num);
                        sqlCommand.Parameters.AddWithValue("DateDocument" + i, item.DateDocument == null ? (object)DBNull.Value : item.DateDocument);
                        sqlCommand.Parameters.AddWithValue("Client" + i, item.Client == null ? (object)DBNull.Value : item.Client);
                        sqlCommand.Parameters.AddWithValue("Adresse" + i, item.Adresse == null ? (object)DBNull.Value : item.Adresse);
                        sqlCommand.Parameters.AddWithValue("MF" + i, item.MF == null ? (object)DBNull.Value : item.MF);
                        sqlCommand.Parameters.AddWithValue("TVA" + i, item.TVA == null ? (object)DBNull.Value : item.TVA);
                        sqlCommand.Parameters.AddWithValue("Timbre" + i, item.Timbre == null ? (object)DBNull.Value : item.Timbre);
                        sqlCommand.Parameters.AddWithValue("Projets" + i, item.Projets == null ? (object)DBNull.Value : item.Projets);
                        sqlCommand.Parameters.AddWithValue("BC" + i, item.BC == null ? (object)DBNull.Value : item.BC);
                    }

                    sqlCommand.CommandText = query;

                    results = sqlCommand.ExecuteNonQuery();
                }

                return results;
            }

            return -1;
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
        public static int Delete(List<int> ids)
        {
            if (ids != null && ids.Count > 0)
            {
                int maxParamsNumber = MAX_BATCH_SIZE;
                int results = 0;
                if (ids.Count <= maxParamsNumber)
                {
                    results = delete(ids);
                }
                else
                {
                    int batchNumber = ids.Count / maxParamsNumber;
                    for (int i = 0; i < batchNumber; i++)
                    {
                        results += delete(ids.GetRange(i * maxParamsNumber, maxParamsNumber));
                    }
                    results += delete(ids.GetRange(batchNumber * maxParamsNumber, ids.Count - batchNumber * maxParamsNumber));
                }
            }
            return -1;
        }
        private static int delete(List<int> ids)
        {
            if (ids != null && ids.Count > 0)
            {
                int results = -1;
                using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
                {
                    sqlConnection.Open();
                    var sqlCommand = new OleDbCommand();
                    sqlCommand.Connection = sqlConnection;

                    string queryIds = string.Empty;
                    for (int i = 0; i < ids.Count; i++)
                    {
                        queryIds += "@Id" + i + ",";
                        sqlCommand.Parameters.AddWithValue("Id" + i, ids[i]);
                    }
                    queryIds = queryIds.TrimEnd(',');

                    string query = "DELETE FROM [Document] WHERE [Id] IN (" + queryIds + ")";
                    sqlCommand.CommandText = query;

                    results = sqlCommand.ExecuteNonQuery();
                }

                return results;
            }
            return -1;
        }
        #region Custom Methods
        public static int GetMaxId(string type)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = $@"SELECT IIf(IsNull(Max(Id)), 0, Max(Id)) FROM Document WHERE Type=@Type";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Type", type);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }
            return Convert.ToInt32(dataTable.Rows[0][0]);
        }
        #endregion
    }
}