using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using T8_Opdracht_Shania_Prins.Models;

/*
    Author:     Shania Prins
    Datum:      20-05-2026

    Subject:    Een werkplanning voor schoolopdrachten
*/

namespace T8_Opdracht_Shania_Prins.Controllers
{
    public class ThemaController
    {
        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=werkplanning_db;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public List<ThemaModel> Read()
        {
            List<ThemaModel> themaOverzicht = new List<ThemaModel>();

            string SQLQuery = "SELECT * FROM Thema";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(SQLQuery, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThemaModel thema = new ThemaModel
                        {
                            ThemaId = (int)reader["ThemaId"],
                            ThemaNaam = (string)reader["ThemaNaam"],
                        };

                        themaOverzicht.Add(thema);
                    }
                }
            }
            return themaOverzicht;
        }
    }
}
