using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST324LAB5_Dana_Posey
{
    public static class ResponsesDB
    {
        public static int GetLastResponseID(int respondentID)
        {
            int lastResponseID = 0;

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "SELECT TOP 1 ResponseID " +
                                       "FROM Responses " +
                                       "WHERE RespondentID = @RespondentID " +
                                       "ORDER BY SurveyDate DESC;";

                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    cmd.Parameters.AddWithValue("@RespondentID", respondentID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lastResponseID = Convert.ToInt32(reader["ResponseID"]);
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            return lastResponseID;
        }

        // get responses for a respondent
        public static Response GetResponse(int responseID)
        {
            Response matchingResponse = new Response();

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "SELECT * FROM Responses WHERE ResponseID = @ResponseID";

                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    cmd.Parameters.AddWithValue("@ResponseID", responseID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (responseID == Convert.ToInt32(reader["ResponseID"]))
                            {
                                matchingResponse.ResponseID = Convert.ToInt32(reader["ResponseID"]);
                                matchingResponse.RespondentID = Convert.ToInt32(reader["RespondentID"]);
                                matchingResponse.SurveyDate = (DateTime)reader["SurveyDate"];
                                matchingResponse.Answer1 = reader["Answer1"].ToString();
                                matchingResponse.Answer2 = reader["Answer2"].ToString();
                                matchingResponse.Answer3 = reader["Answer3"].ToString();
                                matchingResponse.Answer4 = reader["Answer4"].ToString();
                                matchingResponse.Answer5 = reader["Answer5"].ToString();
                                matchingResponse.Answer6 = reader["Answer6"].ToString();
                            }
                            else
                            {
                                throw new DataException("Unexpected response returned.");
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

            return matchingResponse;
        }

        // add response set for a respondent
        public static bool AddResponse(Response response)
        {

            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string queryString = "INSERT INTO Responses (RespondentID, SurveyDate, Answer1, Answer2, Answer3, Answer4, Answer5, Answer6)" +
                                        " VALUES (@RespondentID, GETDATE(), @Answer1, @Answer2, @Answer3, @Answer4, @Answer5, @Answer6)";

                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    cmd.Parameters.AddWithValue("@RespondentID", response.RespondentID);
                    cmd.Parameters.AddWithValue("@Answer1", response.Answer1);
                    cmd.Parameters.AddWithValue("@Answer2", response.Answer2);
                    cmd.Parameters.AddWithValue("@Answer3", response.Answer3);
                    cmd.Parameters.AddWithValue("@Answer4", response.Answer4);
                    cmd.Parameters.AddWithValue("@Answer5", response.Answer5);
                    cmd.Parameters.AddWithValue("@Answer6", response.Answer6);
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

        // TODO: delete response set for a respondent
        public static bool DeleteResponse(int responseID)
        {
            try
            {
                using (SqlConnection connection = BicycleStoreCorpDB.GetConnection())
                {
                    string qryString = "DELETE FROM Responses WHERE ResponseID = @ResponseID";

                    SqlCommand cmd = new SqlCommand(qryString, connection);
                    cmd.Parameters.AddWithValue("@ResponseID", responseID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) ;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
        }
    }
}
