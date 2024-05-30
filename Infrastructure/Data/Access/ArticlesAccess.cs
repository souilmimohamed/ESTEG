using System.Configuration;
using System.Data;
using System.Data.OleDb;


namespace Infrastructure.Data.Access
{
    public class ArticlesAccess
    {
        public static int MAX_BATCH_SIZE = 500;
        public static List<Infrastructure.Data.Entities.ArticleEntity> Get()
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Article]";
                var sqlCommand = new OleDbCommand(query, sqlConnection);

                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows.Cast<DataRow>().Select(x => new Infrastructure.Data.Entities.ArticleEntity(x)).ToList();
            }
            else
            {
                return new List<Infrastructure.Data.Entities.ArticleEntity>();
            }
        }
        public static Infrastructure.Data.Entities.ArticleEntity Get(int id)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Article] WHERE [Id]=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);

                new OleDbDataAdapter(sqlCommand).Fill(dataTable);

            }

            if (dataTable.Rows.Count > 0)
            {
                return new Infrastructure.Data.Entities.ArticleEntity(dataTable.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public static int Insert(Infrastructure.Data.Entities.ArticleEntity item)
        {
            int response = int.MinValue;
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                var sqlTransaction = sqlConnection.BeginTransaction();

                string query = "INSERT INTO [Article] ([IdFacture],[Qte],[Designation],[Unite],[Puht],[Tva],[Ptht]) VALUES (@IdFacture,@Qte,@Designation,@Unite,@Puht,@Tva,@Ptht); ";

                using (var sqlCommand = new OleDbCommand(query, sqlConnection, sqlTransaction))
                {

                    sqlCommand.Parameters.AddWithValue("IdFacture", item.IdFacture == null ? (object)DBNull.Value : item.IdFacture);
                    sqlCommand.Parameters.AddWithValue("Qte", item.Quantite == null ? (object)DBNull.Value : item.Quantite);
                    sqlCommand.Parameters.AddWithValue("Designation", item.Designation == null ? (object)DBNull.Value : item.Designation);
                    sqlCommand.Parameters.AddWithValue("Unite", item.Unite == null ? (object)DBNull.Value : item.Unite);
                    sqlCommand.Parameters.AddWithValue("Puht", item.PUHT == null ? (object)DBNull.Value : item.PUHT);
                    sqlCommand.Parameters.AddWithValue("Tva", item.TVA == null ? (object)DBNull.Value : item.TVA);
                    sqlCommand.Parameters.AddWithValue("Ptht", item.PTHT == null ? (object)DBNull.Value : item.PTHT);

                    var result = sqlCommand.ExecuteScalar();
                    response = result == null ? int.MinValue : int.TryParse(result.ToString(), out var insertedId) ? insertedId : int.MinValue;
                }
                sqlTransaction.Commit();

                return response;
            }
        }
        public static int Insert(List<Infrastructure.Data.Entities.ArticleEntity> items)
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
        private static int insert(List<Infrastructure.Data.Entities.ArticleEntity> items)
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
                        query += " INSERT INTO [Document] ([IdFacture],[Qte],[Designation],[Unite],[Puht],[Tva],[Ptht]) VALUES ( "

                            + "@IdFacture" + i + ","
                            + "@Qte" + i + ","
                            + "@Designation" + i + ","
                            + "@Unite" + i + ","
                            + "@Puht" + i + ","
                            + "@Tva" + i + ","
                            + "@Ptht" + i
                            + "); ";


                        sqlCommand.Parameters.AddWithValue("IdFacture" + i, item.IdFacture == null ? (object)DBNull.Value : item.IdFacture);
                        sqlCommand.Parameters.AddWithValue("Qte" + i, item.Quantite == null ? (object)DBNull.Value : item.Quantite);
                        sqlCommand.Parameters.AddWithValue("Designation" + i, item.Designation == null ? (object)DBNull.Value : item.Designation);
                        sqlCommand.Parameters.AddWithValue("Unite" + i, item.Unite == null ? (object)DBNull.Value : item.Unite);
                        sqlCommand.Parameters.AddWithValue("Puht" + i, item.PUHT == null ? (object)DBNull.Value : item.PUHT);
                        sqlCommand.Parameters.AddWithValue("Tva" + i, item.TVA == null ? (object)DBNull.Value : item.TVA);
                        sqlCommand.Parameters.AddWithValue("Ptht" + i, item.PTHT == null ? (object)DBNull.Value : item.PTHT);
                    }

                    sqlCommand.CommandText = query;

                    results = sqlCommand.ExecuteNonQuery();
                }

                return results;
            }

            return -1;
        }
        public static int Update(Infrastructure.Data.Entities.ArticleEntity item)
        {
            int results = -1;
            using (OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            using (OleDbCommand sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = $"UPDATE [Article] SET IdFacture=@IdFacture,Qte=@Qte,Designation=@Designation,Unite=@Unite,Puht=@Puht,Tva=@Tva,Ptht=@Ptht WHERE Id=@Id";
                sqlCommand.Parameters.AddWithValue("@IdFacture", item.IdFacture);
                sqlCommand.Parameters.AddWithValue("@Qte", item.Quantite);
                sqlCommand.Parameters.AddWithValue("@Designation", item.Designation);
                sqlCommand.Parameters.AddWithValue("@Unite", item.Unite);
                sqlCommand.Parameters.AddWithValue("@Puht", item.PUHT);
                sqlCommand.Parameters.AddWithValue("@Tva", item.TVA);
                sqlCommand.Parameters.AddWithValue("@Ptht", item.PTHT);
                sqlCommand.Parameters.AddWithValue("@Id", item.Id);
                sqlConnection.Open();
                results = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return results;
        }
        public static int Update(List<Infrastructure.Data.Entities.ArticleEntity> items)
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
        private static int update(List<Infrastructure.Data.Entities.ArticleEntity> items)
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
                        query += " UPDATE [Article] SET "

                            + "[IdFacture]=@IdFacture" + i + ","
                            + "[Qte]=@Qte" + i + ","
                            + "[Designation]=@Designation" + i + ","
                            + "[Unite]=@Unite" + i + ","
                            + "[Puht]=@Puht" + i + ","
                            + "[Tva]=@Tva" + i + ","
                            + "[Ptht]=@Ptht" + i + " WHERE [Id]=@Id" + i
                            + "; ";

                        sqlCommand.Parameters.AddWithValue("Id" + i, item.Id);
                        sqlCommand.Parameters.AddWithValue("IdFacture" + i, item.IdFacture == null ? (object)DBNull.Value : item.IdFacture);
                        sqlCommand.Parameters.AddWithValue("Qte" + i, item.Quantite == null ? (object)DBNull.Value : item.Quantite);
                        sqlCommand.Parameters.AddWithValue("Designation" + i, item.Designation == null ? (object)DBNull.Value : item.Designation);
                        sqlCommand.Parameters.AddWithValue("Unite" + i, item.Unite == null ? (object)DBNull.Value : item.Unite);
                        sqlCommand.Parameters.AddWithValue("Puht" + i, item.PUHT == null ? (object)DBNull.Value : item.PUHT);
                        sqlCommand.Parameters.AddWithValue("Tva" + i, item.TVA == null ? (object)DBNull.Value : item.TVA);
                        sqlCommand.Parameters.AddWithValue("Ptht" + i, item.PTHT == null ? (object)DBNull.Value : item.PTHT);
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
                string query = "DELETE FROM [Article] WHERE [Id]=@Id";
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

                    string query = "DELETE FROM [Article] WHERE [Id] IN (" + queryIds + ")";
                    sqlCommand.CommandText = query;

                    results = sqlCommand.ExecuteNonQuery();
                }

                return results;
            }
            return -1;
        }
        #region Custom methods
        public static List<Infrastructure.Data.Entities.ArticleEntity> GetByFactureId(int id)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Article] WHERE IdFacture=@id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows.Cast<DataRow>().Select(x => new Infrastructure.Data.Entities.ArticleEntity(x)).ToList();
            }
            else
            {
                return new List<Infrastructure.Data.Entities.ArticleEntity>();
            }
        }
        public static int DeleteByDocument(int id)
        {
            int results = -1;
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "DELETE FROM [Article] WHERE [IdFacture]=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);

                results = sqlCommand.ExecuteNonQuery();
            }

            return results;
        }
        #endregion
    }
}
