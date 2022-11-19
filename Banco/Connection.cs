using System.Data;
using Npgsql;

namespace Banco{
    public static class Connection {
        private static string host = "ec2-52-1-17-228.compute-1.amazonaws.com",
            database = "d8jer75chm83c8",
            userId = "ekmglxqofosynw",
            password = "70887c7e0cf650cbdc89fafa5d0e36b95ab089bc4c6dfd3637f316de9e8e3be0";

        private static string sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}