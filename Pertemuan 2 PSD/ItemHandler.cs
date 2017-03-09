using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Pertemuan_2_PSD
{
    public class ItemHandler: DBConnection
    {
        public int AddItem(Barang barang)
        {
            int result;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO PRODUCT VALUES (@name, @price)";

                    command.Parameters.AddWithValue("name", barang.Nama);
                    command.Parameters.AddWithValue("price", barang.Harga);

                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }

        public int DeleteItem(string ItemName)
        {
            int result;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Product WHERE Name = @1" /* parameter ID could also a number */ , conn))
                {
                    command.Parameters.Add(new SqlParameter("1", ItemName));

                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }

        public DataTable getItems()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //use SqlDataAdapter instead of SqlDataReader, it holds entire table so you can go back and forth the cursor
                //as opposed to SqlDataReader, you cannot reverse the cursor
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", conn))
                {
                    adapter.Fill(dt);
                }

                /*using (SqlCommand command = new SqlCommand("SELECT * FROM Product", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }*/
            }
            return dt;
        }
    }
}