using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using T8_Opdracht_Shania_Prins.Models;

/*
    Author:     Shania Prins
    Datum:      20-05-2026

    Subject:    Een werkplanning voor schoolopdrachten
*/

namespace T8_Opdracht_Shania_Prins.Controllers
{
    public class TakenController
    {
        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=werkplanning_db;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public List<TakenModel> Read()
        {
            List<TakenModel> takenLijst = new List<TakenModel>();

            string sql = "SELECT * FROM Taak";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        takenLijst.Add(new TakenModel
                        {
                            TaakId = (int)reader["TaakId"],
                            Taaknaam = reader["Taaknaam"].ToString(),
                            Omschrijving = reader["Omschrijving"].ToString(),
                            Startdatum = (DateTime)reader["Startdatum"],
                            Inleverdatum = (DateTime)reader["Inleverdatum"],
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }

            return takenLijst;
        }

        public int Delete(TakenModel taak)
        {
            string sql = "DELETE FROM Taak WHERE TaakId = @TaakId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@TaakId", taak.TaakId);

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}