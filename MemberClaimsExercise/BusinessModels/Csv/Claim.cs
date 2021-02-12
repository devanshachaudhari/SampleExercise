using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BusinessModels.Csv
{
    public class Claim
    {
        [JsonIgnore]
        [Name("MemberID")]
        public int MemberID { get; set; }

        [Name("ClaimDate")]
        public DateTime ClaimDate { get; set; }

        [Name("ClaimAmount")]
        public double ClaimAmount { get; set; }

    }
}
