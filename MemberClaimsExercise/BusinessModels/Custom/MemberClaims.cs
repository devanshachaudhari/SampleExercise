using BusinessModels.Csv;
using System.Collections.Generic;

namespace BusinessModels.Custom
{
    public class MemberClaims : Member
    {
        public IList<Claim> Claims { get; set; }
    }
}
