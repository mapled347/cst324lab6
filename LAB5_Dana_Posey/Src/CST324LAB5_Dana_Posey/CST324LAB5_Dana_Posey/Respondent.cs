using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST324LAB5_Dana_Posey
{
    public class Respondent
    {
        public int RespondentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateAbbr { get; set; }
        public string ZipCode { get; set; }
        public DateTime LastSurvey { get; set; }

        public override bool Equals(object obj)
        {
            var respondent = obj as Respondent;

            if (respondent != null)
                return RespondentID.ToString().Equals(respondent.RespondentID.ToString(), StringComparison.Ordinal) && 
                       FirstName.Equals(respondent.FirstName) &&
                       LastName.Equals(respondent.LastName) &&
                       EmailAddress.Equals(respondent.EmailAddress) &&
                       AddressLine1.Equals(respondent.AddressLine1) &&
                       AddressLine2.Equals(respondent.AddressLine2) &&
                       City.Equals(respondent.City) &&
                       StateAbbr.Equals(respondent.StateAbbr) &&
                       ZipCode.Equals(respondent.ZipCode) &&
                       LastSurvey.Equals(respondent.LastSurvey);

            return false;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
