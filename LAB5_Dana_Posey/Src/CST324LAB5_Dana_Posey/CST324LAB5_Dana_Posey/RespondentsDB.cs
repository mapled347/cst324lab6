using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CST324LAB5_Dana_Posey
{
    public static class RespondentsDB
    {
        // get repondent ID by email
        public static int GetRespondentID(string email)
        {
            int respondentID = 0;

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "SELECT RespondentID " +
                                       "FROM Respondents " +
                                       "WHERE EmailAddress = @EmailAddress ";
                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    cmd.Parameters.AddWithValue("@EmailAddress", email);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            respondentID = Convert.ToInt32(reader["RespondentID"]);
                        }
                        connection.Close();
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            return respondentID;
        }

        // check if email exists in respondents table
        public static bool EmailExists(string email)
        {
            int result = 0;

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "SELECT COUNT(EmailAddress) AS num " +
                                       "FROM Respondents " +
                                       "WHERE EmailAddress = @EmailAddress " +
                                       "GROUP BY EmailAddress; ";
                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    cmd.Parameters.AddWithValue("@EmailAddress", email);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = Convert.ToInt32(reader["num"]);
                        }
                        connection.Close();
                    }
                }

                if (result == 1) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
        }   

        // get the respondent information
        public static Respondent GetRespondent(string email)
        {
            Respondent matchingRespondent = new Respondent();

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "SELECT * FROM Respondents WHERE EmailAddress = @Email";

                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (email.Equals(reader["EmailAddress"].ToString()))
                            {
                                matchingRespondent.RespondentID = Convert.ToInt32(reader["RespondentID"]);
                                matchingRespondent.FirstName = reader["FirstName"].ToString();
                                matchingRespondent.LastName = reader["LastName"].ToString();
                                matchingRespondent.EmailAddress = reader["EmailAddress"].ToString();
                                matchingRespondent.AddressLine1 = reader["AddressLine1"].ToString();
                                matchingRespondent.AddressLine2 = reader["AddressLine2"].ToString();
                                matchingRespondent.City = reader["City"].ToString();
                                matchingRespondent.StateAbbr = reader["StateAbbr"].ToString();
                                matchingRespondent.ZipCode = reader["ZipCode"].ToString();
                                matchingRespondent.LastSurvey = (DateTime)reader["LastSurvey"];
                            }
                            else
                            {
                                throw new DataException("Unexpected respondent returned.");
                            }
                            // connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }


            return matchingRespondent;
        }

        // check last survey date
        public static bool CheckLastSurveyDate(string email)
        {
            int result = 0;

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "SELECT DATEDIFF(year, GETDATE(), LastSurvey) as Years " +
                                       "FROM Respondents " +
                                       "WHERE EmailAddress = @EmailAddress ";
                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    cmd.Parameters.AddWithValue("@EmailAddress", email);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = Convert.ToInt32(reader["Years"]);
                        }
                        connection.Close();
                    }
                }

                if (result >= 1) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
        }

        // TODO: add a respondent
        public static bool AddRespondent(Respondent respondent)
        {

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string queryString = "INSERT INTO Respondents (FirstName, LastName, EmailAddress, AddressLine1, AddressLine2, City, StateAbbr, ZipCode, LastSurvey)" +
                                        " VALUES (@FirstName, @LastName, @EmailAddress, @AddressLine1, @AddressLine2, @City, @StateAbbr, @ZipCode, GETDATE())";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@FirstName", respondent.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", respondent.LastName);
                    cmd.Parameters.AddWithValue("@EmailAddress", respondent.EmailAddress);
                    cmd.Parameters.AddWithValue("@AddressLine1", respondent.AddressLine1);
                    cmd.Parameters.AddWithValue("@AddressLine2", respondent.AddressLine2);
                    cmd.Parameters.AddWithValue("@City", respondent.City);
                    cmd.Parameters.AddWithValue("@StateAbbr", respondent.StateAbbr);
                    cmd.Parameters.AddWithValue("@ZipCode", respondent.ZipCode);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }

            return true;

            // throw new NotImplementedException();
        }

        // TODO: modify a respondent

        // TODO: delete a respondent

        public static int GetLastRespondentID()
        {
            int lastRespondentID = 0;

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "SELECT TOP 1 RespondentID " +
                                       "FROM Respondents " +
                                       "ORDER BY RespondentID DESC;";

                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lastRespondentID = Convert.ToInt32(reader["RespondentID"]);
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            return lastRespondentID;
        }
    }
}
