using CsvHelper.Configuration.Attributes;

using System;

namespace BusinessModels.Csv
{
    public class Member
    {
        [Name("MemberID")]
        public int MemberID { get; set; }
        [Name("EnrollmentDate")]
        public DateTime EnrollmentDate { get; set; }
        [Name("FirstName")]
        public string FirstName { get; set; }
        [Name("LastName")]
        public string LastName { get; set; }
    }
}
