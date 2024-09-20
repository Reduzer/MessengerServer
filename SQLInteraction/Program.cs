using System;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace SQLInteraction
{
    public class SQLInteraction
    {
        private void SendToSQL() 
        {
            try
            {
                SqlConnectionStringBuilder STRBuilder = new SqlConnectionStringBuilder();

                STRBuilder.DataSource = "FDEU-131\\SQLEXPRESS";
                STRBuilder.UserID = "sa";
                STRBuilder.Password = "adi28199!";
                STRBuilder.InitialCatalog = "Test";

                using (SqlConnection connection = new SqlConnection(STRBuilder.ConnectionString))
                {
                    connection.Open();

                    string sqlCommand = "Select * FROM dbo.Table1";

                    using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(reader.GetString(0));
                            }
                        }
                    }
                        connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception catched: " + e.Message);
            }
        }     
    }
}
