using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST324LAB5_Dana_Posey
{
    public class Response
    {
        public int ResponseID { get; set; }
        public int RespondentID { get; set; }
        public DateTime SurveyDate { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public string Answer6 { get; set; }

        public override bool Equals(object obj)
        {
            var response = obj as Response;

            if (response != null)
                return ResponseID.ToString().Equals(response.ResponseID.ToString(), StringComparison.Ordinal) &&
                       RespondentID.Equals(response.RespondentID) &&
                       SurveyDate.Equals(response.SurveyDate) &&
                       Answer1.Equals(response.Answer1) &&
                       Answer2.Equals(response.Answer2) &&
                       Answer3.Equals(response.Answer3) &&
                       Answer4.Equals(response.Answer4) &&
                       Answer5.Equals(response.Answer5) &&
                       Answer6.Equals(response.Answer6);

            return false;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
