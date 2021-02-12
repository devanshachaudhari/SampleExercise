using System;
using System.Collections.Generic;
using BusinessModels.Custom;

namespace BusinessServices
{
    public interface IClaimService
    {
        IList<MemberClaims> GetClaimsByMember(DateTime? asOfDate = null);
    }
}
