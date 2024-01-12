using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Access
{
    public class EmployeeAccess
    {
        public static int MAX_BATCH_SIZE = 500;
        public static List<Infrastructure.Data.Entities.EmployeeEntity> Get()
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Employee]";
                var sqlCommand = new OleDbCommand(query, sqlConnection);

                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows.Cast<DataRow>().Select(x => new Infrastructure.Data.Entities.EmployeeEntity(x)).ToList();
            }
            else
            {
                return new List<Infrastructure.Data.Entities.EmployeeEntity>();
            }
        }
        public static Infrastructure.Data.Entities.EmployeeEntity Get(int id)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM [Employee] WHERE Id=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);
                new OleDbDataAdapter(sqlCommand).Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return new Infrastructure.Data.Entities.EmployeeEntity(dataTable.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public static int Insert(Infrastructure.Data.Entities.EmployeeEntity item)
        {
            int response = int.MinValue;
            using (var sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            {
                sqlConnection.Open();
                var sqlTransaction = sqlConnection.BeginTransaction();

                string query = "INSERT INTO [Employee] ([NomPrenom],[TarifJounalier]) VALUES (@NomPrenom,@TarifJounalier); ";

                using (var sqlCommand = new OleDbCommand(query, sqlConnection, sqlTransaction))
                {

                    sqlCommand.Parameters.AddWithValue("NomPrenom", item.NomPrenom == null ? (object)DBNull.Value : item.NomPrenom);
                    sqlCommand.Parameters.AddWithValue("TarifJounalier", item.TarifJounalier == null ? (object)DBNull.Value : item.TarifJounalier);

                    var result = sqlCommand.ExecuteScalar();
                    response = result == null ? int.MinValue : int.TryParse(result.ToString(), out var insertedId) ? insertedId : int.MinValue;
                }
                sqlTransaction.Commit();

                return response;
            }
        }
        public static int Update(Infrastructure.Data.Entities.EmployeeEntity item)
        {
            int results = -1;
            using (OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionstringdev"].ConnectionString))
            using (OleDbCommand sqlCommand = sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = @"UPDATE [Employee] SET NomPrenom=@NomPrenom,TarifJounalier=@TarifJounalier WHERE Id=@Id";
                sqlCommand.Parameters.AddWithValue("@NomPrenom", item.NomPrenom);
                sqlCommand.Parameters.AddWithValue("@TarifJounalier", item.TarifJounalier);
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
                string query = "DELETE FROM [Employee] WHERE [Id]=@Id";
                var sqlCommand = new OleDbCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", id);

                results = sqlCommand.ExecuteNonQuery();
            }

            return results;
        }
    }
}
