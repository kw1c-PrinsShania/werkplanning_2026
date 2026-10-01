using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using T8_Opdracht_Shania_Prins.Models;

/*
    Author:     Shania Prins
    Datum:      20-05-2026

    Subject:    Een werkplanning voor schoolopdrachten
*/

namespace T8_Opdracht_Shania_Prins.Controllers
{
    public class ModuleController
    {
        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=werkplanning_db;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public List<ModuleModel> Read()
        {
            List<ModuleModel> moduleOverzicht = new List<ModuleModel>();

            string SQLQuery = "SELECT * FROM Module JOIN Thema ON Module.ThemaId = Thema.ThemaId JOIN Docent ON Module.DocentId = Docent.DocentId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(SQLQuery, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModuleModel Module = new ModuleModel();
                        Module.Thema = new ThemaModel();
                        Module.Docent = new DocentModel();

                        Module.ModuleId = (int)reader["ModuleId"];
                        Module.ModuleNaam = (string)reader["ModuleNaam"];

                        Module.Thema.ThemaId = (int)reader["ThemaId"];
                        Module.Thema.ThemaNaam = (string)reader["ThemaNaam"];
                        Module.Docent.DocentId = (int)reader["DocentId"];
                        Module.Docent.Voornaam = (string)reader["Voornaam"];
                        if (!reader.IsDBNull(reader.GetOrdinal("Tussenvoegsel")))
                        {
                            Module.Docent.Tussenvoegsel = (string)reader["Tussenvoegsel"];
                        }
                        else
                        {
                            Module.Docent.Tussenvoegsel = "";
                        }
                        Module.Docent.Achternaam = (string)reader["Achternaam"];
                        Module.Docent.Afbeelding = (string)reader["Afbeelding"];

                        moduleOverzicht.Add(Module);
                    }
                }
            }
            return moduleOverzicht;
        }

        public int Delete(ModuleModel module)
        {
            string sql = "DELETE FROM Module WHERE ModuleId = @ModuleId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ModuleId", module.ModuleId);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // laat error door naar form
                throw ex;
            }
        }
    }
}
