using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pertemuan_2_PSD
{
    public class DBConnection
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        SqlConnection dbConnection;

        public DBConnection()
        {
            //dbConnection = new SqlConnection(connectionString);
        }

        ~DBConnection()
        {
            //dbConnection.Close();
        }

        public DataTable ExecuteQuery(string query)
        {
            /*
             * if(dbConnecytion.State == ConnectionState.Open) {
             *    dbConnection.Close();
             * }
             * 
             */
            DataTable dt = new DataTable();

            using (dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                using(SqlCommand command = new SqlCommand(query, dbConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}